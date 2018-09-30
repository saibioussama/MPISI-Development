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
    public partial class Add : MetroFramework.Forms.MetroForm
    {

        public event Action OnArticlesChanged;

        App1CL.Models.Article article;
        App1CL.Repositories.ArticlesRepo articlesRepo;
        public Add()
        {
            InitializeComponent();
            articlesRepo = new App1CL.Repositories.ArticlesRepo();
            article = new App1CL.Models.Article()
            {
                Ref = Guid.NewGuid().ToString(),
            };
            RefTextBox.Text = article.Ref;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
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
                articlesRepo.Insert(article);
                MessageBox.Show("Article added successfully ");
                OnArticlesChanged?.Invoke();
                this.Close();
            }
            catch  
            {
                MessageBox.Show("something went wrong!");
            }
        }
    }
}
