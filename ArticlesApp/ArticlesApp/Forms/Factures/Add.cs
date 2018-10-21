using ArticlesApp.Models;
using FacturesApp.Forms.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp.Forms.Factures
{
    public partial class Add : MetroFramework.Forms.MetroForm
    {
        List<FactureLigne> Items = new List<FactureLigne>();

        public Add()
        {
            InitializeComponent();
            FactureLignesGridView.DataSource = Items;
            FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Add(FacturesForm factures)
        {
            InitializeComponent();
            FactureLignesGridView.DataSource = Items;
            FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {

        }

        private void AddLineBtn_Click(object sender, EventArgs e)
        {
            string Reference = ArticleReferenceTetBox.Text;
            string Desgination = ArticleDesignationTextBox.Text;
            int Quantite = 0;
            int.TryParse(QuantiteTextBox.Text, out Quantite);
            float PU = 0;
            float.TryParse(PUTextBox.Text, out PU);

            if (string.IsNullOrWhiteSpace(Reference) || string.IsNullOrEmpty(Reference) ||
                string.IsNullOrWhiteSpace(Desgination) || string.IsNullOrEmpty(Desgination) ||
                string.IsNullOrEmpty(PUTextBox.Text) || string.IsNullOrWhiteSpace(PUTextBox.Text))
            {
                MessageBox.Show("element non valid");
                return;
            }

            Items.Add(new FactureLigne()
            {
                Id = 0,
                Designation = Desgination,
                PU = PU,
                Quantite = Quantite,
                Reference = Reference
            });
            FactureLignesGridView.DataSource = Items;

            ArticleReferenceTetBox.Text = "";
            ArticleDesignationTextBox.Text = "";
            QuantiteTextBox.Text = "";
            PUTextBox.Text = "";
        }
    }
}
