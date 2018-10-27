using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart.NET
{
    public partial class Home : Form
    {

        List<int> XData = new List<int>();

        List<int> YData = new List<int>();

        public Home()
        {
            InitializeComponent();
            dataGridView1.DataSource = MapData(XData, YData);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        List<Tuple<int, int>> MapData(List<int> XData, List<int> YData)
        {
            List<Tuple<int, int>> Data = new List<Tuple<int, int>>();
            for (int i = 0; i < XData.Count; i++)
            {
                Data.Add(new Tuple<int, int>(XData[i], YData[i]));
            }
            return Data;
        }

        private void GeneratedataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var size = Convert.ToInt16(NumberTextBox.Text);
                GenerateFakeData(size);
                var Data = MapData(XData, YData);
                dataGridView1.DataSource = Data;
                var chart = new Chart(Data);
                chart.Chart_AxeBorderColor = Color.Black;
                chart.Chart_AxeFontSize = 10;
                chart.Chart_AxeForegorund = Color.Black; 
                chart.Chart_RectBackground = Color.DeepSkyBlue;
                chart.Chart_RectBorderColor = Color.Azure;
                CanvasPanel.Controls.Clear();
                CanvasPanel.Controls.Add(chart);
            }
            catch
            {
                MessageBox.Show("size invalid");
            }
        }

        private void GenerateFakeData(int x)
        {
            XData.Clear();
            YData.Clear();
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                YData.Add(rand.Next(1, x));
                XData.Add(i + 1);
            }
        }
    }
}
