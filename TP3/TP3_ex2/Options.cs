using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_ex2
{
    public partial class Options : Form
    {
        public delegate void onChangeSelectedOptionDelegate(int i);
        public static event onChangeSelectedOptionDelegate onChangeSelectedOption;

        public Options()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                onChangeSelectedOption?.Invoke(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                onChangeSelectedOption?.Invoke(2);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("select option !");
                return;
            }
            this.Hide();
            Program.Forms[2].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[0].Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
