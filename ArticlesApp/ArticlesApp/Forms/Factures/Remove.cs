using ArticlesApp.Models;
using ArticlesApp.Repos;
using FacturesApp.Forms.Factures;
using FacturesApp.Repos;
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
    public partial class Remove : MetroFramework.Forms.MetroForm
    {
        FacturesRepo facturesRepo = new FacturesRepo();
        FactureLigneRepo factureLigneRepo = new FactureLigneRepo();
        Facture facture;
        FacturesForm facturesForm;
        public Remove()
        {
            InitializeComponent();
        }

        public Remove(FacturesForm _facturesForm)
        {
            InitializeComponent();
            facturesForm = _facturesForm;
            facture = facturesForm.selectedFacture;
            ReferenceLabel.Text = facture.Reference;
            DateLabel.Text = facture.Date.ToString();
            InvoiceItemsLabel.Text = $"{factureLigneRepo.GetByFactureId(facture.Id).Count()} items.";
        }



        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            facturesRepo.Remove(facture.Id);
            facturesForm.FacturesGridView.DataSource = facturesRepo.Get();
            this.Close();
        }
    }
}
