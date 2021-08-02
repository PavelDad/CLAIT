using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLAIT.EmployeeForms;
using CLAIT.EquipmentForms;
using CLAIT.Model;
using CLAIT.Reports;
using CLAIT.SlaveTableForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CLAIT
{
    public enum Actions { Add, Edit };
    public partial class frmMain : Form
    {
        public static Icon MyIcon { get; set; } = Properties.Resources.aoki;
        private static ClaitContext _db;

        public static ClaitContext Db
        {
            get {
                if (_db == null)
                {
                    _db = new ClaitContext();
                }
                return _db; 
            }
        }

        private bool NullableContains<T>(T slaveObject, string filter) where T : class, INameble 
        {
            if (slaveObject != null)
            {
                return slaveObject.Name.ToLower().Contains(filter);
            }
            return true;
        }

        async Task ReloadTableAsync()
        {
            var filter = tbxFilter.Text.ToLower();
            var sbl = new SortableBindingList<Equipment>(
                (await frmMain.Db.Equipments.ToListAsync())
                .Where(x => x.Id.ToLower().Contains(filter)
                    || x.Model.ToLower().Contains(filter)
                    || NullableContains<Producer>(x.Producer, filter)
                    || NullableContains<Category>(x.Category, filter)
                    )
                .OrderBy(x => x.Id)
                .ToList());
            equipmentBindingSource.DataSource = sbl;
        }

        async Task ReloadECAsync()
        {
            if (equipmentBindingSource.Current == null)
            {
                return;
            }
            var currentEquipment = (Equipment)equipmentBindingSource.Current;
            var filter = tbxECFilter.Text.ToLower();
            var sbl = new SortableBindingList<EquipmentCabinet>(
                (await frmMain.Db.EquipmentsCabinets.ToListAsync())
                .Where(x=>(
                    currentEquipment == x.Equipment
                    &&(NullableContains<Cabinet>(x.Cabinet, filter)
                    || NullableContains<Employee>(x.Employee, filter))
                    ))
                .OrderByDescending(x => x.InstallationDate)
                .ToList());
            equipmentCabinetBindingSource.DataSource = sbl;
        }

        public frmMain()
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSlaveTableView())
            {
                frm.ShowDialog();
                await ReloadTableAsync();
            }
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            //btnEmployees_Click(btnEmployees, new EventArgs());
            await ReloadTableAsync();
        }

        private async void btnEmployees_Click(object sender, EventArgs e)
        {
            using (var frm = new frmEmployeeView())
            {
                frm.ShowDialog();
                await ReloadTableAsync();
            }
        }

        private async void pbxAdd_Click(object sender, EventArgs e)
        {
            //Add
            using (var frm = new frmEquipmentEdit())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    await ReloadTableAsync();
                }
            }
        }

        private async void pbxEdit_Click(object sender, EventArgs e)
        {
            //Edit
            if (equipmentBindingSource.Current == null)
            {
                MessageBox.Show("Не выбрано оборудование для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var frm = new frmEquipmentEdit((Equipment)equipmentBindingSource.Current))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    await ReloadTableAsync();
                }

            }
        }

        private async void pbxDelete_Click(object sender, EventArgs e)
        {
            //Delete
            if (equipmentBindingSource.Current == null)
            {
                MessageBox.Show("Не выбрано оборудование для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выбранное оборудование?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            frmMain.Db.Equipments.Remove((Equipment)equipmentBindingSource.Current);
            await frmMain.Db.SaveChangesAsync();
            await ReloadTableAsync();
        }

        private async void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            await ReloadTableAsync();
        }

        private void pbxClear_Click(object sender, EventArgs e)
        {
            tbxFilter.Text = string.Empty;
        }

        private void pbxAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top += 2;
            ((PictureBox)sender).Left += 2;
        }

        private void pbxAdd_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top -= 2;
            ((PictureBox)sender).Left -= 2;
        }

        private async void dgvEquipments_SelectionChanged(object sender, EventArgs e)
        {
            await ReloadECAsync();
        }

        private async void tbxECFilter_TextChanged(object sender, EventArgs e)
        {
            await ReloadECAsync();
        }

        private void pbxECClear_Click(object sender, EventArgs e)
        {
            tbxECFilter.Text = string.Empty;
        }

        private async void pbxECAdd_Click(object sender, EventArgs e)
        {
            //Edit
            if (equipmentBindingSource.Current == null)
            {
                MessageBox.Show("Не выбрано оборудование.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var frm = new frmEquipmentsCabinetEdit((Equipment)equipmentBindingSource.Current))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    await ReloadTableAsync();
                }

            }
        }

        private async void pbxECEdit_Click(object sender, EventArgs e)
        {
            if (equipmentBindingSource.Current == null)
            {
                MessageBox.Show("Не выбрано оборудование.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (equipmentCabinetBindingSource.Current == null)
            {
                MessageBox.Show("Не выбрана запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var frm = new frmEquipmentsCabinetEdit((EquipmentCabinet)equipmentCabinetBindingSource.Current))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    await ReloadTableAsync();
                }

            }
        }

        private async void pbxECDelete_Click(object sender, EventArgs e)
        {
            if (equipmentCabinetBindingSource.Current == null)
            {
                MessageBox.Show("Не выбрана запись для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            frmMain.Db.EquipmentsCabinets.Remove((EquipmentCabinet)equipmentCabinetBindingSource.Current);
            await frmMain.Db.SaveChangesAsync();
            await ReloadTableAsync();
        }

        private async void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSlaveTableView(0))
            {
                frm.ShowDialog();
                await ReloadTableAsync();
            }
        }

        private async void producereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSlaveTableView(1))
            {
                frm.ShowDialog();
                await ReloadTableAsync();
            }
        }

        private async void cabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSlaveTableView(2))
            {
                frm.ShowDialog();
                await ReloadTableAsync();
            }
        }

        private async void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSlaveTableView(3))
            {
                frm.ShowDialog();
                await ReloadTableAsync();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void equipmentFromEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmEquipmentFromEmployee())
            {
                frm.ShowDialog();
            }
        }

        private void equipmentFromCabinetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmEquipmentsFromCabinet())
            {
                frm.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }
    }
}
