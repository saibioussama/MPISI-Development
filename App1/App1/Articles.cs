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
    public partial class Articles : MetroFramework.Forms.MetroForm
    {
        App1CL.Repositories.ArticlesRepo articlesRepo;

        public App1CL.Models.Article selectedArticle;

        public Articles()
        {
            InitializeComponent();
            selectedArticle = null;
            articlesRepo = new App1CL.Repositories.ArticlesRepo();
            ArticlesGridView.DataSource = articlesRepo.Get();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();
            addForm.OnArticlesChanged += () =>
            {
                ArticlesGridView.DataSource = articlesRepo.Get();
            };
            addForm.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selectedArticle == null)
            {
                MessageBox.Show("select artcile then edit it.");
                return;
            }
            Edit editForm = new Edit(selectedArticle);
            editForm.OnArticlesChanged += () =>
            {
                ArticlesGridView.DataSource = articlesRepo.Get();
            };
            editForm.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (selectedArticle == null)
            {
                MessageBox.Show("select artcile then remove it.");
                return;
            }
            Remove removeForm = new Remove(selectedArticle);
            removeForm.OnArticlesChanged += () =>
            {
                ArticlesGridView.DataSource = articlesRepo.Get();
            };
            removeForm.Show();
        }

        private void ArticlesGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedArticle = new App1CL.Models.Article
            {
                Ref = ArticlesGridView.CurrentRow.Cells["Ref"].Value.ToString(),
                Description= ArticlesGridView.CurrentRow.Cells["Description"].Value.ToString(),
                Price= Convert.ToDecimal(ArticlesGridView.CurrentRow.Cells["Price"].Value)
            };
        }
    }
}
