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

namespace CLAIT.EquipmentForms
{
    public partial class frmEquipmentsCabinetEdit : Form
    {
        public Equipment Equipment { get; }
        public EquipmentCabinet EquipmentCabinet { get; set; }
        public Actions Action { get; }

        private frmEquipmentsCabinetEdit(Equipment equipment, EquipmentCabinet equipmentCabinet, Actions action)
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
            Equipment = equipment;
            EquipmentCabinet = equipmentCabinet;
            Action = action;
        }

        public frmEquipmentsCabinetEdit(Equipment equipment) : this(equipment, new EquipmentCabinet(), Actions.Add)
        {
            this.Text = "Добавление";
        }

        public frmEquipmentsCabinetEdit(EquipmentCabinet equipmentCabinet) : this(equipmentCabinet.Equipment, equipmentCabinet, Actions.Edit)
        {
            this.Text = "Редактирование";
        }

        private async void frmEquipmentsCabinetEdit_Load(object sender, EventArgs e)
        {
            if (frmMain.Db.Cabinets.Count() < 1)
            {
                MessageBox.Show("Добавьте кабинет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            if (frmMain.Db.Employees.Count() < 1)
            {
                MessageBox.Show("Добавьте сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            lblEquipmentId.Text = Equipment.Id;
            lblEquipmentModel.Text = Equipment.Model;
            lblEquipmentEntranceDate.Text = Equipment.EntranceDate.Date.ToShortDateString();
            if (Equipment.ProducerId.HasValue)
            {
                lblEquipmentProducer.Text = Equipment.Producer.Name;
            }
            else
            {
                lblEquipmentProducer.Text = "-";
            }
            if (Equipment.CategoryId.HasValue)
            {
                lblEquipmentCategory.Text = Equipment.Category.Name;
            }
            else
            {
                lblEquipmentProducer.Text = "-";
            }

            cbxCabinet.DataSource = (await frmMain.Db.Cabinets.ToListAsync()).OrderBy(x => x.Name).ToList();
            cbxEmployee.DataSource = (await frmMain.Db.Employees.ToListAsync()).OrderBy(x => x.Name).ToList();
            switch (Action)
            {
                case Actions.Add:
                    cbxCabinet.SelectedIndex = 0;
                    cbxEmployee.SelectedIndex = 0;
                    dtpInstallationDate.Value = DateTime.Now.Date;
                    break;
                case Actions.Edit:
                    if (EquipmentCabinet.CabinetId.HasValue)
                    {
                        cbxCabinet.SelectedItem = EquipmentCabinet.Cabinet;
                    }
                    if (!string.IsNullOrWhiteSpace(EquipmentCabinet.EmployeeId))
                    {
                        cbxEmployee.SelectedItem = EquipmentCabinet.Employee;
                    }
                    dtpInstallationDate.Value = EquipmentCabinet.InstallationDate.Date;
                    break;
                default:
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
                EquipmentCabinet.Equipment = Equipment;
            }
            EquipmentCabinet.Cabinet = (Cabinet)cbxCabinet.SelectedItem;
            EquipmentCabinet.Employee = (Employee)cbxEmployee.SelectedItem;
            EquipmentCabinet.InstallationDate = dtpInstallationDate.Value.Date;

            if (Action == Actions.Add)
            {
                frmMain.Db.EquipmentsCabinets.Add(EquipmentCabinet);
            }
            await frmMain.Db.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }
    }
}
