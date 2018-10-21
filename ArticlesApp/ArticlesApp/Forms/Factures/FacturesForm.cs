using ArticlesApp.Forms.Factures;
using ArticlesApp.Forms.Shared;
using ArticlesApp.Models;
using ArticlesApp.Repos; 
using FacturesApp.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturesApp.Forms.Factures
{
    public partial class FacturesForm : MetroFramework.Forms.MetroForm
    {
        private IRepository<Facture, long> factureRepo;
        public static Facture selectedFacture;
        public List<Facture> Factures;
        public Home home;

        public FacturesForm()
        {
            InitializeComponent();
            factureRepo = new FacturesRepo();
            Factures = factureRepo.Get();
            FacturesGridView.DataSource = Factures;
            FacturesGridView.Columns["Id"].Visible = false;
            FacturesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (Factures?.Count == 0)
            {
                EditBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }
        }

        public FacturesForm(Home _home)
        {
            InitializeComponent();
            home = _home;
            factureRepo = new FacturesRepo();
            Factures = factureRepo.Get();
            FacturesGridView.DataSource = Factures;
            FacturesGridView.Columns["Id"].Visible = false;
            FacturesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (Factures?.Count == 0)
            {
                EditBtn.Enabled = false;
                RemoveBtn.Enabled = false;
            }
        }

        private void AddFactureBtn_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(this);
            addForm.ShowDialog();
        }

        private void EditFactureBtn_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit(this);
            editForm.ShowDialog();
        }

        private void RemoveFactureBtn_Click(object sender, EventArgs e)
        {
            Remove removeForm = new Remove(this);
            removeForm.ShowDialog();
        }

        private void FactureGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedFacture = factureRepo.Get(Convert.ToInt32(FacturesGridView.CurrentRow.Cells["Id"].Value));
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var queryString = SearchBox.Text.ToLower();

            if (string.IsNullOrEmpty(queryString) && string.IsNullOrWhiteSpace(queryString))
            {
                FacturesGridView.DataSource = Factures;
                return;
            }
            var k = Factures.Where(a => a.Reference.ToLower().Contains(queryString) ||
                          a.Montant.ToString().Contains(queryString)).ToList();
            FacturesGridView.DataSource = k;
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
            Factures = factureRepo.Get();
            FacturesGridView.DataSource = Factures;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
