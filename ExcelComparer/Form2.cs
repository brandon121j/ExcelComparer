using Aspose.Cells;
using ClosedXML.Excel;
using ExcelDataReader;
using IronXL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelComparer
{
    public partial class Form2 : Form
    {
        public string ExcelSheet1 { get; set; }
        public string ExcelSheet2 { get; set; }
        public string FormTitle { get; set; }
        private static DataTable ExcelNewItems { get; set; }
        private static DataTable ExcelSameItems { get; set; }
        private static DataTable ExcelChangedItems { get; set; }
        private static bool ColorBlindMode { get; set; }
        private Color Red { get; set; } = Color.FromArgb(255, 0, 0);
        private Color Green { get; set; } = Color.FromArgb(19, 174, 75);
        private Color Yellow { get; set; } = Color.FromArgb(247, 222, 58);

        public Form2()
        {
            InitializeComponent();

            this.Text = FormTitle;
            changedItemLabel.BackColor = Red;
            newItemLabel.BackColor = Green;
            sameItemLabel.BackColor = Yellow;

            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }




        // Converts Excel Sheet to DataTable
        private DataTable ExcelFileReader(string path)
        {
            DataGridView datagrid = ExcelSheet1.Equals(path) ? excelSheet1DG : excelSheet2DG;


            FileStream fstream = new FileStream(path, FileMode.Open);

            Workbook workbook = new Workbook(fstream);

            DataTable dataTable = workbook.Worksheets[0].Cells.ExportDataTable(0, 0, workbook.Worksheets[0].Cells.MaxDataRow + 1, workbook.Worksheets[0].Cells.MaxDataColumn + 1, new ExportTableOptions() { ExportColumnName = true });

            datagrid.DataSource = dataTable;

            fstream.Close();

            return dataTable;
        }


        private void Comparer(DataTable excel1, DataTable excel2)
        {
            try
            {
                excelSheet1DG.DataSource = excel1;
                excelSheet2DG.DataSource = excel2;

                splitContainer1.Visible = true;
                splitContainer2.Visible = true;

                HightLighter();

                var (changedCount, sameCount, newCount) = DataGridIterator();

                excelSameCounter.Text = $"Same Items: {sameCount}";
                excelSameCount.Text = $"Changed Items: {changedCount}";
                excelNewCounter.Text = $"New Items: {newCount}";
                excelTotalCounter.Text = $"Total Items: {sameCount + changedCount + newCount}";

                Cursor.Current = Cursors.Default;

            }
            finally
            {

                Application.UseWaitCursor = false;
            }

        }

        // Save File Dialog Prompt
        private string SaveFile(string filter, string ext)
        {

            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Title = "Save File",
                DefaultExt = ext,
                Filter = filter,
                InitialDirectory = @"C:\\documents",
            };

            saveFile.ShowDialog();

            return saveFile.FileName;
        }

        private void toolStripCopyButton_Click(object sender, EventArgs e)
        {
            var newline = System.Environment.NewLine;
            var tab = "\t";
            var clipboard_string = new StringBuilder();

            foreach (DataGridViewRow row in excelSheet1DG.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == (row.Cells.Count - 1))
                        clipboard_string.Append(row.Cells[i].Value + newline);
                    else
                        clipboard_string.Append(row.Cells[i].Value + tab);
                }
            }

            Clipboard.SetText(clipboard_string.ToString());

            MessageBox.Show("Data copied to clipboard!", "Success!");
        }

        // Popup displayed when closing application
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                var formToShow = Application.OpenForms.Cast<Form>()
                    .FirstOrDefault(c => c is Form1);


                if (formToShow != null)
                {
                    formToShow.WindowState = FormWindowState.Normal;
                }
                else
                {
                    Application.Exit();
                }

            }

            this.Dispose();

        }

        // Function responsible for highlighting cells
        private void HightLighter()
        {

            Dictionary<int, int> matches = new Dictionary<int, int>();


            for (int i = 0; i < excelSheet1DG.Rows.Count; i++)
            {
                try
                {
                    int rowIndex = i;
                    string value = excelSheet1DG.Rows[i].Cells[0].Value.ToString();
                    int columnIndex = excelSheet1DG.Rows[i].Cells[0].ColumnIndex;
                    string columnName = excelSheet1DG.Columns[columnIndex].Name;

                    DataGridViewRow row = excelSheet2DG.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[columnName].Value.ToString().Equals(value))
                    .First();

                    matches.Add(i, row.Index);

                }
                catch
                {
                    excelSheet1DG.Rows[i].DefaultCellStyle.BackColor = Green;
                }
            }



            for (int k = 0; k < excelSheet2DG.Rows.Count; k++)
            {
                try
                {
                    int rowIndex = k;
                    string value = excelSheet2DG.Rows[k].Cells[0].Value.ToString();
                    int columnIndex = excelSheet2DG.Rows[k].Cells[0].ColumnIndex;
                    string columnName = excelSheet2DG.Columns[columnIndex].Name;

                    DataGridViewRow row = excelSheet1DG.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[columnName].Value.ToString().Equals(value))
                    .First();


                }
                catch
                {
                    excelSheet2DG.Rows[k].DefaultCellStyle.BackColor = Green;
                }
            }

            foreach (KeyValuePair<int, int> item in matches)
            {

                for (int j = 0; j < excelSheet1DG.ColumnCount; j++)
                {


                    if (excelSheet1DG.Rows[item.Key].Cells[j].Value.ToString().Equals(excelSheet2DG.Rows[item.Value].Cells[j].Value.ToString()))
                    {
                        excelSheet1DG.Rows[item.Key].DefaultCellStyle.BackColor = Yellow;
                        excelSheet2DG.Rows[item.Value].DefaultCellStyle.BackColor = Yellow;
                    }
                    else
                    {
                        excelSheet1DG.Rows[item.Key].DefaultCellStyle.BackColor = Red;
                        excelSheet2DG.Rows[item.Value].DefaultCellStyle.BackColor = Red;
                        break;
                    }

                }


            }

            changedItemLabel.BackColor = Red;
            newItemLabel.BackColor = Green;
            sameItemLabel.BackColor = Yellow;


            excelSheet2DG.Refresh();
            excelSheet1DG.Refresh();
        }



        private void MatchingCellHighlighter(DataGridView dg)
        {
            try
            {
                DataGridView oppositeDG = dg == excelSheet1DG ? excelSheet2DG : excelSheet1DG;

                int rowIndex = -1;
                string value = dg.SelectedCells[0].Value.ToString();
                int columnIndex = dg.SelectedCells[0].ColumnIndex;
                string columnName = dg.Columns[columnIndex].Name;

                DataGridViewRow row = oppositeDG.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[columnName].Value.ToString().Equals(value))
                    .First();

                rowIndex = row.Index;

                oppositeDG.CurrentCell = oppositeDG.Rows[rowIndex].Cells[0];
            }
            catch { }
        }

        private void RowCopyToClipBoard(DataGridView dg)
        {
            if (dg.SelectedRows.Count > 0)
            {
                StringBuilder ClipboardBuillder = new StringBuilder();

                foreach (DataGridViewRow Row in dg.SelectedRows)
                {
                    foreach (DataGridViewColumn Column in dg.Columns)
                    {
                        ClipboardBuillder.Append(Row.Cells[Column.Index].FormattedValue.ToString()).Append(" ");
                    }
                    ClipboardBuillder.AppendLine();
                }

                Clipboard.SetText(ClipboardBuillder.ToString());
            }
        }

        // Populates item count and populates datatables for xlsx export
        private (int, int, int) DataGridIterator()
        {
            int changedCounter = 0;
            int sameCounter = 0;
            int newCounter = 0;

            DataTable changed = new DataTable();
            DataTable same = new DataTable();
            DataTable addition = new DataTable();

            foreach (DataGridViewColumn column in excelSheet1DG.Columns)
            {
                changed.Columns.Add(column.HeaderText, typeof(string));
                addition.Columns.Add(column.HeaderText, typeof(string));
                same.Columns.Add(column.HeaderText, typeof(string));
            }

            DataRow datarow = null;

            foreach (DataGridViewRow row in excelSheet1DG.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Red)
                {
                    datarow = ((DataRowView)row.DataBoundItem).Row;
                    changed.ImportRow(datarow);
                    changedCounter++;
                }
                else if (row.DefaultCellStyle.BackColor == Yellow)
                {
                    datarow = ((DataRowView)row.DataBoundItem).Row;
                    same.ImportRow(datarow);
                    sameCounter++;
                }
                else
                {
                    datarow = ((DataRowView)row.DataBoundItem).Row;
                    addition.ImportRow(datarow);
                    newCounter++;
                }
            }

            ExcelChangedItems = changed;
            ExcelNewItems = addition;
            ExcelSameItems = same;

            return (changedCounter, sameCounter, newCounter);
        }

        // Exports to .xlsx
        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook();

                wb.Worksheets.Add(ExcelNewItems, "New Items");

                wb.Worksheets.Add(ExcelChangedItems, "Changed Items");

                wb.Worksheets.Add(ExcelSameItems, "Same Items");

                wb.SaveAs(SaveFile("Excel Files| *.xlsx; *.xlsm", ".xlsx"));

                MessageBox.Show("Excel file saved!", "Success!");
            }
            catch
            {
                MessageBox.Show("An error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles clicking the "New" button
        private void toolStripNewButton_Click_1(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is Form1);

            if (formToShow != null)
            {
                formToShow.WindowState = FormWindowState.Normal;
                //Application.OpenForms["Form2"].Dispose();
            }
        }

        private void colorblindModeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorBlindMode = !ColorBlindMode;
            Green = ColorBlindMode ? Color.FromArgb(155, 191, 133) : Color.FromArgb(19, 174, 75);
            Red = ColorBlindMode ? Color.FromArgb(202, 0, 32) : Color.FromArgb(255, 0, 0);
            Yellow = ColorBlindMode ? Color.FromArgb(244, 165, 130) : Color.FromArgb(247, 222, 58);
            colorblindModeOffToolStripMenuItem.Text = ColorBlindMode ? "Colorblind Mode: On" : "Colorblind Mode: Off";
            HightLighter();

        }



        private void Form2_Shown(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            bgWorker.WorkerReportsProgress = true;
            bgWorker.RunWorkerAsync();
            //Application.DoEvents();
            var excelData1 = ExcelFileReader(ExcelSheet1);
            var excelData2 = ExcelFileReader(ExcelSheet2);
            Comparer(excelData1, excelData2);

        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var Counter = 1; Counter <= toolStripProgressBar1.Maximum; Counter++)
            {
                bgWorker.ReportProgress(Counter);
                System.Threading.Thread.Sleep(50);
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Value = 0;
        }

        private void excelSheet1DG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowCopyToClipBoard(excelSheet1DG);
        }

        private void excelSheet2DG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowCopyToClipBoard(excelSheet2DG);
        }

        private void excelSheet2DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MatchingCellHighlighter(excelSheet2DG);
        }

        private void excelSheet1DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MatchingCellHighlighter(excelSheet1DG);
        }

        private void excelSheet2DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            HightLighter();
        }

        private void excelSheet1DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            HightLighter();
        }

        private void excelSheet1DG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MatchingCellHighlighter(excelSheet1DG);
        }

        private void excelSheet2DG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MatchingCellHighlighter(excelSheet2DG);
        }
    }

}
