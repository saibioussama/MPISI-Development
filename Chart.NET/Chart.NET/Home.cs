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

        List<int> XData = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
        };

        List<int> YData = new List<int>()
        {
            5,2,9,4,5,6,2,8,19,2,8,6,20,10,12,5,20,7,15,19
        };

        public Home()
        {
            InitializeComponent();
            dataGridView1.DataSource = MapData(XData, YData);
            MySplitContainer.Panel1.Controls.Add(new Form1(XData,YData));
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
    }
}
