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
    public partial class Add : Form
    {
        Form1 form;
        public Add()
        {
            InitializeComponent();
        }

        public Add(Form1 _form)
        {
            InitializeComponent();
            form = _form;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = Convert.ToInt32(Entier1TB.Text);
                b = Convert.ToInt32(Entier2TB.Text);
            }
            catch
            {
                MessageBox.Show("input invalid !");
                return;
            }

            if (form.radioButton1.Checked)
                form.ResultLable.Text = $"{a} + {b} = {a + b}";
            else
                form.ResultLable.Text = $"{a} - {b} = {a - b}";
        }
    }
}
