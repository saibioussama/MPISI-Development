namespace WindowsFormsApp1
{
    partial class main
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
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(115, 189);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(280, 61);
            this.ExportBtn.TabIndex = 0;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(438, 189);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(280, 61);
            this.ImportBtn.TabIndex = 0;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.ExportBtn);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button ImportBtn;
    }
}