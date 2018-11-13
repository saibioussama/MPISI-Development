using ArticlesApp.Models;
using ArticlesApp.Models.ViewModels;
using Microsoft.Reporting.WinForms;
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
  public partial class PrintForm : MetroFramework.Forms.MetroForm
  {

    private List<FactureLigneViewModel> items;
    private Facture facture;


    public PrintForm(List<FactureLigneViewModel> factureLignes, Facture facture)
    {
      InitializeComponent();
      items = factureLignes;
      this.facture = facture;
    }

    private void PrintForm_Load(object sender, EventArgs e)
    {
      FactureLigneViewModelBindingSource.DataSource = items;
      List<ReportParameter> parameters = new List<ReportParameter>()
      {
        new ReportParameter("FactureReference",facture.Reference),
        new ReportParameter("FactureDate",facture.Date.ToShortDateString()),
        new ReportParameter("FactureTotal",facture.Total.ToString()),
      };
      this.ReportViewer.LocalReport.SetParameters(parameters);
      this.ReportViewer.RefreshReport();
    }
  
  }
}
