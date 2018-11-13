using ArticlesApp.Models;
using ArticlesApp.Models.ViewModels;
using ArticlesApp.Repos;
using FacturesApp.Forms.Factures;
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

namespace ArticlesApp.Forms.Factures
{
  public partial class Remove : MetroFramework.Forms.MetroForm
  {
    #region Properties
    
    FacturesRepo facturesRepo = new FacturesRepo();
    FactureLigneRepo factureLigneRepo = new FactureLigneRepo();
    ArticleRepo articleRepo = new ArticleRepo();
    Facture facture;
    FacturesForm facturesForm;

    #endregion

    #region Constractors 

    public Remove()
    {
      InitializeComponent();
    }

    public Remove(FacturesForm _facturesForm)
    {
      InitializeComponent();
      try
      {
        facturesForm = _facturesForm;
        facture = facturesForm.selectedFacture;
        ReferenceLabel.Text = facture.Reference;
        TotalPriceLabel.Text = facture.Total.ToString();
        DateLabel.Text = facture.Date.ToString();
        var factureLignes = factureLigneRepo.GetByFactureId(facture.Id);
        var model = factureLignes.Select(f => new FactureLigneViewModel(f, articleRepo.Get(f.IdArticle))).ToList();
        FactureLignesGridView.DataSource = model;
        FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        FactureLignesGridView.Columns[nameof(FactureLigneViewModel.Id)].Visible = false;
        FactureLignesGridView.Columns[nameof(FactureLigneViewModel.IdFacture)].Visible = false;
        FactureLignesGridView.Columns[nameof(FactureLigneViewModel.IdArticle)].Visible = false;
      }
      catch
      {
        MessageBox.Show("something went wrong !");
      }
    }

    #endregion


    private void CancelBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void RemoveBtn_Click(object sender, EventArgs e)
    {
      try
      {
        facturesRepo.Remove(facture.Id);
        facturesForm.FacturesGridView.DataSource = facturesRepo.Get();
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("something went wrong !");
      }
    }
  }
}
