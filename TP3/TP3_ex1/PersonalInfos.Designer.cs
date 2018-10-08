namespace TP3_ex1
{
    partial class PersonalInfos
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
            this.VilleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdresseTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrenomTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VilleComboBox
            // 
            this.VilleComboBox.FormattingEnabled = true;
            this.VilleComboBox.Items.AddRange(new object[] {
            "Sousse",
            "Monastir",
            "Mahdia"});
            this.VilleComboBox.Location = new System.Drawing.Point(130, 122);
            this.VilleComboBox.Name = "VilleComboBox";
            this.VilleComboBox.Size = new System.Drawing.Size(211, 24);
            this.VilleComboBox.TabIndex = 0;
            this.VilleComboBox.Text = "sousse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ville :";
            // 
            // AdresseTB
            // 
            this.AdresseTB.Location = new System.Drawing.Point(130, 94);
            this.AdresseTB.Name = "AdresseTB";
            this.AdresseTB.Size = new System.Drawing.Size(211, 22);
            this.AdresseTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresse : ";
            // 
            // PrenomTB
            // 
            this.PrenomTB.Location = new System.Drawing.Point(130, 66);
            this.PrenomTB.Name = "PrenomTB";
            this.PrenomTB.Size = new System.Drawing.Size(211, 22);
            this.PrenomTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prénom :";
            // 
            // NomTB
            // 
            this.NomTB.Location = new System.Drawing.Point(130, 38);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(211, 22);
            this.NomTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VilleComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AdresseTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PrenomTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NomTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations personnelles  ";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(33, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Précédent";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(163, 228);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(125, 33);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Suivant";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(294, 228);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 33);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Annuler";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PersonalInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 303);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonalInfos";
            this.Text = "PersonalInfos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox VilleComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdresseTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrenomTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}