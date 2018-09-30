using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Remove : MetroFramework.Forms.MetroForm
    {
        public event Action OnArticlesChanged;
        App1CL.Models.Article article;
        App1CL.Repositories.ArticlesRepo articlesRepo;
        public Remove(App1CL.Models.Article _article)
        {
            InitializeComponent();
            articlesRepo = new App1CL.Repositories.ArticlesRepo();
            article = _article;
            ReferenceLable.Text = article.Ref;
            DescriptionLable.Text = article.Description;
            PriceLable.Text = article.Price.ToString();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                articlesRepo.Remove(article.Ref);
                MessageBox.Show("Article removed . ");
                OnArticlesChanged?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("something went wrong!");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
