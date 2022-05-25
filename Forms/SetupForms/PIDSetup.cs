using System;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HEMA_Program.Forms.SetupForms
{
    public partial class PIDSetup : Form
    {
        Excel.Application excel;
        Excel.Workbook wb;
        Excel.Worksheet ws;
        Excel.Range range;

        string fName;

        DataTable dt;
        DataRow drw;

        int rowCount;
        int colCount;

        public PIDSetup()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            dt = new DataTable();   //container for our excel data
            DialogResult result = ofd.ShowDialog();  // Show the dialog.
            if (result == DialogResult.OK)   // Check if Result == "OK".
            {
                fName = ofd.FileName; //get the filename with the location of the file
                try

                {
                    ////Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                    excel = new Excel.Application();

                    wb = excel.Workbooks.Open(fName);

                    ws = wb.Sheets[1];

                    range = ws.UsedRange;


                    int rowCount = range.Rows.Count;  //get row count of excel data

                    int colCount = range.Columns.Count; // get column count of excel data

                    //Get the first Column of excel file which is the Column Name                  

                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            dt.Columns.Add(range.Cells[i, j].Value2.ToString());
                        }
                        break;
                    }
                    //Get Row Data of Excel              
                    int rowCounter;  //This variable is used for row index number
                    for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                    {
                        drw = dt.NewRow();  //assign new row to DataTable
                        rowCounter = 0;
                        for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                        {
                            //check if cell is empty
                            if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            {
                                drw[rowCounter] = range.Cells[i, j].Value2.ToString();
                            }
                            else
                            {
                                drw[i] = "";
                            }

                            rowCounter++;
                        }
                        dt.Rows.Add(drw); //add row to DataTable
                    }

                    dgvTable.DataSource = dt; //assign DataTable as Datasource for DataGridview

                    //Close and Clean excel process
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    wb.Close();
                    excel.Quit();

                    Marshal.ReleaseComObject(excel);
                    Marshal.ReleaseComObject(wb);
                    Marshal.ReleaseComObject(ws);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvTable.SelectAll();
            DataObject copyData = dgvTable.GetClipboardContent();
            if (copyData != null)
            {
                Clipboard.SetDataObject(copyData);
            }

            excel = new Excel.Application();
            excel.Visible = true;
            object missing = Missing.Value;
            wb = excel.Workbooks.Add(missing);
            ws = (Excel.Worksheet)excel.Worksheets.get_Item(1);
            range = (Excel.Range)ws.Cells[1, 1];
            range.Select();
            ws.PasteSpecial(range, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //wb.Close();
            //excel.Quit();

            Marshal.ReleaseComObject(excel);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(ws);
        }

        private void dgvTable_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewColumn col in dgvTable.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnSAll_Click(object sender, EventArgs e)
        {
            dgvTable.SelectAll();
        }

        private void btnSNone_Click(object sender, EventArgs e)
        {
            dgvTable.ClearSelection();
        }

    }
}
