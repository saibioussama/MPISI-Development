namespace WindowsFormsApp1
{
    partial class Import
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DataSourceCombobox = new MetroFramework.Controls.MetroComboBox();
            this.DatabasePanel = new MetroFramework.Controls.MetroPanel();
            this.ExcelPanel = new MetroFramework.Controls.MetroPanel();
            this.LibraryBtn = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.DatabasePanel.SuspendLayout();
            this.ExcelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DatabasePanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 555);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DataSourceCombobox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1030, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(303, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Data source";
            // 
            // DataSourceCombobox
            // 
            this.DataSourceCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSourceCombobox.FormattingEnabled = true;
            this.DataSourceCombobox.ItemHeight = 24;
            this.DataSourceCombobox.Items.AddRange(new object[] {
            "Database",
            "Excel",
            "CSV"});
            this.DataSourceCombobox.Location = new System.Drawing.Point(312, 3);
            this.DataSourceCombobox.Name = "DataSourceCombobox";
            this.DataSourceCombobox.Size = new System.Drawing.Size(715, 30);
            this.DataSourceCombobox.TabIndex = 1;
            this.DataSourceCombobox.UseSelectable = true;
            // 
            // DatabasePanel
            // 
            this.DatabasePanel.Controls.Add(this.ExcelPanel);
            this.DatabasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabasePanel.HorizontalScrollbarBarColor = true;
            this.DatabasePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DatabasePanel.HorizontalScrollbarSize = 10;
            this.DatabasePanel.Location = new System.Drawing.Point(3, 63);
            this.DatabasePanel.Name = "DatabasePanel";
            this.DatabasePanel.Size = new System.Drawing.Size(1030, 94);
            this.DatabasePanel.TabIndex = 1;
            this.DatabasePanel.VerticalScrollbarBarColor = true;
            this.DatabasePanel.VerticalScrollbarHighlightOnWheel = false;
            this.DatabasePanel.VerticalScrollbarSize = 10;
            this.DatabasePanel.Visible = false;
            // 
            // ExcelPanel
            // 
            this.ExcelPanel.Controls.Add(this.LibraryBtn);
            this.ExcelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcelPanel.HorizontalScrollbarBarColor = true;
            this.ExcelPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ExcelPanel.HorizontalScrollbarSize = 10;
            this.ExcelPanel.Location = new System.Drawing.Point(0, 0);
            this.ExcelPanel.Name = "ExcelPanel";
            this.ExcelPanel.Size = new System.Drawing.Size(1030, 94);
            this.ExcelPanel.TabIndex = 2;
            this.ExcelPanel.VerticalScrollbarBarColor = true;
            this.ExcelPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ExcelPanel.VerticalScrollbarSize = 10;
            // 
            // LibraryBtn
            // 
            this.LibraryBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LibraryBtn.Location = new System.Drawing.Point(339, 39);
            this.LibraryBtn.Name = "LibraryBtn";
            this.LibraryBtn.Size = new System.Drawing.Size(317, 23);
            this.LibraryBtn.TabIndex = 2;
            this.LibraryBtn.Text = "Choose file";
            this.LibraryBtn.UseSelectable = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Import";
            this.Text = "Import";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.DatabasePanel.ResumeLayout(false);
            this.ExcelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox DataSourceCombobox;
        private MetroFramework.Controls.MetroPanel DatabasePanel;
        private MetroFramework.Controls.MetroPanel ExcelPanel;
        private MetroFramework.Controls.MetroButton LibraryBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}