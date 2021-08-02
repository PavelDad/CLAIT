using CLAIT.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLAIT.EmployeeForms
{
    public partial class frmEmployeeEdit : Form
    {
        public Employee Employee { get; }
        public Actions Action { get; }

        frmEmployeeEdit(Employee employee, Actions action)
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
            Employee = employee;
            Action = action;
            if (Action == Actions.Edit)
            {
                tbxId.Enabled = false;
            }
        }

        public frmEmployeeEdit() : this(new Employee(), Actions.Add)
        {
            this.Text = "Добавление сотрудника";
        }
        public frmEmployeeEdit(Employee employee) : this(employee, Actions.Edit)
        {
            this.Text = "Редактирование сотрудника";
        }

        private async void frmEmployeeEdit_Load(object sender, EventArgs e)
        {
            if (frmMain.Db.Positions.Count() < 1)
            {
                MessageBox.Show("Добавьте должности", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            cbxPosition.DataSource = (await frmMain.Db.Positions.ToListAsync()).OrderBy(x => x.Name).ToList();
            switch (Action)
            {
                case Actions.Add:
                    tbxId.Text = string.Empty;
                    tbxName.Text = string.Empty;
                    tbxPhone.Text = string.Empty;
                    cbxPosition.SelectedIndex = 0;
                    break;
                case Actions.Edit:
                    tbxId.Text = Employee.Id;
                    tbxId.Enabled = false;
                    tbxName.Text = Employee.Name;
                    tbxPhone.Text = Employee.Phone;
                    if (Employee.PositionId.HasValue)
                    {
                        cbxPosition.SelectedItem = Employee.Position;
                    }
                    else
                    {
                        cbxPosition.SelectedIndex = 0;
                    }
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Action == Actions.Add)
            {
                Employee.Id = tbxId.Text;
            }
            Employee.Name = tbxName.Text;
            Employee.Phone = tbxPhone.Text;
            Employee.Position = (Position)cbxPosition.SelectedItem;
            if (Action == Actions.Add)
            {
                frmMain.Db.Employees.Add(Employee);
            }
            await frmMain.Db.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }
    }
}
