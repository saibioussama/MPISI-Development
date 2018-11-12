using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static ChartUserControls.Chart;

namespace Chart.NET
{
    public partial class Home : Form
    {

        List<int> XData = new List<int>();
        List<int> YData = new List<int>();
        List<Mode> modes = new List<Mode>();
        private int MinX = 0;
        private int MaxX = 0;
        private int MinY = 0;
        private int MaxY = 0;
        List<KnownColor> colors;
        public Home()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GenerateFakeData(Convert.ToInt32(NumberTextBox.Text));
            dataGridView1.DataSource = MapData(XData, YData);
            colors = Enum.GetValues(typeof(KnownColor)).Cast<KnownColor>().ToList();
            modes = Enum.GetValues(typeof(Mode)).Cast<Mode>().ToList();
            ModeComboBox.DataSource = modes.Select(m => m.ToString()).ToList();
            ModeComboBox.SelectedIndex = 0;
            BackgroundComboBox.DataSource = colors.Select(c => c.ToString()).ToList();
            BorderColorComboBox.DataSource = colors.Select(c => c.ToString()).ToList();
            BackgroundComboBox.SelectedIndex = colors.IndexOf(KnownColor.DeepSkyBlue);
            BorderColorComboBox.SelectedIndex = colors.IndexOf(KnownColor.DarkBlue);
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
            GenerateFakeData(Convert.ToInt32(NumberTextBox.Text));
            dataGridView1.DataSource = MapData(XData, YData);
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

        private void Home_ResizeEnd(object sender, EventArgs e)
        {
            //try
            //{
            //    var size = Convert.ToInt16(NumberTextBox.Text);
            //    GenerateFakeData(size);
            //    dataGridView1.DataSource = MapData(XData, YData);
            //    ChartUserControls.Chart chart = new ChartUserControls.Chart(XData, YData)
            //    {
            //        Chart_AxeBorderColor = Color.Black,
            //        Chart_AxeFontSize = 10,
            //        Chart_AxeForegorund = Color.Black,
            //        Chart_RectBackground = Color.FromKnownColor(colors[BackgroundComboBox.SelectedIndex]),
            //        Chart_RectBorderColor = Color.FromKnownColor(colors[BorderColorComboBox.SelectedIndex]),
            //        Chart_AxeX = this.AxeXTextBoxs.Text,
            //        Chart_AxeY = this.AxeYTextBox.Text,
            //        Chart_IsBordered = BorderedCheckBox.Checked,
            //    };

            //    Canvas.Controls.Clear();
            //    Canvas.Controls.Add(chart);
            //}
            //catch
            //{

            //}
        }

        private void PlotBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                var size = Convert.ToInt16(NumberTextBox.Text);
                dataGridView1.DataSource = MapData(XData, YData);

                MyChart.Chart_AxeBorderColor = Color.Black;
                MyChart.Chart_AxeFontSize = 10;
                MyChart.Chart_AxeForegorund = Color.Black;
                MyChart.Chart_RectBackground = Color.FromKnownColor(colors[BackgroundComboBox.SelectedIndex]);
                MyChart.Chart_RectBorderColor = Color.FromKnownColor(colors[BorderColorComboBox.SelectedIndex]);
                MyChart.Chart_AxeX = this.AxeXTextBoxs.Text;
                MyChart.Chart_AxeY = this.AxeYTextBox.Text;
                MyChart.Chart_IsBordered = BorderedCheckBox.Checked;
                MyChart.Chart_Mode = modes[ModeComboBox.SelectedIndex];
                MyChart.Chart_PointSize = Convert.ToInt32(PointSizeTextBox.Text);
                MyChart.Draw(XData, YData); 
            }
            catch
            {
                MessageBox.Show("size invalid");
            }
        }
    }
}
