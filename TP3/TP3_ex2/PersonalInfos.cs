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
    public partial class PersonalInfos : Form
    {
        

        public PersonalInfos()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
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

            this.Hide();
            Program.Forms[1].Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
