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
using CLAIT.Model;
using Microsoft.EntityFrameworkCore;

namespace CLAIT.EmployeeForms
{
    public partial class frmEmployeeView : Form
    {
        public frmEmployeeView()
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
        }

        private bool Log(bool msg)
        {
            MessageBox.Show(msg.ToString()); 
            return msg;
        }

        private bool NullableContains(Position position, string filter)
        {
            if (position != null)
            {
                return position.Name.ToLower().Contains(filter);
            }
            return true;
        }

        async Task ReloadTableAsync()
        {
            var filter = tbxFilter.Text.ToLower();
            var sbl = new SortableBindingList<Employee>(
                (await frmMain.Db.Employees.ToListAsync())
                .Where(x => x.Name.ToLower().Contains(filter)
                    || x.Phone.ToLower().Contains(filter)
                    || NullableContains(x.Position, filter)
                    )
                .OrderBy(x => x.Name)
                .ToList());
            employeeBindingSource.DataSource = sbl;
        }

        private async void frmEmployeeView_Load(object sender, EventArgs e)
        {
            await ReloadTableAsync();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tbxFilter.Text = string.Empty;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top -= 2;
            ((PictureBox)sender).Left -= 2;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top += 2;
            ((PictureBox)sender).Left += 2;
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            //Edit
            if (employeeBindingSource.Current == null)
            {
                MessageBox.Show("Не выбран сотрудник для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var frm = new frmEmployeeEdit((Employee)employeeBindingSource.Current))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    await ReloadTableAsync();
                }

            }
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            //Delete
            if (employeeBindingSource.Current == null)
            {
                MessageBox.Show("Не выбран сотрудник для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выбранного сотрудника?","Удаление",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            frmMain.Db.Employees.Remove((Employee)employeeBindingSource.Current);
            await frmMain.Db.SaveChangesAsync();
            await ReloadTableAsync();
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            //Add
            using (var frm = new frmEmployeeEdit())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    await ReloadTableAsync();
                }
            }
        }

        private async void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            await ReloadTableAsync();
        }
    }
}
