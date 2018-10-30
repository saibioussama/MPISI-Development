using ArticlesApp.Models;
using ArticlesApp.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp.Forms.Articles
{
    public partial class Edit : MetroFramework.Forms.MetroForm
    {
        Article article;
        private IRepository<Article, long> articleRepo;
        Factures home;
        public Edit(Factures _home)
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            article = Factures.selectedArticle;
            ReferenceTextBox.Text = article.Reference;
            DescriptionTextBox.Text = article.Designation;
            PriceTextBox.Text = article.Prix.ToString();
            QuantityTextBox.Text = article.Quantite.ToString();
            InPromotionCheckBox.Checked = article.Promo.Value;
            DateEndPromotTimePicker.Text = article.DateFinPromo.ToString();
            home = _home;
        }

        public Edit()
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            article = Factures.selectedArticle;
            ReferenceTextBox.Text = article.Reference;
            DescriptionTextBox.Text = article.Designation;
            PriceTextBox.Text = article.Prix.ToString();
            QuantityTextBox.Text = article.Quantite.ToString();
            InPromotionCheckBox.Checked = article.Promo.Value;
            DateEndPromotTimePicker.Text = article.DateFinPromo.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                article.Reference = ReferenceTextBox.Text;
                article.Designation = DescriptionTextBox.Text;
                article.Promo = InPromotionCheckBox.Checked;
                article.DateFinPromo = Convert.ToDateTime(DateEndPromotTimePicker.Text);
                float price;
                article.Prix = float.TryParse(PriceTextBox.Text, out price) ? price : 0;
                if (string.IsNullOrWhiteSpace(QuantityTextBox.Text) || string.IsNullOrEmpty(QuantityTextBox.Text))
                    article.Quantite = null;
                else
                    article.Quantite = Convert.ToInt32(QuantityTextBox.Text);
                if (string.IsNullOrEmpty(article.Reference) || string.IsNullOrWhiteSpace(article.Reference))
                {
                    MessageBox.Show("Reference field is empty.");
                    return;
                }
                if (string.IsNullOrEmpty(article.Designation) || string.IsNullOrWhiteSpace(article.Designation))
                {
                    MessageBox.Show("Description field is empty.");
                    return;
                }
                articleRepo.Edit(article);
                MessageBox.Show("article updated successfully. ");
                home.ArticleGridView.DataSource = articleRepo.Get();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed!");
            }
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            if (char.IsDigit(c) || c == 8)
                e.Handled = false;
            else
                e.Handled = true;
            return;
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            if (char.IsDigit(c) || c == 8 || (c == 46 && PriceTextBox.Text.IndexOf(".") == -1))
                e.Handled = false;
            else
                e.Handled = true;
            return;
        }
        
        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
