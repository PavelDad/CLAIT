
namespace CLAIT.EquipmentForms
{
    partial class frmEquipmentEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.lblEntranceDate = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxProducer = new System.Windows.Forms.ComboBox();
            this.dtpEntranceDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(68, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Инв. номер:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(107, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(202, 20);
            this.tbxId.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Категория:";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(12, 67);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(89, 13);
            this.lblProducer.TabIndex = 0;
            this.lblProducer.Text = "Производитель:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 93);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Модель:";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(107, 90);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(202, 20);
            this.tbxModel.TabIndex = 1;
            // 
            // lblEntranceDate
            // 
            this.lblEntranceDate.AutoSize = true;
            this.lblEntranceDate.Location = new System.Drawing.Point(12, 119);
            this.lblEntranceDate.Name = "lblEntranceDate";
            this.lblEntranceDate.Size = new System.Drawing.Size(86, 13);
            this.lblEntranceDate.TabIndex = 0;
            this.lblEntranceDate.Text = "Дата поставки:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(107, 37);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(202, 21);
            this.cbxCategory.TabIndex = 2;
            // 
            // cbxProducer
            // 
            this.cbxProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducer.FormattingEnabled = true;
            this.cbxProducer.Location = new System.Drawing.Point(107, 64);
            this.cbxProducer.Name = "cbxProducer";
            this.cbxProducer.Size = new System.Drawing.Size(202, 21);
            this.cbxProducer.TabIndex = 2;
            // 
            // dtpEntranceDate
            // 
            this.dtpEntranceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntranceDate.Location = new System.Drawing.Point(107, 116);
            this.dtpEntranceDate.Name = "dtpEntranceDate";
            this.dtpEntranceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEntranceDate.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(151, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEquipmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 179);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEntranceDate);
            this.Controls.Add(this.cbxProducer);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblEntranceDate);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipmentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEquipmentEdit";
            this.Load += new System.EventHandler(this.frmEquipmentEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label lblEntranceDate;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxProducer;
        private System.Windows.Forms.DateTimePicker dtpEntranceDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}