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

namespace CLAIT.Reports
{
    public partial class frmEquipmentsFromCabinet : Form
    {
        SortableBindingList<ViewResult> sbl;
        class ViewResult
        {
            public Employee Employee { get; set; }
            public string Id { get; set; }
            public Category Category { get; set; }
            public Producer Producer { get; set; }
            public string Model { get; set; }
            public DateTime InstallationDate { get; set; }
        }
        public frmEquipmentsFromCabinet()
        {
            this.Icon = frmMain.MyIcon;
            InitializeComponent();
        }

        private async void frmEquipmentsFromCabinet_Load(object sender, EventArgs e)
        {
            if (frmMain.Db.Cabinets.Count() < 1)
            {
                MessageBox.Show("Добавьте кабинет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            cbxCabinet.DataSource = (await frmMain.Db.Cabinets.ToListAsync()).OrderBy(x => x.Name).ToList();
        }

        private void pbxExcel_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top += 2;
            ((PictureBox)sender).Left += 2;
        }

        private void pbxExcel_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Top -= 2;
            ((PictureBox)sender).Left -= 2;
        }

        private async void cbxCabinet_SelectedValueChanged(object sender, EventArgs e)
        {
            var cabinet = (Cabinet)cbxCabinet.SelectedItem;
            var equipmentsCabinet = await frmMain.Db.EquipmentsCabinets.ToListAsync();
            var result = equipmentsCabinet
                .Where(x => x.InstallationDate == (equipmentsCabinet
                    .Where(y => y.EquipmentId == x.EquipmentId)
                    .Max(q => q.InstallationDate)))
                .Where(x => x.Cabinet == cabinet);
            var resultView = result.Select(x => new ViewResult()
            {
                Employee = x.Employee,
                Id = x.Equipment.Id,
                Category = x.Equipment.Category,
                Producer = x.Equipment.Producer,
                Model = x.Equipment.Model,
                InstallationDate = x.InstallationDate
            });
            sbl = new SortableBindingList<ViewResult>(resultView.ToList());
            dgvResult.DataSource = sbl;

            dgvResult.Columns[0].HeaderText = "Сотрудник";
            dgvResult.Columns[1].HeaderText = "Инв. номер";
            dgvResult.Columns[2].HeaderText = "Категория";
            dgvResult.Columns[3].HeaderText = "Производитель";
            dgvResult.Columns[4].HeaderText = "Модель";
            dgvResult.Columns[5].HeaderText = "Дата установки";
        }

        private void pbxExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Open(Environment.CurrentDirectory + @"\Templates\EquipmentsFromCabinet.xlt");
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Cells[2, 1] = $"Кабинет: {((Cabinet)cbxCabinet.SelectedItem).Name}";

            var i = 3;
            foreach (var item in sbl.ToList())
            {
                i++;
                workSheet.Cells[i, 1] = i - 3;
                workSheet.Cells[i, 2] = (item.Employee != null) ? item.Employee.ToString() : "";
                workSheet.Cells[i, 3] = item.Id;
                workSheet.Cells[i, 4] = (item.Category != null) ? item.Category.ToString() : "";
                workSheet.Cells[i, 5] = (item.Producer != null) ? item.Producer.ToString() : "";
                workSheet.Cells[i, 6] = item.Model;
                workSheet.Cells[i, 7] = item.InstallationDate.ToShortDateString();
            }

            Microsoft.Office.Interop.Excel.Range rng = workSheet.Range[workSheet.Cells[3, 1], workSheet.Cells[i, 7]];
            rng.Columns.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = rng.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelApp.Visible = true;
            excelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            excelApp.ActiveWindow.Activate();
        }
    }
}
