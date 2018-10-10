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

namespace ArticlesApp
{
    public partial class Add : MetroFramework.Forms.MetroForm
    {
        private ArticleRepo articleRepo;
        Article article;

        Home preForm;

        public Add(Home _preForm)
        {
            InitializeComponent();
            preForm = _preForm;
            articleRepo = new ArticleRepo();
            article = new Article()
            {
                Ref = Guid.NewGuid().ToString(),
                Price = 0,
            };
            PriceTextBox.Text = "0.00";
            ReferenceTextBox.Text = article.Ref;
        }

        public Add()
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            article = new Article()
            {
                Ref = Guid.NewGuid().ToString(),
                Price = 0,
            };
            PriceTextBox.Text = "0.00";
            ReferenceTextBox.Text = article.Ref;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                article.Ref = ReferenceTextBox.Text;
                article.Description = DescriptionTextBox.Text;
                article.IsInPromot = InPromotionCheckBox.Checked;
                article.DateEndPromot = Convert.ToDateTime(DateEndPromotTimePicker.Text);
                double price;
                article.Price = double.TryParse(PriceTextBox.Text,out price)?price:0;
                if (string.IsNullOrWhiteSpace(QuantityTextBox.Text) || string.IsNullOrEmpty(QuantityTextBox.Text))
                    article.Quantity = null;
                else
                    article.Quantity = Convert.ToInt32(QuantityTextBox.Text);
                if (string.IsNullOrEmpty(article.Ref) || string.IsNullOrWhiteSpace(article.Ref))
                {
                    MessageBox.Show("Reference field is empty.");
                    return;
                }
                if (string.IsNullOrEmpty(article.Description) || string.IsNullOrWhiteSpace(article.Description))
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
