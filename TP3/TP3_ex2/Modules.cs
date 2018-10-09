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
    public partial class Modules : Form
    {
        public Modules()
        {
            InitializeComponent();
            Options.onChangeSelectedOption += (i) =>
            {
                if (i == 1)
                {
                    checkBox1.Text = "Architectures client/serveur. ";
                    checkBox2.Text = "Administration des réseaux locaux .";
                    checkBox3.Text = "Les réseaux mobiles.";
                }
                else
                {
                    checkBox1.Text = "Infographie. ";
                    checkBox2.Text = "Développement d'applications Internet.";
                    checkBox3.Text = "Codage et standards multimédia.";
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            var s = 0;
            s = checkBox1.Checked ? ++s : s;
            s = checkBox2.Checked ? ++s : s;
            s = checkBox3.Checked ? ++s : s;
            if (s != 2)
            {
                MessageBox.Show("Seule la sélection de deux modules est permise !");
                return;
            }
            MessageBox.Show("valider :D ");
            //var options = Program.Forms[1] as Options;
            //MessageBox.Show(options.radioButton1.Text) ;
        }
    }
}
