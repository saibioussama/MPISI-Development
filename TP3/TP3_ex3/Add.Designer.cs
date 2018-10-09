namespace TP3_ex3
{
    partial class Add
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.Entier1TB = new System.Windows.Forms.TextBox();
            this.Entier2TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(233, 332);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(299, 49);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Resultat";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Entier1TB
            // 
            this.Entier1TB.Location = new System.Drawing.Point(317, 95);
            this.Entier1TB.Name = "Entier1TB";
            this.Entier1TB.Size = new System.Drawing.Size(240, 22);
            this.Entier1TB.TabIndex = 1;
            // 
            // Entier2TB
            // 
            this.Entier2TB.Location = new System.Drawing.Point(317, 179);
            this.Entier2TB.Name = "Entier2TB";
            this.Entier2TB.Size = new System.Drawing.Size(240, 22);
            this.Entier2TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entier 1";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(214, 183);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(57, 17);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Entier 2";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entier2TB);
            this.Controls.Add(this.Entier1TB);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox Entier1TB;
        private System.Windows.Forms.TextBox Entier2TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
    }
}