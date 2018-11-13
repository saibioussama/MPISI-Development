using ArticlesApp.Models;
using ArticlesApp.Models.ViewModels;
using ArticlesApp.Repos;
using FacturesApp.Forms.Factures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp.Forms.Factures
{
  public partial class Details : MetroFramework.Forms.MetroForm
  {
    #region Properties

    FacturesForm facturesForm;
    Facture facture;
    List<FactureLigneViewModel> items = new List<FactureLigneViewModel>();
    List<LigneFacture> _items = new List<LigneFacture>();
    ArticleRepo articleRepo = new ArticleRepo();
    FactureLigneRepo factureLigneRepo = new FactureLigneRepo();

    #endregion

    #region Constractors

    public Details()
    {
      InitializeComponent();
    }

    public Details(FacturesForm _facturesForm)
    {
      InitializeComponent();
      try
      {
        facturesForm = _facturesForm;
        facture = facturesForm.selectedFacture;
        _items = factureLigneRepo.GetByFactureId(facture.Id);
        items = _items.Select(p => new FactureLigneViewModel(p, articleRepo.Get(p.IdArticle))).ToList();
        FactureLignesGridView.DataSource = items;
        FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        FactureLignesGridView.Columns[nameof(FactureLigneViewModel.Id)].Visible = false;
        FactureLignesGridView.Columns[nameof(FactureLigneViewModel.IdFacture)].Visible = false;
        FactureLignesGridView.Columns[nameof(FactureLigneViewModel.IdArticle)].Visible = false;
        ReferenceLabel.Text = facture.Reference;
        DateLabel.Text = facture.Date.ToString();
        TotalPriceTextBlock.Text = facture.Total.ToString();
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

    private void SearchBox_TextChanged(object sender, EventArgs e)
    {
      var query = SearchBox.Text.ToLower();
      if (query.Length > 0)
      {
        FactureLignesGridView.DataSource = items.Where(a => a.Reference.ToLower().Contains(query) ||
                           a.PrixUnitaire.ToString().Contains(query) ||
                           a.Quantite.ToString().Contains(query) ||
                           a.Designation.ToLower().Contains(query)).ToList();
      }
      else
        FactureLignesGridView.DataSource = items;
    }

    private void PrintBtn_Click(object sender, EventArgs e)
    {
      printDocument.Print();
    }

    private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      StringBuilder FileContent = new StringBuilder();
      //FileContent.Append($"{nameof(FactureLigneViewModel.Reference)} ");
      //FileContent.Append($"{nameof(FactureLigneViewModel.Designation)} ");
      //FileContent.Append($"{nameof(FactureLigneViewModel.Quantite)} ");
      //FileContent.Append($"{nameof(FactureLigneViewModel.PrixUnitaire)} ");
      //FileContent.Append($"{nameof(FactureLigneViewModel.Total)} ");
      //FileContent.Append("\n");
      //foreach (var ligne in items)
      //{
      //  FileContent.Append($"{ligne.Reference} ");
      //  FileContent.Append($"{ligne.Designation} ");
      //  FileContent.Append($"{ligne.Quantite} " );
      //  FileContent.Append($"{ligne.PrixUnitaire} ");
      //  FileContent.Append($"{ligne.Total} ");
      //  FileContent.Append("\n");
      //} 
      FileContent.Append(JsonConvert.SerializeObject(items));

      e.Graphics.DrawString(FileContent.ToString(), this.Font, Brushes.Black,e.MarginBounds, StringFormat.GenericTypographic);

    }
  }
}
