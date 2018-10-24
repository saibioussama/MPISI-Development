using ArticlesApp.Models;
using ArticlesApp.Repos;
using FacturesApp.Forms.Factures;
using FacturesApp.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Article article = articles.SingleOrDefault(a=>a.Ref == Reference);
            if (article == null)
            {
                MessageBox.Show("article not found");
                return;
            }

            if (Quantite > article.Quantity || Quantite == 0)
            {
                MessageBox.Show("Quantite non valid");
                return;
            }
            else
                article.Quantity -= Quantite;

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
                Designation = article.Description,
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
                MessageBox.Show("Invoice  could not be empty !");
                return;
            }

            string reference = ReferenceTextBox.Text;
            DateTime Date = Convert.ToDateTime(DateDP.Text);
            if(string.IsNullOrEmpty(reference) || string.IsNullOrWhiteSpace(reference))
            {
                MessageBox.Show("Reference non valid");
                return;
            }

            if(facturesRepo.IsExist(reference))
            {
                MessageBox.Show("Reference exist. choose another reference.");
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
            UpdateArticles();
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
            try
            {
                Items.Remove(selectedFactureLigne);
                var article = articles.SingleOrDefault(p => p.Ref == selectedFactureLigne.Reference);
                if (article != null)
                    article.Quantity += selectedFactureLigne.Quantite;
                FactureLignesGridView.DataSource = new List<FactureLigne>(Items);
            }
            catch
            {
                MessageBox.Show("item could not removed !");
            }
        }

        private void FactureLignesGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedFactureLigne = (FactureLigne)FactureLignesGridView.CurrentRow.DataBoundItem;
        }

        private void EditFactureLigneBtn_Click(object sender, EventArgs e)
        {
            ArticleReferenceTextBox.Text = selectedFactureLigne.Reference;
            ArticleDesignationTextBox.Text = selectedFactureLigne.Designation;
            QuantiteTextBox.Text = selectedFactureLigne.Quantite.ToString();
            PUTextBox.Text = selectedFactureLigne.PU.ToString();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var queryString = SearchBox.Text.ToLower();

            if (string.IsNullOrEmpty(queryString) && string.IsNullOrWhiteSpace(queryString))
            {
                FactureLignesGridView.DataSource = new List<FactureLigne>(Items);
                return;
            }
            var k = Items.Where(a => a.Reference.ToLower().Contains(queryString) ||
                          a.Designation.ToLower().Contains(queryString)||
                          a.PU.ToString().Contains(queryString) ||
                          a.Quantite.ToString().Contains(queryString)).ToList();
            FactureLignesGridView.DataSource = k;
        }

        private void UpdateArticles()
        {
            foreach (var article in articles)
            {
                try
                {
                    articleRepo.Edit(article);
                }
                catch
                {
                    
                }
            }

        }

    }
}
