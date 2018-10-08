using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Text = "Architectures client/serveur. ";
                checkBox2.Text = "Administration des réseaux locaux .";
                checkBox3.Text = "Les réseaux mobiles.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox1.Text = "Infographie. ";
                checkBox2.Text = "Développement d'applications Internet.";
                checkBox3.Text = "Codage et standards multimédia.";
            }
        }

        private void ValidBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NomTB.Text) || string.IsNullOrWhiteSpace(NomTB.Text))
            {
                MessageBox.Show("nom vide!");
                return;
            }
            if (string.IsNullOrEmpty(PrenomTB.Text) || string.IsNullOrWhiteSpace(PrenomTB.Text))
            {
                MessageBox.Show("Prenom vide!");
                return;
            }
            if (string.IsNullOrEmpty(AdresseTB.Text) || string.IsNullOrWhiteSpace(AdresseTB.Text))
            {
                MessageBox.Show("Adresse vide!");
                return;
            }
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
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
