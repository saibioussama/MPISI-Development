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
    public partial class Add : MetroFramework.Forms.MetroForm
    {
        List<FactureLigne> Items;
        FacturesRepo facturesRepo = new FacturesRepo();
        FactureLigneRepo factureLigneRepo = new FactureLigneRepo();
        ArticleRepo articleRepo = new ArticleRepo();
        List<Article> articles = new List<Article>();
        FacturesForm facturesForm;
        FactureLigne selectedFactureLigne;

        private void initAutoComplete()
        {
            articles = articleRepo.Get();
            foreach (var article in articles)
            {
                ArticleReferenceTextBox.AutoCompleteCustomSource.Add(article.Ref);
                ArticleDesignationTextBox.AutoCompleteCustomSource.Add(article.Description);
            }
        }

        public Add()
        {
            InitializeComponent();
            FactureLignesGridView.DataSource = Items;
            FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Add(FacturesForm _facturesForm)
        {
            InitializeComponent();
            facturesForm = _facturesForm;
            Items = new List<FactureLigne>();
            FactureLignesGridView.DataSource = Items;
            FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FactureLignesGridView.Columns[nameof(FactureLigne.Id)].Visible = false;
            FactureLignesGridView.Columns[nameof(FactureLigne.FactureId)].Visible = false;
            FactureLignesGridView.Columns[nameof(FactureLigne.ArticleId)].Visible = false;
            initAutoComplete();
        }


        private void SearchBox_Click(object sender, EventArgs e)
        {

        }

        private void AddLineBtn_Click(object sender, EventArgs e)
        {
            string Reference = ArticleReferenceTextBox.Text;
            string Desgination = ArticleDesignationTextBox.Text;
            int Quantite = 0;
            int.TryParse(QuantiteTextBox.Text, out Quantite);
            float PU = 0;
            float.TryParse(PUTextBox.Text, out PU);
            Article article = articleRepo.Get(Reference);
            if (article == null)
            {
                MessageBox.Show("article not found");
                return;
            }

            if (Quantite > article.Quantity)
            {
                MessageBox.Show("Quantite non valid");
                return;
            }

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
                PU = article.Price,
                Quantite = Quantite,
                Reference = article.Ref,
                ArticleId = article.Id
            });
            FactureLignesGridView.DataSource = new List<FactureLigne>(Items);

            TotalPriceTextBlock.Text = getMontant().ToString();
            ArticleReferenceTextBox.Text = "";
            ArticleDesignationTextBox.Text = "";
            QuantiteTextBox.Text = "";
            PUTextBox.Text = "";
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(Items.Count == 0)
            {
                MessageBox.Show("invoice  could not be empty !");
                return;
            }

            string reference = ReferenceTextBox.Text;
            DateTime Date = Convert.ToDateTime(DateDP.Text);
            if(string.IsNullOrEmpty(reference) || string.IsNullOrWhiteSpace(reference))
            {
                MessageBox.Show("reference non valid");
                return;
            }

            if(facturesRepo.IsExist(reference))
            {
                MessageBox.Show("reference exist. choose another reference.");
                return;
            }

            Facture facture = new Facture()
            {
                Date = DateDP.Value,
                Reference = ReferenceTextBox.Text,
                Montant = getMontant(),
            };

            if (facturesRepo.Insert(facture) > 0)
            {
                var lastId = facturesRepo.GetLastInsertedId();
                if(lastId > 0)
                {
                    foreach (var item in Items)
                    {
                        item.FactureId = lastId;
                        if (factureLigneRepo.Insert(item) <= 0)
                            throw new Exception();
                    }
                }
            }
            else
            {
                MessageBox.Show("failed to save facture ");
                return;
            }

            facturesForm.FacturesGridView.DataSource = facturesRepo.Get();
            this.Close();
        }

        private float getMontant()
        {
            float montant = 0;
            foreach (var item in Items)
                montant += item.PU * item.Quantite;
            return montant;
        }

        private void ArticleReferenceTextBox_TextChanged(object sender, EventArgs e)
        {
            Article selectedArticle = articles.SingleOrDefault(a => a.Ref.ToLower().Equals(ArticleReferenceTextBox.Text.ToLower()));
            if (selectedArticle != null)
            {
                QuantiteTextBox.Text = selectedArticle.Quantity.ToString();
                PUTextBox.Text = selectedArticle.Price.ToString();
                ArticleDesignationTextBox.Text = selectedArticle.Description;
            }
            else
            {
                QuantiteTextBox.Text = string.Empty;
                PUTextBox.Text = string.Empty;
                ArticleDesignationTextBox.Text = string.Empty;
            }
        }

        private void ArticleDesignationTextBox_TextChanged(object sender, EventArgs e)
        {
            Article selectedArticle = articles.SingleOrDefault(a => a.Description.ToLower().Equals(ArticleDesignationTextBox.Text.ToLower()));
            if (selectedArticle != null)
            {
                QuantiteTextBox.Text = selectedArticle.Quantity.ToString();
                PUTextBox.Text = selectedArticle.Price.ToString();
                ArticleReferenceTextBox.Text = selectedArticle.Ref;
            }
            else
            {
                QuantiteTextBox.Text = string.Empty;
                PUTextBox.Text = string.Empty;
                ArticleReferenceTextBox.Text = string.Empty;
            }
        }

        private void RemoveFactureLigneBtn_Click(object sender, EventArgs e)
        {
            Items.Remove(selectedFactureLigne);
            FactureLignesGridView.DataSource = Items;
        }

        private void FactureLignesGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedFactureLigne = (FactureLigne)FactureLignesGridView.CurrentRow.DataBoundItem;
        }
    }
}
