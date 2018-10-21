namespace ArticlesApp.Forms.Shared
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFactures = new MetroFramework.Controls.MetroTile();
            this.BtnArticles = new MetroFramework.Controls.MetroTile();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BtnFactures, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnArticles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSettings, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnFactures
            // 
            this.BtnFactures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFactures.Location = new System.Drawing.Point(400, 143);
            this.BtnFactures.Margin = new System.Windows.Forms.Padding(20);
            this.BtnFactures.Name = "BtnFactures";
            this.BtnFactures.Size = new System.Drawing.Size(340, 83);
            this.BtnFactures.TabIndex = 0;
            this.BtnFactures.Text = "Factures";
            this.BtnFactures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnFactures.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnFactures.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BtnFactures.Click += new System.EventHandler(this.BtnFactures_Click);
            // 
            // BtnArticles
            // 
            this.BtnArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnArticles.Location = new System.Drawing.Point(20, 143);
            this.BtnArticles.Margin = new System.Windows.Forms.Padding(20);
            this.BtnArticles.Name = "BtnArticles";
            this.BtnArticles.Size = new System.Drawing.Size(340, 83);
            this.BtnArticles.TabIndex = 1;
            this.BtnArticles.Text = "Articles";
            this.BtnArticles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnArticles.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnArticles.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BtnArticles.Click += new System.EventHandler(this.BtnArticles_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(670, 280);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(20);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(70, 70);
            this.BtnSettings.TabIndex = 2;
            this.BtnSettings.Text = " ";
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile BtnFactures;
        private MetroFramework.Controls.MetroTile BtnArticles;
        private System.Windows.Forms.Button BtnSettings;
    }
}