using ArticlesApp.Forms.Shared;
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
    public partial class Factures : MetroFramework.Forms.MetroForm
    {
        private IRepository<Article, long> articleRepo;
        public static Article selectedArticle;
        public List<Article> Articles;
        public Home home;

        public Factures()
        {
            InitializeComponent();
            articleRepo = new ArticleRepo();
            Articles = articleRepo.Get();
            ArticleGridView.DataSource = Articles;
            ArticleGridView.Columns["Id"].Visible = false;
            ArticleGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (Articles?.Count == 0)
            {
                EditBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }
        }

        public Factures(Home _home)
        {
            InitializeComponent();
            home = _home;
            articleRepo = new ArticleRepo();
            Articles = articleRepo.Get();
            ArticleGridView.DataSource = Articles;
            ArticleGridView.Columns["Id"].Visible = false;
            ArticleGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (Articles?.Count == 0)
            {
                EditBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }
        }

        private void AddArticleBtn_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(this);
            addForm.ShowDialog();
        }

        private void EditArticleBtn_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit(this);
            editForm.ShowDialog();
        }

        private void RemoveArticleBtn_Click(object sender, EventArgs e)
        {
            Remove removeForm = new Remove(this);
            removeForm.ShowDialog();
        }

        private void ArticleGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedArticle = articleRepo.Get(Convert.ToInt32(ArticleGridView.CurrentRow.Cells["Id"].Value));
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var queryString = SearchBox.Text.ToLower();

            if (string.IsNullOrEmpty(queryString) && string.IsNullOrWhiteSpace(queryString))
            {
                ArticleGridView.DataSource = Articles;
                return;
            }
            var k = Articles.Where(a => a.Reference.ToLower().Contains(queryString) ||
                          a.Designation.ToLower().Contains(queryString) ||
                          a.Prix.ToString().Contains(queryString) ||
                          a.Quantite.ToString().Contains(queryString)).ToList();
            ArticleGridView.DataSource = k;
            if (k?.Count == 0)
            {
                EditBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }
            else
            {
                EditBtn.Enabled = true;
                RemoveBtn.Enabled = true;
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm seachForm = new SearchForm(this);
            seachForm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Articles = articleRepo.Get();
            ArticleGridView.DataSource = Articles;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
