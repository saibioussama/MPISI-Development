using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_ex3
{
    public partial class Form1 : Form
    {
        Add add;
        public Form1()
        {
            InitializeComponent();
            add = new Add(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add.ShowDialog();
        }
    }
}
