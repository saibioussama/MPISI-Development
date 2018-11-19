namespace ArticlesApp.Forms.Factures
{
  partial class PrintForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
      this.FactureLigneViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.FactureLigneViewModelBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // ReportViewer
      // 
      this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ReportViewer.LocalReport.ReportEmbeddedResource = "ArticlesApp.Forms.Factures.FactureReport.rdlc";
      this.ReportViewer.Location = new System.Drawing.Point(20, 60);
      this.ReportViewer.Name = "ReportViewer";
      this.ReportViewer.ServerReport.BearerToken = null;
      this.ReportViewer.Size = new System.Drawing.Size(760, 370);
      this.ReportViewer.TabIndex = 0;
      this.ReportViewer.Load += new System.EventHandler(this.PrintForm_Load);
      // 
      // FactureLigneViewModelBindingSource
      // 
      this.FactureLigneViewModelBindingSource.DataSource = typeof(ArticlesApp.Models.ViewModels.FactureLigneViewModel);
      // 
      // PrintForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ReportViewer);
      this.MinimizeBox = false;
      this.Name = "PrintForm";
      this.Text = "Print";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.FactureLigneViewModelBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
    private System.Windows.Forms.BindingSource FactureLigneViewModelBindingSource;
  }
}