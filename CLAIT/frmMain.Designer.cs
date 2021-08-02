
namespace CLAIT
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEquipments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.dgvEquipmentsCabinets = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxECFilter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentFromEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentFromCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxECClear = new System.Windows.Forms.PictureBox();
            this.pbxECDelete = new System.Windows.Forms.PictureBox();
            this.pbxECEdit = new System.Windows.Forms.PictureBox();
            this.pbxECAdd = new System.Windows.Forms.PictureBox();
            this.pbxClear = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentCabinetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entranceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentsCabinets)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCabinetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipments
            // 
            this.dgvEquipments.AllowUserToAddRows = false;
            this.dgvEquipments.AllowUserToDeleteRows = false;
            this.dgvEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipments.AutoGenerateColumns = false;
            this.dgvEquipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.producerIdDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.entranceDateDataGridViewTextBoxColumn});
            this.dgvEquipments.DataSource = this.equipmentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipments.Location = new System.Drawing.Point(12, 104);
            this.dgvEquipments.Name = "dgvEquipments";
            this.dgvEquipments.ReadOnly = true;
            this.dgvEquipments.RowHeadersVisible = false;
            this.dgvEquipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipments.Size = new System.Drawing.Size(984, 235);
            this.dgvEquipments.TabIndex = 4;
            this.dgvEquipments.SelectionChanged += new System.EventHandler(this.dgvEquipments_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pbxClear);
            this.panel1.Controls.Add(this.tbxFilter);
            this.panel1.Controls.Add(this.pbxDelete);
            this.panel1.Controls.Add(this.pbxEdit);
            this.panel1.Controls.Add(this.pbxAdd);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 57);
            this.panel1.TabIndex = 5;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(691, 19);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(226, 20);
            this.tbxFilter.TabIndex = 1;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // dgvEquipmentsCabinets
            // 
            this.dgvEquipmentsCabinets.AllowUserToAddRows = false;
            this.dgvEquipmentsCabinets.AllowUserToDeleteRows = false;
            this.dgvEquipmentsCabinets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipmentsCabinets.AutoGenerateColumns = false;
            this.dgvEquipmentsCabinets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipmentsCabinets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEquipmentsCabinets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipmentsCabinets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.equipmentIdDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.cabinetIdDataGridViewTextBoxColumn,
            this.cabinetDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.installationDateDataGridViewTextBoxColumn});
            this.dgvEquipmentsCabinets.DataSource = this.equipmentCabinetBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipmentsCabinets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipmentsCabinets.Location = new System.Drawing.Point(15, 408);
            this.dgvEquipmentsCabinets.Name = "dgvEquipmentsCabinets";
            this.dgvEquipmentsCabinets.ReadOnly = true;
            this.dgvEquipmentsCabinets.RowHeadersVisible = false;
            this.dgvEquipmentsCabinets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipmentsCabinets.Size = new System.Drawing.Size(984, 241);
            this.dgvEquipmentsCabinets.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pbxECClear);
            this.panel2.Controls.Add(this.tbxECFilter);
            this.panel2.Controls.Add(this.pbxECDelete);
            this.panel2.Controls.Add(this.pbxECEdit);
            this.panel2.Controls.Add(this.pbxECAdd);
            this.panel2.Location = new System.Drawing.Point(12, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 57);
            this.panel2.TabIndex = 5;
            // 
            // tbxECFilter
            // 
            this.tbxECFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxECFilter.Location = new System.Drawing.Point(691, 19);
            this.tbxECFilter.Name = "tbxECFilter";
            this.tbxECFilter.Size = new System.Drawing.Size(226, 20);
            this.tbxECFilter.TabIndex = 1;
            this.tbxECFilter.TextChanged += new System.EventHandler(this.tbxECFilter_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoryesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // directoryesToolStripMenuItem
            // 
            this.directoryesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.directoryToolStripMenuItem});
            this.directoryesToolStripMenuItem.Name = "directoryesToolStripMenuItem";
            this.directoryesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.directoryesToolStripMenuItem.Text = "Справочники";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.employeesToolStripMenuItem.Text = "Сотрудники";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionToolStripMenuItem,
            this.cabinetToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.producereToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.directoryToolStripMenuItem.Text = "Дополнительно";
            // 
            // cabinetToolStripMenuItem
            // 
            this.cabinetToolStripMenuItem.Name = "cabinetToolStripMenuItem";
            this.cabinetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cabinetToolStripMenuItem.Text = "Помещения";
            this.cabinetToolStripMenuItem.Click += new System.EventHandler(this.cabinetToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.categoryToolStripMenuItem.Text = "Типы оборудования";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.positionToolStripMenuItem.Text = "Должности";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // producereToolStripMenuItem
            // 
            this.producereToolStripMenuItem.Name = "producereToolStripMenuItem";
            this.producereToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.producereToolStripMenuItem.Text = "Производители";
            this.producereToolStripMenuItem.Click += new System.EventHandler(this.producereToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipmentFromEmployeeToolStripMenuItem,
            this.equipmentFromCabinetToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // equipmentFromEmployeeToolStripMenuItem
            // 
            this.equipmentFromEmployeeToolStripMenuItem.Name = "equipmentFromEmployeeToolStripMenuItem";
            this.equipmentFromEmployeeToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equipmentFromEmployeeToolStripMenuItem.Text = "Оборудование у сотрудника";
            this.equipmentFromEmployeeToolStripMenuItem.Click += new System.EventHandler(this.equipmentFromEmployeeToolStripMenuItem_Click);
            // 
            // equipmentFromCabinetToolStripMenuItem
            // 
            this.equipmentFromCabinetToolStripMenuItem.Name = "equipmentFromCabinetToolStripMenuItem";
            this.equipmentFromCabinetToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.equipmentFromCabinetToolStripMenuItem.Text = "Оборудование в помещении";
            this.equipmentFromCabinetToolStripMenuItem.Click += new System.EventHandler(this.equipmentFromCabinetToolStripMenuItem_Click);
            // 
            // aboutMenuToolStripMenuItem
            // 
            this.aboutMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.aboutMenuToolStripMenuItem.Name = "aboutMenuToolStripMenuItem";
            this.aboutMenuToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutMenuToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbxECClear
            // 
            this.pbxECClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxECClear.Image = global::CLAIT.Properties.Resources.icons8_Clear_Search_48px;
            this.pbxECClear.Location = new System.Drawing.Point(923, 3);
            this.pbxECClear.Name = "pbxECClear";
            this.pbxECClear.Size = new System.Drawing.Size(51, 51);
            this.pbxECClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxECClear.TabIndex = 2;
            this.pbxECClear.TabStop = false;
            this.pbxECClear.Click += new System.EventHandler(this.pbxECClear_Click);
            this.pbxECClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxECClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxECDelete
            // 
            this.pbxECDelete.Image = global::CLAIT.Properties.Resources.icons8_delete_48px;
            this.pbxECDelete.Location = new System.Drawing.Point(117, 3);
            this.pbxECDelete.Name = "pbxECDelete";
            this.pbxECDelete.Size = new System.Drawing.Size(51, 51);
            this.pbxECDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxECDelete.TabIndex = 0;
            this.pbxECDelete.TabStop = false;
            this.pbxECDelete.Click += new System.EventHandler(this.pbxECDelete_Click);
            this.pbxECDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxECDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxECEdit
            // 
            this.pbxECEdit.Image = global::CLAIT.Properties.Resources.icons8_edit_48px;
            this.pbxECEdit.Location = new System.Drawing.Point(60, 3);
            this.pbxECEdit.Name = "pbxECEdit";
            this.pbxECEdit.Size = new System.Drawing.Size(51, 51);
            this.pbxECEdit.TabIndex = 0;
            this.pbxECEdit.TabStop = false;
            this.pbxECEdit.Click += new System.EventHandler(this.pbxECEdit_Click);
            this.pbxECEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxECEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxECAdd
            // 
            this.pbxECAdd.Image = global::CLAIT.Properties.Resources.icons8_add_48px_1;
            this.pbxECAdd.Location = new System.Drawing.Point(3, 3);
            this.pbxECAdd.Name = "pbxECAdd";
            this.pbxECAdd.Size = new System.Drawing.Size(51, 51);
            this.pbxECAdd.TabIndex = 0;
            this.pbxECAdd.TabStop = false;
            this.pbxECAdd.Click += new System.EventHandler(this.pbxECAdd_Click);
            this.pbxECAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxECAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxClear
            // 
            this.pbxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClear.Image = global::CLAIT.Properties.Resources.icons8_Clear_Search_48px;
            this.pbxClear.Location = new System.Drawing.Point(923, 3);
            this.pbxClear.Name = "pbxClear";
            this.pbxClear.Size = new System.Drawing.Size(51, 51);
            this.pbxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClear.TabIndex = 2;
            this.pbxClear.TabStop = false;
            this.pbxClear.Click += new System.EventHandler(this.pbxClear_Click);
            this.pbxClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxDelete
            // 
            this.pbxDelete.Image = global::CLAIT.Properties.Resources.icons8_delete_48px;
            this.pbxDelete.Location = new System.Drawing.Point(117, 3);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(51, 51);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDelete.TabIndex = 0;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            this.pbxDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxEdit
            // 
            this.pbxEdit.Image = global::CLAIT.Properties.Resources.icons8_edit_48px;
            this.pbxEdit.Location = new System.Drawing.Point(60, 3);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(51, 51);
            this.pbxEdit.TabIndex = 0;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            this.pbxEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = global::CLAIT.Properties.Resources.icons8_add_48px_1;
            this.pbxAdd.Location = new System.Drawing.Point(3, 3);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(51, 51);
            this.pbxAdd.TabIndex = 0;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            this.pbxAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseDown);
            this.pbxAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseUp);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // equipmentIdDataGridViewTextBoxColumn
            // 
            this.equipmentIdDataGridViewTextBoxColumn.DataPropertyName = "EquipmentId";
            this.equipmentIdDataGridViewTextBoxColumn.HeaderText = "EquipmentId";
            this.equipmentIdDataGridViewTextBoxColumn.Name = "equipmentIdDataGridViewTextBoxColumn";
            this.equipmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            this.equipmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // cabinetIdDataGridViewTextBoxColumn
            // 
            this.cabinetIdDataGridViewTextBoxColumn.DataPropertyName = "CabinetId";
            this.cabinetIdDataGridViewTextBoxColumn.HeaderText = "CabinetId";
            this.cabinetIdDataGridViewTextBoxColumn.Name = "cabinetIdDataGridViewTextBoxColumn";
            this.cabinetIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cabinetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cabinetDataGridViewTextBoxColumn
            // 
            this.cabinetDataGridViewTextBoxColumn.DataPropertyName = "Cabinet";
            this.cabinetDataGridViewTextBoxColumn.HeaderText = "Помещение";
            this.cabinetDataGridViewTextBoxColumn.Name = "cabinetDataGridViewTextBoxColumn";
            this.cabinetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Ответственный сотрудник";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installationDateDataGridViewTextBoxColumn
            // 
            this.installationDateDataGridViewTextBoxColumn.DataPropertyName = "InstallationDate";
            this.installationDateDataGridViewTextBoxColumn.HeaderText = "Дата установки";
            this.installationDateDataGridViewTextBoxColumn.Name = "installationDateDataGridViewTextBoxColumn";
            this.installationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipmentCabinetBindingSource
            // 
            this.equipmentCabinetBindingSource.DataSource = typeof(CLAIT.Model.EquipmentCabinet);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Инв. номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producerIdDataGridViewTextBoxColumn
            // 
            this.producerIdDataGridViewTextBoxColumn.DataPropertyName = "ProducerId";
            this.producerIdDataGridViewTextBoxColumn.HeaderText = "ProducerId";
            this.producerIdDataGridViewTextBoxColumn.Name = "producerIdDataGridViewTextBoxColumn";
            this.producerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.producerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            this.producerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entranceDateDataGridViewTextBoxColumn
            // 
            this.entranceDateDataGridViewTextBoxColumn.DataPropertyName = "EntranceDate";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            this.entranceDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.entranceDateDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.entranceDateDataGridViewTextBoxColumn.Name = "entranceDateDataGridViewTextBoxColumn";
            this.entranceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(CLAIT.Model.Equipment);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEquipmentsCabinets);
            this.Controls.Add(this.dgvEquipments);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет оборудования АО \"Алюминий Казахстана\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentsCabinets)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxECAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentCabinetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEquipments;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entranceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxClear;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.DataGridView dgvEquipmentsCabinets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxECClear;
        private System.Windows.Forms.TextBox tbxECFilter;
        private System.Windows.Forms.PictureBox pbxECDelete;
        private System.Windows.Forms.PictureBox pbxECEdit;
        private System.Windows.Forms.PictureBox pbxECAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emloyeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource equipmentCabinetBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentFromEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentFromCabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

