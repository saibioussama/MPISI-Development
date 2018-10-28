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
        private int MinX = 0;
        private int MaxX = 0;
        private int MinY = 0;
        private int MaxY = 0;
        List<KnownColor> colors;
        public Home()
        {
            InitializeComponent();
            dataGridView1.DataSource = MapData(XData, YData);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            colors = Enum.GetValues(typeof(KnownColor)).Cast<KnownColor>().ToList();
            BackgroundComboBox.DataSource = colors.Select(c => c.ToString()).ToList();
            BorderColorComboBox.DataSource = colors.Select(c => c.ToString()).ToList();
            BackgroundComboBox.SelectedIndex = 144;
            BorderColorComboBox.SelectedIndex = 127;
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
                dataGridView1.DataSource = MapData(XData, YData);
                var chart = new Chart(XData, YData)
                {
                    Chart_AxeBorderColor = Color.Black,
                    Chart_AxeFontSize = 10,
                    Chart_AxeForegorund = Color.Black,
                    Chart_RectBackground = Color.FromKnownColor(colors[BackgroundComboBox.SelectedIndex]),
                    Chart_RectBorderColor = Color.FromKnownColor(colors[BorderColorComboBox.SelectedIndex]),
                    Chart_AxeX = this.AxeXTextBoxs.Text,
                    Chart_AxeY = this.AxeYTextBox.Text,
                    Chart_IsBordered = BorderedCheckBox.Checked,
                };

                Canvas.Controls.Clear();
                Canvas.Controls.Add(chart);
            }
            catch
            {
                MessageBox.Show("size invalid");
            }
        }

        private void GenerateFakeData(int x)
        {
            try
            {
                MinX = Convert.ToInt32(MinXTextBox.Text);
                MinY = Convert.ToInt32(MinYTextBox.Text);
                MaxX = Convert.ToInt32(MaxXTextBox.Text);
                MaxY = Convert.ToInt32(MaxYTextBox.Text);

            }
            catch
            {
                MessageBox.Show("failed to convert data");
            }
            XData.Clear();
            YData.Clear();
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                YData.Add(rand.Next(MinY, MaxY));
                XData.Add(rand.Next(MinX, MaxX));
            }
        }
    }
}
