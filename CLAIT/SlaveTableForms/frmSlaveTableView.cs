using CLAIT.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLAIT.SlaveTableForms
{
    public partial class frmSlaveTableView : Form
    {
        BindingSource currentBindingSource;

        public frmSlaveTableView() : this(0) { }

        public frmSlaveTableView(int tabIndex)
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
            tabControl1.SelectTab(tabIndex);
            tabControl1_Selected(tabControl1, new TabControlEventArgs(tabControl1.TabPages[tabIndex], tabIndex, TabControlAction.Selected));
        }

        async Task ReloadTableAsync<T>(BindingSource bindingSource, DbSet<T> entity) where T : class, ISlaveTable
        {
            var filter = tbxFilter.Text.ToLower();
            var sbl = new SortableBindingList<T>((await entity.ToListAsync()).Where(x => x.Name.ToLower().Contains(filter)).OrderBy(x => x.Name).ToList());
            bindingSource.DataSource = sbl;
            foreach (var item in tabControl1.SelectedTab.Controls)
            {
                if (item is DataGridView)
                {
                    ((DataGridView)item).Columns[0].Visible = false;
                }
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top += 2;
            ((PictureBox)sender).Left += 2;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top -= 2;
            ((PictureBox)sender).Left -= 2;
        }

        private async void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            var name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;
            switch (name)
            {
                case "tpgCategories":
                    currentBindingSource = categoryBindingSource;
                    await ReloadTableAsync<Category>(currentBindingSource, frmMain.Db.Categories);
                    break;
                case "tpgProducers":
                    currentBindingSource = producerBindingSource;
                    await ReloadTableAsync<Producer>(currentBindingSource, frmMain.Db.Producers);
                    break;
                case "tpgCabinets":
                    currentBindingSource = cabinetBindingSource;
                    await ReloadTableAsync<Cabinet>(currentBindingSource, frmMain.Db.Cabinets);
                    break;
                case "tpgPositions":
                    currentBindingSource = positionBindingSource;
                    await ReloadTableAsync<Position>(currentBindingSource, frmMain.Db.Positions);
                    break;
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;
            switch (name)
            {
                case "tpgCategories":
                    currentBindingSource = categoryBindingSource;
                    using (var frm = new frmSlaveTableEdit<Category>())
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Category>(currentBindingSource, frmMain.Db.Categories);
                        }
                    }
                    break;
                case "tpgProducers":
                    currentBindingSource = producerBindingSource;
                    using (var frm = new frmSlaveTableEdit<Producer>())
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Producer>(currentBindingSource, frmMain.Db.Producers);
                        }
                    }
                    break;
                case "tpgCabinets":
                    currentBindingSource = cabinetBindingSource;
                    using (var frm = new frmSlaveTableEdit<Cabinet>())
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Cabinet>(currentBindingSource, frmMain.Db.Cabinets);
                        }
                    }
                    break;
                case "tpgPositions":
                    currentBindingSource = positionBindingSource;
                    using (var frm = new frmSlaveTableEdit<Position>())
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Position>(currentBindingSource, frmMain.Db.Positions);
                        }
                    }
                    break;
            }
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            var name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;

            if (currentBindingSource.Current == null)
            {
                MessageBox.Show("Выберите строку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object selectedRecord = currentBindingSource.Current;
            switch (name)
            {
                case "tpgCategories":
                    using (var frm = new frmSlaveTableEdit<Category>((Category)selectedRecord))
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Category>(currentBindingSource, frmMain.Db.Categories);
                        }
                    }
                    break;
                case "tpgProducers":
                    using (var frm = new frmSlaveTableEdit<Producer>((Producer)selectedRecord))
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Producer>(currentBindingSource, frmMain.Db.Producers);
                        }
                    }
                    break;
                case "tpgCabinets":
                    using (var frm = new frmSlaveTableEdit<Cabinet>((Cabinet)selectedRecord))
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Cabinet>(currentBindingSource, frmMain.Db.Cabinets);
                        }
                    }
                    break;
                case "tpgPositions":
                    using (var frm = new frmSlaveTableEdit<Position>((Position)selectedRecord))
                    {
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                        {
                            await ReloadTableAsync<Position>(currentBindingSource, frmMain.Db.Positions);
                        }
                    }
                    break;
            }
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            if (currentBindingSource.Current == null)
            {
                MessageBox.Show("Выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            frmMain.Db.Remove(currentBindingSource.Current);
            await frmMain.Db.SaveChangesAsync();

            var name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;
            switch (name)
            {
                case "tpgCategories":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Categories);
                    break;
                case "tpgProducers":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Producers);
                    break;
                case "tpgCabinets":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Cabinets);
                    break;
                case "tpgPositions":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Positions);
                    break;
            }
        }


        private async void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            var name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;
            switch (name)
            {
                case "tpgCategories":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Categories);
                    break;
                case "tpgProducers":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Producers);
                    break;
                case "tpgCabinets":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Cabinets);
                    break;
                case "tpgPositions":
                    await ReloadTableAsync(currentBindingSource, frmMain.Db.Positions);
                    break;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbxFilter.Text = string.Empty;
        }
    }
}
