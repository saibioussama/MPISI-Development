using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Export export = new Export(this);
            export.ShowDialog();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(this);
            form1.ShowDialog();
        }
    }
}
