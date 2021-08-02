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

namespace CLAIT.SlaveTableForms
{
    public partial class frmSlaveTableEdit<T> : Form where T : class, ISlaveTable, new()
    {

        frmSlaveTableEdit(T currentRecord, Actions action)
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
            CurrentRecord = currentRecord;
            Action = action;
        }

        public frmSlaveTableEdit() : this(new T(), Actions.Add)
        {
            this.Text = "Добавление";
        }
        public frmSlaveTableEdit(T currentRecord) : this(currentRecord, Actions.Edit)
        {
            this.Text = "Редактирование";
        }

        public T CurrentRecord { get; }
        public Actions Action { get; }

        private void frmSlaveTableEdit_Load(object sender, EventArgs e)
        {
            switch (Action)
            {
                case Actions.Add:
                    tbxName.Text = string.Empty;
                    break;
                case Actions.Edit:
                    tbxName.Text = CurrentRecord.Name;
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
            CurrentRecord.Name = tbxName.Text;
            frmMain.Db.Update(CurrentRecord);
            await frmMain.Db.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }

        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave_Click(btnSave, new EventArgs());
            }
        }
    }
}
