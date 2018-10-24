using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        main main;
        public Form1()
        {
            InitializeComponent(); 
        }

        public Form1(main _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void GetDataBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ObjectRepo.Get(TBDatabaseName.Text, TBTableName.Text);
        }

        private void comboBoxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDataType.SelectedIndex)
            {
                case 0:
                    panel1.Visible = true;
                    panel2.Visible = false;
                    GetDataBtn.Visible = true;
                    GetCsvDataBtn.Visible = false;
                    GetExcelData.Visible = false;
                    break;
                case 2:
                    panel1.Visible = false;
                    panel2.Visible = true;
                    GetDataBtn.Visible = false; 
                    GetCsvDataBtn.Visible = true;
                    GetExcelData.Visible = false;
                    break;
                case 1:
                    panel1.Visible = false;
                    panel2.Visible = true;
                    GetDataBtn.Visible = false;
                    GetCsvDataBtn.Visible = false;
                    GetExcelData.Visible = true;
                    break;
                default: break;
            }
        }

        private void FileOpenBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    string file = openFileDialog1.FileName;
            //}
        }

        private void ShowCsvData(string file)
        {
            try
            {
                string[] Lines = File.ReadAllLines(file);
                string[] ColumnsName = Lines[0].Split(new char[] { ',' });
                int NbCols = ColumnsName.Count();
                DataTable dt = new DataTable();
                DataRow row;
                foreach (var column in ColumnsName)
                    dt.Columns.Add(column.ToLower(), typeof(string));

                for (int i = 1; i < Lines.GetLength(0); i++)
                {
                    ColumnsName = Lines[i].Split(new char[] { ',' });
                    row = dt.NewRow();
                    for (int f = 0; f < NbCols; f++)
                        try
                        {
                            row[f] = ColumnsName[f];
                        }
                        catch
                        {
                        }
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;
            }
            catch (IOException)
            {

            }
        }

        private void GetExcelData_Click(object sender, EventArgs e)
        {
            //String name = "Taches";
            //String constr = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={openFileDialog1.FileName};Extended Properties='Excel 8.0;HDR=YES;';";

            //OleDbConnection con = new OleDbConnection(constr);
            //OleDbCommand oconn = new OleDbCommand($"Select * From [{name}$]", con);
            //con.Open();

            //OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridView1.DataSource = data;
              
            var ExelFileConnectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", openFileDialog1.FileName);
            using (OleDbConnection conn = new OleDbConnection(ExelFileConnectionString))
            {
                conn.Open();
                DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                var SheetsList = new List<string>();

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    SheetsList.Add(row["TABLE_NAME"].ToString());

                }

                using (OleDbConnection cnn = new OleDbConnection(ExelFileConnectionString))
                {
                    cnn.Open();
                    OleDbDataAdapter sda = new OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", SheetsList[0]), cnn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    dataGridView1.DataSource = data;
                    cnn.Close();
                }
            }

        }

        private void GetCsvDataBtn_Click(object sender, EventArgs e)
        {
            ShowCsvData(openFileDialog1.FileName);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}
