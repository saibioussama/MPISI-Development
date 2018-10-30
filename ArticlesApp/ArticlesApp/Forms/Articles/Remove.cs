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
    public partial class Remove : MetroFramework.Forms.MetroForm
    {
        private IRepository<Article, long> articleRepo;
        Article article;
        Factures home;
        public Remove()
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            article = Factures.selectedArticle;
            ReferenceTB.Text = article.Reference;
            DescriptionTB.Text = article.Designation;
            PriceTB.Text = article.Prix.ToString();
            QuantityTB.Text = article.Quantite.ToString();
            InPromotionTB.Text = article.Promo == true ? "is in promotion :)" : "is not in promotion :(";
            DateEndPromotionTB.Text = article.DateFinPromo.ToString();
        }

        public Remove(Factures _home)
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            article = Factures.selectedArticle;
            ReferenceTB.Text = article.Reference;
            DescriptionTB.Text = article.Designation;
            PriceTB.Text = article.Prix.ToString();
            QuantityTB.Text = article.Quantite.ToString();
            InPromotionTB.Text = article.Promo == true ? "is in promotion :)" : "is not in promotion :(";
            DateEndPromotionTB.Text = article.DateFinPromo.ToString();
            home = _home;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (article != null)
                {
                    articleRepo.Remove(article.Id);
                    MessageBox.Show("article removed.");
                    home.ArticleGridView.DataSource = articleRepo.Get();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                this.Close();
            }
        }
    }
}
