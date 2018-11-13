namespace ArticlesApp.Forms.Factures
{
    partial class Details
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
      this.TotalPriceTextBlock = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.SearchLabel = new MetroFramework.Controls.MetroLabel();
      this.SearchBox = new MetroFramework.Controls.MetroTextBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.DateLabel = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.ReferenceLabel = new MetroFramework.Controls.MetroLabel();
      this.FactureLignesGridView = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.CancelBtn = new MetroFramework.Controls.MetroButton();
      this.PrintBtn = new MetroFramework.Controls.MetroTile();
      this.printDocument = new System.Drawing.Printing.PrintDocument();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FactureLignesGridView)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel6.SuspendLayout();
      this.SuspendLayout();
      // 
      // TotalPriceTextBlock
      // 
      this.TotalPriceTextBlock.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.TotalPriceTextBlock.AutoSize = true;
      this.TotalPriceTextBlock.FontWeight = MetroFramework.MetroLabelWeight.Bold;
      this.TotalPriceTextBlock.Location = new System.Drawing.Point(822, 2);
      this.TotalPriceTextBlock.Name = "TotalPriceTextBlock";
      this.TotalPriceTextBlock.Size = new System.Drawing.Size(49, 20);
      this.TotalPriceTextBlock.TabIndex = 11;
      this.TotalPriceTextBlock.Text = "00,00";
      this.TotalPriceTextBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // metroLabel3
      // 
      this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.Location = new System.Drawing.Point(624, 2);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(97, 20);
      this.metroLabel3.TabIndex = 12;
      this.metroLabel3.Text = "Montant total :";
      this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // SearchLabel
      // 
      this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.SearchLabel.AutoSize = true;
      this.SearchLabel.Location = new System.Drawing.Point(3, 12);
      this.SearchLabel.Name = "SearchLabel";
      this.SearchLabel.Size = new System.Drawing.Size(58, 20);
      this.SearchLabel.TabIndex = 6;
      this.SearchLabel.Text = "Search :";
      // 
      // SearchBox
      // 
      this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.SearchBox.Location = new System.Drawing.Point(3, 36);
      this.SearchBox.Name = "SearchBox";
      this.SearchBox.PromptText = "Search...";
      this.SearchBox.Size = new System.Drawing.Size(868, 23);
      this.SearchBox.TabIndex = 4;
      this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.SearchBox, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.SearchLabel, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(43, 183);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(874, 64);
      this.tableLayoutPanel4.TabIndex = 7;
      // 
      // metroLabel2
      // 
      this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.Location = new System.Drawing.Point(3, 12);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(144, 20);
      this.metroLabel2.TabIndex = 0;
      this.metroLabel2.Text = "Date :";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.metroLabel2, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.DateLabel, 1, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(43, 93);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(874, 44);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // DateLabel
      // 
      this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.DateLabel.AutoSize = true;
      this.DateLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
      this.DateLabel.Location = new System.Drawing.Point(153, 22);
      this.DateLabel.Name = "DateLabel";
      this.DateLabel.Size = new System.Drawing.Size(718, 0);
      this.DateLabel.TabIndex = 1;
      this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // metroLabel1
      // 
      this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(3, 12);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(144, 20);
      this.metroLabel1.TabIndex = 1;
      this.metroLabel1.Text = "Reference :";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.ReferenceLabel, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(43, 43);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(874, 44);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // ReferenceLabel
      // 
      this.ReferenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.ReferenceLabel.AutoSize = true;
      this.ReferenceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
      this.ReferenceLabel.Location = new System.Drawing.Point(153, 22);
      this.ReferenceLabel.Name = "ReferenceLabel";
      this.ReferenceLabel.Size = new System.Drawing.Size(718, 0);
      this.ReferenceLabel.TabIndex = 2;
      this.ReferenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // FactureLignesGridView
      // 
      this.FactureLignesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.FactureLignesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FactureLignesGridView.Location = new System.Drawing.Point(43, 253);
      this.FactureLignesGridView.Name = "FactureLignesGridView";
      this.FactureLignesGridView.RowTemplate.Height = 24;
      this.FactureLignesGridView.Size = new System.Drawing.Size(874, 454);
      this.FactureLignesGridView.TabIndex = 8;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.FactureLignesGridView, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 7);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 9);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 10;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 820);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel5.Controls.Add(this.TotalPriceTextBlock, 1, 0);
      this.tableLayoutPanel5.Controls.Add(this.metroLabel3, 0, 0);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(43, 733);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(874, 24);
      this.tableLayoutPanel5.TabIndex = 14;
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.ColumnCount = 3;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel6.Controls.Add(this.CancelBtn, 1, 0);
      this.tableLayoutPanel6.Controls.Add(this.PrintBtn, 2, 0);
      this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel6.Location = new System.Drawing.Point(43, 783);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 1;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(874, 34);
      this.tableLayoutPanel6.TabIndex = 16;
      // 
      // CancelBtn
      // 
      this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CancelBtn.Location = new System.Drawing.Point(677, 3);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(94, 28);
      this.CancelBtn.TabIndex = 15;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
      // 
      // PrintBtn
      // 
      this.PrintBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PrintBtn.Location = new System.Drawing.Point(777, 3);
      this.PrintBtn.Name = "PrintBtn";
      this.PrintBtn.Size = new System.Drawing.Size(94, 28);
      this.PrintBtn.TabIndex = 16;
      this.PrintBtn.Text = "Print";
      this.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.PrintBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
      // 
      // printDocument
      // 
      this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
      // 
      // Details
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1000, 900);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(1000, 700);
      this.Name = "Details";
      this.Text = "Details";
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FactureLignesGridView)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel5.PerformLayout();
      this.tableLayoutPanel6.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel TotalPriceTextBlock;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel SearchLabel;
        private MetroFramework.Controls.MetroTextBox SearchBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel ReferenceLabel;
        private System.Windows.Forms.DataGridView FactureLignesGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel DateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroButton CancelBtn;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private MetroFramework.Controls.MetroTile PrintBtn;
    private System.Drawing.Printing.PrintDocument printDocument;
  }
}