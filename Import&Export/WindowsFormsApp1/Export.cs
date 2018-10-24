using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Export : Form
    {

        main main;
        DataTable dt = new DataTable();

        public Export()
        {
            InitializeComponent();
        }

        public Export(main _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void Export_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));

            dt.Rows.Add(new object[] { 1, "Oussama", "saibi" });
            dt.Rows.Add(new object[] { 2, "Oussama", "saibi" });
            dt.Rows.Add(new object[] { 3, "Oussama", "saibi" });
            dt.Rows.Add(new object[] { 4, "Oussama", "saibi" });

            dataGridView1.DataSource = dt;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            switch (comboBoxDataType.SelectedIndex)
            {
                case 0: break;
                case 1:
                    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                    ExcelFile ef = new ExcelFile();
                    ExcelWorksheet ws = ef.Worksheets.Add("Sheet");
                    ws.Cells[0, 0].Value = "";

                    // Insert DataTable into an Excel worksheet.
                    ws.InsertDataTable(dt,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 2
                        });

                    ef.Save(@"D:\Sheet.xlsx");
                    MessageBox.Show("file saved successfully at 'D:\\Sheet.xlsx'");
                    break;
                case 2:
                    StringBuilder sb = new StringBuilder();

                    string[] columnNames = dt.Columns.Cast<DataColumn>().
                                                      Select(column => column.ColumnName).
                                                      ToArray();
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in dt.Rows)
                    {
                        string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                        ToArray();
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText("D:\\datatable.csv", sb.ToString());
                    MessageBox.Show("file saved successfully at 'D:\\datatable.csv'");

                    break;
                default: break;
            }

            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}
