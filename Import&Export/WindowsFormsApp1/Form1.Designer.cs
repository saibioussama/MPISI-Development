namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBTableName = new System.Windows.Forms.TextBox();
            this.TBDatabaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Databsenamelable = new System.Windows.Forms.Label();
            this.GetDataBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FileOpenBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GetCsvDataBtn = new System.Windows.Forms.Button();
            this.GetExcelData = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "Database",
            "Excel",
            "CSV"});
            this.comboBoxDataType.Location = new System.Drawing.Point(140, 35);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(267, 24);
            this.comboBoxDataType.TabIndex = 1;
            this.comboBoxDataType.Text = "Database";
            this.comboBoxDataType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBTableName);
            this.panel1.Controls.Add(this.TBDatabaseName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Databsenamelable);
            this.panel1.Location = new System.Drawing.Point(21, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 100);
            this.panel1.TabIndex = 3;
            // 
            // TBTableName
            // 
            this.TBTableName.Location = new System.Drawing.Point(119, 58);
            this.TBTableName.Name = "TBTableName";
            this.TBTableName.Size = new System.Drawing.Size(264, 22);
            this.TBTableName.TabIndex = 2;
            // 
            // TBDatabaseName
            // 
            this.TBDatabaseName.Location = new System.Drawing.Point(119, 14);
            this.TBDatabaseName.Name = "TBDatabaseName";
            this.TBDatabaseName.Size = new System.Drawing.Size(264, 22);
            this.TBDatabaseName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table name";
            // 
            // Databsenamelable
            // 
            this.Databsenamelable.AutoSize = true;
            this.Databsenamelable.Location = new System.Drawing.Point(4, 14);
            this.Databsenamelable.Name = "Databsenamelable";
            this.Databsenamelable.Size = new System.Drawing.Size(108, 17);
            this.Databsenamelable.TabIndex = 0;
            this.Databsenamelable.Text = "Database name";
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Location = new System.Drawing.Point(293, 460);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(201, 23);
            this.GetDataBtn.TabIndex = 4;
            this.GetDataBtn.Text = "Get data";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            this.GetDataBtn.Click += new System.EventHandler(this.GetDataBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FileOpenBtn);
            this.panel2.Location = new System.Drawing.Point(21, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 100);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // FileOpenBtn
            // 
            this.FileOpenBtn.Location = new System.Drawing.Point(119, 29);
            this.FileOpenBtn.Name = "FileOpenBtn";
            this.FileOpenBtn.Size = new System.Drawing.Size(264, 23);
            this.FileOpenBtn.TabIndex = 6;
            this.FileOpenBtn.Text = "Choose file";
            this.FileOpenBtn.UseVisualStyleBackColor = true;
            this.FileOpenBtn.Click += new System.EventHandler(this.FileOpenBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GetCsvDataBtn
            // 
            this.GetCsvDataBtn.Location = new System.Drawing.Point(293, 460);
            this.GetCsvDataBtn.Name = "GetCsvDataBtn";
            this.GetCsvDataBtn.Size = new System.Drawing.Size(201, 23);
            this.GetCsvDataBtn.TabIndex = 6;
            this.GetCsvDataBtn.Text = "Get csv data";
            this.GetCsvDataBtn.UseVisualStyleBackColor = true;
            this.GetCsvDataBtn.Visible = false;
            this.GetCsvDataBtn.Click += new System.EventHandler(this.GetCsvDataBtn_Click);
            // 
            // GetExcelData
            // 
            this.GetExcelData.Location = new System.Drawing.Point(293, 460);
            this.GetExcelData.Name = "GetExcelData";
            this.GetExcelData.Size = new System.Drawing.Size(201, 23);
            this.GetExcelData.TabIndex = 6;
            this.GetExcelData.Text = "Get excel data";
            this.GetExcelData.UseVisualStyleBackColor = true;
            this.GetExcelData.Visible = false;
            this.GetExcelData.Click += new System.EventHandler(this.GetExcelData_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(686, 31);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.GetExcelData);
            this.Controls.Add(this.GetCsvDataBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GetDataBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDataType);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBTableName;
        private System.Windows.Forms.TextBox TBDatabaseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Databsenamelable;
        private System.Windows.Forms.Button GetDataBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FileOpenBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button GetCsvDataBtn;
        private System.Windows.Forms.Button GetExcelData;
        private System.Windows.Forms.Button BackBtn;
    }
}

