using ArticlesApp.Models;
using ArticlesApp.Repos;
using FacturesApp.Forms.Factures;
using FacturesApp.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using ArticlesApp.Models.ViewModels;

namespace ArticlesApp.Forms.Factures
{
  public partial class Add : MetroFramework.Forms.MetroForm
  {

    #region declaration of repositories

    private readonly FacturesRepo facturesRepo = new FacturesRepo();
    private readonly FactureLigneRepo factureLigneRepo = new FactureLigneRepo();
    private readonly ArticleRepo articleRepo = new ArticleRepo();
    private readonly TransactionsRepository transactionsRepository = new TransactionsRepository();

    #endregion

    #region some properties

    List<FactureLigneViewModel> Items;
    List<Article> articles = new List<Article>();
    List<Article> UpdatedArticles = new List<Article>();

    FacturesForm facturesForm;
    FactureLigneViewModel selectedFactureLigne;

    #endregion

    #region Constractors

    public Add()
    {
      InitializeComponent();
      FactureLignesGridView.DataSource = Items;
      FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    public Add(FacturesForm _facturesForm)
    {
      InitializeComponent();
      facturesForm = _facturesForm;
      Items = new List<FactureLigneViewModel>();
      FactureLignesGridView.DataSource = Items;
      FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      FactureLignesGridView.Columns[nameof(FactureLigneViewModel.Id)].Visible = false;
      FactureLignesGridView.Columns[nameof(FactureLigneViewModel.IdFacture)].Visible = false;
      FactureLignesGridView.Columns[nameof(FactureLigneViewModel.IdArticle)].Visible = false;
      InitAutoComplete();
    }

    #endregion

    //Add list of articles to ref & desc Auto-complete text-box 
    private void InitAutoComplete()
    {
      try
      {
        articles = articleRepo.Get();
        foreach (var article in articles)
        {
          ArticleReferenceTextBox.AutoCompleteCustomSource.Add(article.Reference);
          ArticleDesignationTextBox.AutoCompleteCustomSource.Add(article.Designation);
        }
      }
      catch
      {
        MessageBox.Show("something went wrong while initialize auto-complete fields !");
      }
    }

    private void AddLineBtn_Click(object sender, EventArgs e)
    {
      string Reference = ArticleReferenceTextBox.Text;
      string Desgination = ArticleDesignationTextBox.Text;
      int Quantite = 0;
      int.TryParse(QuantiteTextBox.Text, out Quantite);

      Article article = articles.SingleOrDefault(a => a.Reference == Reference);
      if (article == null)
      {
        MessageBox.Show("Article not found");
        return;
      }

      if (Quantite > article.Quantite || Quantite == 0)
      {
        MessageBox.Show("Quantite non valid");
        return;
      }
      else
        article.Quantite -= Quantite;
      float PU = article.Prix;

      var updatedArticle = UpdatedArticles.FirstOrDefault(a => a.Id == article.Id) ?? null;
      if (updatedArticle == null)
        UpdatedArticles.Add(new Article() { Id = article.Id, Quantite = Quantite });
      else
        updatedArticle.Quantite += Quantite;

      if (string.IsNullOrWhiteSpace(Reference) || string.IsNullOrEmpty(Reference) ||
          string.IsNullOrWhiteSpace(Desgination) || string.IsNullOrEmpty(Desgination) ||
          string.IsNullOrEmpty(PUTextBox.Text) || string.IsNullOrWhiteSpace(PUTextBox.Text))
      {
        MessageBox.Show("Ligne facture non valid");
        return;
      }

      var AddedArticle = Items.SingleOrDefault(a => a.IdArticle == article.Id);

      if (AddedArticle == null)
        Items.Add(new FactureLigneViewModel()
        {
          Id = 0,
          Designation = article.Designation,
          PrixUnitaire = article.Prix,
          Quantite = Quantite,
          Reference = article.Reference,
          IdArticle = article.Id,
          Total = Quantite * article.Prix,
        });
      else
      {
        AddedArticle.Quantite += Quantite;
        AddedArticle.Total = AddedArticle.Quantite * AddedArticle.PrixUnitaire;
      }
      FactureLignesGridView.DataSource = new List<FactureLigneViewModel>(Items);

      TotalPriceTextBlock.Text = GetMontant().ToString();
      ArticleReferenceTextBox.Text = "";
      ArticleDesignationTextBox.Text = "";
      QuantiteTextBox.Text = "";
      PUTextBox.Text = "";
    }

    private void ConfirmBtn_Click(object sender, EventArgs e)
    {
      if (Items.Count == 0)
      {
        MessageBox.Show("Invoice  could not be empty !");
        return;
      }

      string reference = ReferenceTextBox.Text;

      DateTime Date = Convert.ToDateTime(DateDP.Text);

      if (string.IsNullOrEmpty(reference) || string.IsNullOrWhiteSpace(reference))
      {
        MessageBox.Show("Reference non valid");
        return;
      }

      if (facturesRepo.IsExist(reference))
      {
        MessageBox.Show("Reference exist. choose another reference.");
        return;
      }

      Facture facture = new Facture()
      {
        Date = DateDP.Value,
        Reference = ReferenceTextBox.Text,
        Total = GetMontant(),
      };

      List<LigneFacture> factureLignes = new List<LigneFacture>();

      foreach (var item in Items)
        factureLignes.Add(new LigneFacture(item));

      List<Article> UpdatedArticles = new List<Article>();

      foreach (var factureLigne in factureLignes)
      {
        UpdatedArticles.Add(new Article() { Quantite = factureLigne.Quantite, Id = factureLigne.IdArticle });
      }

      if (transactionsRepository.AddFactureWithTransaction(facture, factureLignes, UpdatedArticles))
        MessageBox.Show("Facture added successfully ");
      else
        MessageBox.Show("Something went wrong :( ");

      facturesForm.FacturesGridView.DataSource = facturesRepo.Get();

      this.Close();
    }

    private float GetMontant()
    {
      float montant = 0;
      foreach (var item in Items)
        montant += item.PrixUnitaire * item.Quantite;
      return montant;
    }

    private void ArticleReferenceTextBox_TextChanged(object sender, EventArgs e)
    {
      Article selectedArticle = articles.SingleOrDefault(a => a.Reference.ToLower().Equals(ArticleReferenceTextBox.Text.ToLower()));
      if (selectedArticle != null)
      {
        QuantiteTextBox.Text = selectedArticle.Quantite.ToString();
        PUTextBox.Text = selectedArticle.Prix.ToString();
        ArticleDesignationTextBox.Text = selectedArticle.Designation;
      }
      else
      {
        QuantiteTextBox.Text = string.Empty;
        PUTextBox.Text = string.Empty;
        ArticleDesignationTextBox.Text = string.Empty;
      }
    }

    private void ArticleDesignationTextBox_TextChanged(object sender, EventArgs e)
    {
      Article selectedArticle = articles.SingleOrDefault(a => a.Designation.ToLower().Equals(ArticleDesignationTextBox.Text.ToLower()));
      if (selectedArticle != null)
      {
        QuantiteTextBox.Text = selectedArticle.Quantite.ToString();
        PUTextBox.Text = selectedArticle.Prix.ToString();
        ArticleReferenceTextBox.Text = selectedArticle.Reference;
      }
      else
      {
        QuantiteTextBox.Text = string.Empty;
        PUTextBox.Text = string.Empty;
        ArticleReferenceTextBox.Text = string.Empty;
      }
    }

    //get selected Ligne facture from grid view
    private void FactureLignesGridView_SelectionChanged(object sender, EventArgs e)
    {
      selectedFactureLigne = (FactureLigneViewModel)FactureLignesGridView.CurrentRow.DataBoundItem;
    }

    private void RemoveFactureLigneBtn_Click(object sender, EventArgs e)
    {
      try
      {
        Items.Remove(selectedFactureLigne);
        var a = UpdatedArticles.SingleOrDefault(p => p.Id == selectedFactureLigne.IdArticle);
        if (a != null)
          a.Quantite -= selectedFactureLigne.Quantite;
        var article = articles.SingleOrDefault(p => p.Reference == selectedFactureLigne.Reference);
        if (article != null)
          article.Quantite += selectedFactureLigne.Quantite;
        FactureLignesGridView.DataSource = new List<FactureLigneViewModel>(Items);
      }
      catch
      {
        MessageBox.Show("item could not be removed !");
      }
    }

    private void EditFactureLigneBtn_Click(object sender, EventArgs e)
    {
      ArticleReferenceTextBox.Text = selectedFactureLigne.Reference;
      ArticleDesignationTextBox.Text = selectedFactureLigne.Designation;
      QuantiteTextBox.Text = selectedFactureLigne.Quantite.ToString();
      PUTextBox.Text = selectedFactureLigne.PrixUnitaire.ToString();

      try
      {
        Items.Remove(selectedFactureLigne);
        var a = UpdatedArticles.SingleOrDefault(p => p.Id == selectedFactureLigne.IdArticle);
        if (a != null)
          a.Quantite -= selectedFactureLigne.Quantite;
        var article = articles.SingleOrDefault(p => p.Reference == selectedFactureLigne.Reference);
        if (article != null)
          article.Quantite += selectedFactureLigne.Quantite;
        FactureLignesGridView.DataSource = new List<FactureLigneViewModel>(Items);
      }
      catch
      {
        MessageBox.Show("something went wrong while trying to edit ligne facture !");
      }

    }

    //search for ligne in grid view 
    private void SearchBox_TextChanged(object sender, EventArgs e)
    {
      var queryString = SearchBox.Text.ToLower();

      if (string.IsNullOrEmpty(queryString) && string.IsNullOrWhiteSpace(queryString))
      {
        FactureLignesGridView.DataSource = new List<FactureLigneViewModel>(Items);
        return;
      }
      var k = Items.Where(a => a.Reference.ToLower().Contains(queryString) ||
                    a.Designation.ToLower().Contains(queryString) ||
                    a.PrixUnitaire.ToString().Contains(queryString) ||
                    a.Quantite.ToString().Contains(queryString)).ToList();
      FactureLignesGridView.DataSource = k;
    }

    //enable & disable Edit & Remove Ligne facture buttons
    private void FactureLignesGridView_DataSourceChanged(object sender, EventArgs e)
    {
      if (FactureLignesGridView.Rows.Count > 0)
      {
        EditFactureLigneBtn.Enabled = true;
        RemoveFactureLigneBtn.Enabled = true;
      }
      else
      {
        EditFactureLigneBtn.Enabled = false;
        RemoveFactureLigneBtn.Enabled = false;
      }
    }

  }
}
