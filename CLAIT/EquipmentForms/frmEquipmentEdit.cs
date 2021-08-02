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
    public partial class frmEquipmentEdit : Form
    {
        public Equipment Equipment { get; }
        public Actions Action { get; }

        private frmEquipmentEdit(Equipment equipment, Actions action)
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
            Equipment = equipment;
            Action = action;
            if (Action == Actions.Edit)
            {
                tbxId.Enabled = false;
            }
        }

        public frmEquipmentEdit() : this(new Equipment(), Actions.Add)
        {
            this.Text = "Добавление оборудования";
        }
        public frmEquipmentEdit(Equipment equipment) : this(equipment, Actions.Edit)
        {
            this.Text = "Редактирование оборудования";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void frmEquipmentEdit_Load(object sender, EventArgs e)
        {
            if (frmMain.Db.Producers.Count() < 1)
            {
                MessageBox.Show("Добавьте производителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            if (frmMain.Db.Categories.Count() < 1)
            {
                MessageBox.Show("Добавьте тип оборудования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            cbxProducer.DataSource = (await frmMain.Db.Producers.ToListAsync()).OrderBy(x => x.Name).ToList();
            cbxCategory.DataSource = (await frmMain.Db.Categories.ToListAsync()).OrderBy(x => x.Name).ToList();
            switch (Action)
            {
                case Actions.Add:
                    tbxId.Text = string.Empty;
                    tbxModel.Text = string.Empty;
                    cbxCategory.SelectedIndex = 0;
                    cbxProducer.SelectedIndex = 0;
                    dtpEntranceDate.Value = DateTime.Now.Date;
                    break;
                case Actions.Edit:
                    tbxId.Text = Equipment.Id;
                    tbxModel.Text = Equipment.Model;
                    if (Equipment.ProducerId.HasValue)
                    {
                        cbxProducer.SelectedItem = Equipment.Producer;
                    }
                    if (Equipment.CategoryId.HasValue)
                    {
                        cbxCategory.SelectedItem = Equipment.Category;
                    }
                    dtpEntranceDate.Value = Equipment.EntranceDate.Date;
                    break;
                default:
                    break;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Action == Actions.Add)
            {
                Equipment.Id = tbxId.Text;
            }
            Equipment.Model = tbxModel.Text;
            Equipment.Producer = (Producer)cbxProducer.SelectedItem;
            Equipment.Category = (Category)cbxCategory.SelectedItem;
            Equipment.EntranceDate = dtpEntranceDate.Value.Date;
            if (Action == Actions.Add)
            {
                frmMain.Db.Equipments.Add(Equipment);
            }
            await frmMain.Db.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }
    }
}
