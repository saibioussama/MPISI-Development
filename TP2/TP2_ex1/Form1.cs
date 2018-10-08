using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Click sur B1";
            Form f = new Form();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Click sur B2";
            MessageBox.Show("Boîte de dialogue ouverte");
        }

    }
}
