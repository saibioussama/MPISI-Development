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
    public partial class Add : MetroFramework.Forms.MetroForm
    {
        private ArticleRepo articleRepo;
        Article article;

        Factures preForm;

        public Add(Factures _preForm)
        {
            InitializeComponent();
            preForm = _preForm;
            articleRepo = new ArticleRepo();
            article = new Article()
            {
                Reference = Guid.NewGuid().ToString(),
                Prix = 0,
            };
            PriceTextBox.Text = "0.00";
            ReferenceTextBox.Text = article.Reference;
        }

        public Add()
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            article = new Article()
            {
                Reference = Guid.NewGuid().ToString(),
                Prix = 0,
            };
            PriceTextBox.Text = "0.00";
            ReferenceTextBox.Text = article.Reference;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                article.Reference = ReferenceTextBox.Text;
                article.Designation = DescriptionTextBox.Text;
                article.Promo = InPromotionCheckBox.Checked;
                article.DateFinPromo = Convert.ToDateTime(DateEndPromotTimePicker.Text);
                float price;
                article.Prix = float.TryParse(PriceTextBox.Text,out price)?price:0;
                if (string.IsNullOrWhiteSpace(QuantityTextBox.Text) || string.IsNullOrEmpty(QuantityTextBox.Text))
                    article.Quantite = null;
                else
                    article.Quantite = Convert.ToInt32(QuantityTextBox.Text);
                if (string.IsNullOrEmpty(article.Reference) || string.IsNullOrWhiteSpace(article.Reference))
                {
                    MessageBox.Show("Reference field is empty.");
                    return;
                }
                if(articleRepo.IsExist(article.Reference))
                {
                    MessageBox.Show("reference exist. choose another reference.");
                    return;
                }
                if (string.IsNullOrEmpty(article.Designation) || string.IsNullOrWhiteSpace(article.Designation))
                {
                    MessageBox.Show("Description field is empty.");
                    return;
                }
                articleRepo.Insert(article);
                MessageBox.Show("article inserted. ");
                preForm.ArticleGridView.DataSource = articleRepo.Get();
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
            if (char.IsDigit(c) || c == 8 )
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
