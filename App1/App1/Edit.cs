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
    public partial class Edit : MetroFramework.Forms.MetroForm
    {
        public event Action OnArticlesChanged;
        private App1CL.Models.Article article;
        App1CL.Repositories.ArticlesRepo articlesRepo;

        public Edit(App1CL.Models.Article _article)
        {
            InitializeComponent();
            articlesRepo = new App1CL.Repositories.ArticlesRepo();
            article = _article;
            RefTextBox.Text = article.Ref;
            DescriptionTextBox.Text = article.Description;
            PriceTextBox.Text = article.Price.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                article.Description = DescriptionTextBox.Text;
                article.Price = Convert.ToDecimal(PriceTextBox.Text);
                if (string.IsNullOrEmpty(article.Description) || string.IsNullOrWhiteSpace(article.Description))
                {
                    MessageBox.Show("description field is empty!");
                    return;
                }
                articlesRepo.Edit(article);
                MessageBox.Show("Article updated successfully ");
                OnArticlesChanged?.Invoke();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("something went wrong!");
            }
        }
    }
}
