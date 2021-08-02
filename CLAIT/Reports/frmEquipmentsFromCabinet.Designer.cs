
namespace CLAIT.Reports
{
    partial class frmEquipmentsFromCabinet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCabinet = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pbxExcel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.Location = new System.Drawing.Point(12, 75);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(984, 574);
            this.dgvResult.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbxCabinet);
            this.panel1.Controls.Add(this.lblEmployee);
            this.panel1.Controls.Add(this.pbxExcel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 57);
            this.panel1.TabIndex = 8;
            // 
            // cbxCabinet
            // 
            this.cbxCabinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCabinet.FormattingEnabled = true;
            this.cbxCabinet.Location = new System.Drawing.Point(61, 16);
            this.cbxCabinet.Name = "cbxCabinet";
            this.cbxCabinet.Size = new System.Drawing.Size(377, 21);
            this.cbxCabinet.TabIndex = 4;
            this.cbxCabinet.SelectedValueChanged += new System.EventHandler(this.cbxCabinet_SelectedValueChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(3, 19);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(52, 13);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Кабинет:";
            // 
            // pbxExcel
            // 
            this.pbxExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxExcel.Image = global::CLAIT.Properties.Resources.icons8_microsoft_excel_2019_48px;
            this.pbxExcel.Location = new System.Drawing.Point(923, 3);
            this.pbxExcel.Name = "pbxExcel";
            this.pbxExcel.Size = new System.Drawing.Size(51, 51);
            this.pbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExcel.TabIndex = 2;
            this.pbxExcel.TabStop = false;
            this.pbxExcel.Click += new System.EventHandler(this.pbxExcel_Click);
            this.pbxExcel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxExcel_MouseDown);
            this.pbxExcel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxExcel_MouseUp);
            // 
            // frmEquipmentsFromCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.panel1);
            this.Name = "frmEquipmentsFromCabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оборудование в кабинете";
            this.Load += new System.EventHandler(this.frmEquipmentsFromCabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxCabinet;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox pbxExcel;
    }
}