namespace FacturesApp.Forms.Factures
{
  partial class FacturesForm
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
      this.BtnHome = new MetroFramework.Controls.MetroTile();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.FacturesGridView = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.AddBtn = new MetroFramework.Controls.MetroTile();
      this.EditBtn = new MetroFramework.Controls.MetroTile();
      this.RemoveBtn = new MetroFramework.Controls.MetroTile();
      this.DetailsBtn = new MetroFramework.Controls.MetroTile();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.SearchBox = new System.Windows.Forms.TextBox();
      this.RefreshBtn = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FacturesGridView)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // BtnHome
      // 
      this.BtnHome.Location = new System.Drawing.Point(-1, 2);
      this.BtnHome.Name = "BtnHome";
      this.BtnHome.Size = new System.Drawing.Size(99, 23);
      this.BtnHome.TabIndex = 3;
      this.BtnHome.Text = "Home";
      this.BtnHome.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.BtnHome.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
      this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tableLayoutPanel1.Controls.Add(this.FacturesGridView, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // FacturesGridView
      // 
      this.FacturesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.FacturesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FacturesGridView.Location = new System.Drawing.Point(3, 103);
      this.FacturesGridView.Name = "FacturesGridView";
      this.FacturesGridView.RowTemplate.Height = 24;
      this.FacturesGridView.Size = new System.Drawing.Size(594, 614);
      this.FacturesGridView.TabIndex = 1;
      this.FacturesGridView.DataSourceChanged += new System.EventHandler(this.FacturesGridView_DataSourceChanged);
      this.FacturesGridView.SelectionChanged += new System.EventHandler(this.FactureGridView_SelectionChanged);
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.AddBtn, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.EditBtn, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.RemoveBtn, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.DetailsBtn, 0, 3);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(613, 103);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 5;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 614);
      this.tableLayoutPanel2.TabIndex = 2;
      // 
      // AddBtn
      // 
      this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.AddBtn.Location = new System.Drawing.Point(3, 3);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(108, 44);
      this.AddBtn.TabIndex = 0;
      this.AddBtn.Text = "Add";
      this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.AddBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
      this.AddBtn.Click += new System.EventHandler(this.AddFactureBtn_Click);
      // 
      // EditBtn
      // 
      this.EditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EditBtn.Location = new System.Drawing.Point(3, 53);
      this.EditBtn.Name = "EditBtn";
      this.EditBtn.Size = new System.Drawing.Size(108, 44);
      this.EditBtn.TabIndex = 0;
      this.EditBtn.Text = "Edit";
      this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.EditBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
      this.EditBtn.Click += new System.EventHandler(this.EditFactureBtn_Click);
      // 
      // RemoveBtn
      // 
      this.RemoveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.RemoveBtn.Location = new System.Drawing.Point(3, 103);
      this.RemoveBtn.Name = "RemoveBtn";
      this.RemoveBtn.Size = new System.Drawing.Size(108, 44);
      this.RemoveBtn.TabIndex = 0;
      this.RemoveBtn.Text = "Remove";
      this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.RemoveBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
      this.RemoveBtn.Click += new System.EventHandler(this.RemoveFactureBtn_Click);
      // 
      // DetailsBtn
      // 
      this.DetailsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DetailsBtn.Location = new System.Drawing.Point(3, 153);
      this.DetailsBtn.Name = "DetailsBtn";
      this.DetailsBtn.Size = new System.Drawing.Size(108, 44);
      this.DetailsBtn.TabIndex = 1;
      this.DetailsBtn.Text = "Details";
      this.DetailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.DetailsBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
      this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 33);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 17);
      this.label1.TabIndex = 4;
      this.label1.Text = "Search :";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Controls.Add(this.SearchBox, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.RefreshBtn, 1, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(594, 34);
      this.tableLayoutPanel3.TabIndex = 5;
      // 
      // SearchBox
      // 
      this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SearchBox.Location = new System.Drawing.Point(3, 3);
      this.SearchBox.Name = "SearchBox";
      this.SearchBox.Size = new System.Drawing.Size(469, 22);
      this.SearchBox.TabIndex = 0;
      this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
      // 
      // RefreshBtn
      // 
      this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.RefreshBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RefreshBtn.Location = new System.Drawing.Point(478, 3);
      this.RefreshBtn.Name = "RefreshBtn";
      this.RefreshBtn.Size = new System.Drawing.Size(113, 28);
      this.RefreshBtn.TabIndex = 2;
      this.RefreshBtn.Text = "";
      this.RefreshBtn.UseVisualStyleBackColor = true;
      this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
      // 
      // FacturesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.BtnHome);
      this.Name = "FacturesForm";
      this.Text = "Factures";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FacturesGridView)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTile BtnHome;
    public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    public System.Windows.Forms.DataGridView FacturesGridView;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private MetroFramework.Controls.MetroTile AddBtn;
    private MetroFramework.Controls.MetroTile EditBtn;
    private MetroFramework.Controls.MetroTile RemoveBtn;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TextBox SearchBox;
        private MetroFramework.Controls.MetroTile DetailsBtn;
    private System.Windows.Forms.Button RefreshBtn;
  }
}