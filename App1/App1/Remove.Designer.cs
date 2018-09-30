namespace App1
{
    partial class Remove
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ReferenceLable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DescriptionLable = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.PriceLable = new MetroFramework.Controls.MetroLabel();
            this.RemoveBtn = new MetroFramework.Controls.MetroTile();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(294, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Are you sure you want to remove this article ?";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 175);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Reference";
            // 
            // ReferenceLable
            // 
            this.ReferenceLable.AutoSize = true;
            this.ReferenceLable.Location = new System.Drawing.Point(230, 175);
            this.ReferenceLable.Name = "ReferenceLable";
            this.ReferenceLable.Size = new System.Drawing.Size(87, 20);
            this.ReferenceLable.TabIndex = 2;
            this.ReferenceLable.Text = "metroLabel3";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 20);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Description";
            // 
            // DescriptionLable
            // 
            this.DescriptionLable.AutoSize = true;
            this.DescriptionLable.Location = new System.Drawing.Point(230, 221);
            this.DescriptionLable.Name = "DescriptionLable";
            this.DescriptionLable.Size = new System.Drawing.Size(87, 20);
            this.DescriptionLable.TabIndex = 2;
            this.DescriptionLable.Text = "metroLabel3";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(24, 267);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 20);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Price";
            // 
            // PriceLable
            // 
            this.PriceLable.AutoSize = true;
            this.PriceLable.Location = new System.Drawing.Point(230, 267);
            this.PriceLable.Name = "PriceLable";
            this.PriceLable.Size = new System.Drawing.Size(87, 20);
            this.PriceLable.TabIndex = 2;
            this.PriceLable.Text = "metroLabel3";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(24, 364);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(173, 33);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(230, 364);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(99, 33);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.PriceLable);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.DescriptionLable);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.ReferenceLable);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Remove";
            this.Resizable = false;
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel ReferenceLable;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel DescriptionLable;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel PriceLable;
        private MetroFramework.Controls.MetroTile RemoveBtn;
        private MetroFramework.Controls.MetroButton CancelBtn;
    }
}