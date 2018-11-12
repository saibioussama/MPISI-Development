using ArticlesApp.Models;
using ArticlesApp.Models.ViewModels;
using ArticlesApp.Repos;
using FacturesApp.Forms.Factures;
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
    FacturesForm facturesForm;
    Facture facture;
    List<FactureLigneViewModel> items = new List<FactureLigneViewModel>();
    List<FactureLigne> _items = new List<FactureLigne>();
    ArticleRepo articleRepo = new ArticleRepo();
    FactureLigneRepo factureLigneRepo = new FactureLigneRepo();
    public Details()
    {
      InitializeComponent();
    }

    public Details(FacturesForm _facturesForm)
    {
      InitializeComponent();
      facturesForm = _facturesForm;
      facture = facturesForm.selectedFacture;
      _items = factureLigneRepo.GetByFactureId(facture.Id);
      items = _items.Select(p => new FactureLigneViewModel(p, articleRepo.Get(p.ArticleId))).ToList();
      FactureLignesGridView.DataSource = items;
      FactureLignesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      FactureLignesGridView.Columns[nameof(FactureLigne.Id)].Visible = false;
      //FactureLignesGridView.Columns[nameof(LigneFacture.IdFacture)].Visible = false;
      //FactureLignesGridView.Columns[nameof(LigneFacture.IdArticle)].Visible = false;
      ReferenceLabel.Text = facture.Reference;
      DateLabel.Text = facture.Date.ToString();
      TotalPriceTextBlock.Text = facture.Montant.ToString();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    public void printPDFWithAcrobat()
    {
      string Filepath = @"C:\pdfsample.pdf";

      MyPrintDialog.ShowDialog();

      ProcessStartInfo printProcessInfo = new ProcessStartInfo()
      {
        Verb = "print",
        CreateNoWindow = true,
        FileName = Filepath,
        WindowStyle = ProcessWindowStyle.Hidden
      };

      Process printProcess = new Process();
      printProcess.StartInfo = printProcessInfo;
      printProcess.Start();

      printProcess.WaitForInputIdle();

      Task.Delay(3000);

      if (false == printProcess.CloseMainWindow())
      {
        printProcess.Kill();
      }
    }

    private void SearchBox_TextChanged(object sender, EventArgs e)
    {
      var query = SearchBox.Text.ToLower();
      if (query.Length > 0)
      {
        FactureLignesGridView.DataSource = items.Where(a => a.Reference.ToLower().Contains(query) ||
                           a.PU.ToString().Contains(query) ||
                           a.Quantite.ToString().Contains(query) ||
                           a.Designation.ToLower().Contains(query)).ToList();
      }
      else
        FactureLignesGridView.DataSource = items;
    }
  }
}
