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
    public partial class Edit : MetroFramework.Forms.MetroForm
    {
        ArticleRepo articleRepo = new ArticleRepo();
        FacturesRepo facturesRepo = new FacturesRepo();
        Facture facture;
        FacturesForm facturesForm;
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(FacturesForm _facturesForm)
        {
            InitializeComponent();
            facturesForm = _facturesForm;
            facture = facturesForm.selectedFacture;
            ReferenceTextBox.Text = facture.Reference;
            DateDP.Value = facture.Date;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ReferenceTextBox.Text) || string.IsNullOrWhiteSpace(ReferenceTextBox.Text))
                {
                    MessageBox.Show("reference non valid");
                    return;
                }

                facture.Reference = ReferenceTextBox.Text;
                facture.Date = DateDP.Value;
                facturesRepo.Edit(facture);
                facturesForm.FacturesGridView.DataSource = facturesRepo.Get();
                this.Close();
            }
            catch
            {
                MessageBox.Show("something went wrong !");
            }
        }
    }
}
