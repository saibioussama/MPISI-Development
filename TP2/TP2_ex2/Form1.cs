using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToInt32(int2TB.Text);
                var b = Convert.ToInt32(int1TB.Text);
                ResultTB.Text = $"Result : {a + b}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("d'erreur de saisie d'une valeur non numérique");
            }
        }
    }
}
