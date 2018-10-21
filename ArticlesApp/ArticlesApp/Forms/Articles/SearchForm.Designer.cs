namespace ArticlesApp.Forms.Articles
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBReference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBMinPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBMaxPrice = new System.Windows.Forms.TextBox();
            this.CBInPromotion = new System.Windows.Forms.CheckBox();
            this.DPAfter = new System.Windows.Forms.DateTimePicker();
            this.DPBefore = new System.Windows.Forms.DateTimePicker();
            this.SearchBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // TBReference
            // 
            this.TBReference.Location = new System.Drawing.Point(86, 157);
            this.TBReference.Name = "TBReference";
            this.TBReference.Size = new System.Drawing.Size(275, 22);
            this.TBReference.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // TBDescription
            // 
            this.TBDescription.Location = new System.Drawing.Point(86, 224);
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(275, 22);
            this.TBDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(428, 224);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(275, 22);
            this.TBQuantity.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minimum price";
            // 
            // TBMinPrice
            // 
            this.TBMinPrice.Location = new System.Drawing.Point(86, 298);
            this.TBMinPrice.Name = "TBMinPrice";
            this.TBMinPrice.Size = new System.Drawing.Size(275, 22);
            this.TBMinPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maximum price";
            // 
            // TBMaxPrice
            // 
            this.TBMaxPrice.Location = new System.Drawing.Point(428, 298);
            this.TBMaxPrice.Name = "TBMaxPrice";
            this.TBMaxPrice.Size = new System.Drawing.Size(275, 22);
            this.TBMaxPrice.TabIndex = 1;
            // 
            // CBInPromotion
            // 
            this.CBInPromotion.AutoSize = true;
            this.CBInPromotion.Location = new System.Drawing.Point(86, 364);
            this.CBInPromotion.Name = "CBInPromotion";
            this.CBInPromotion.Size = new System.Drawing.Size(108, 21);
            this.CBInPromotion.TabIndex = 2;
            this.CBInPromotion.Text = "In promotion";
            this.CBInPromotion.UseVisualStyleBackColor = true;
            // 
            // DPAfter
            // 
            this.DPAfter.Enabled = false;
            this.DPAfter.Location = new System.Drawing.Point(86, 426);
            this.DPAfter.Name = "DPAfter";
            this.DPAfter.Size = new System.Drawing.Size(275, 22);
            this.DPAfter.TabIndex = 3;
            // 
            // DPBefore
            // 
            this.DPBefore.Enabled = false;
            this.DPBefore.Location = new System.Drawing.Point(428, 426);
            this.DPBefore.Name = "DPBefore";
            this.DPBefore.Size = new System.Drawing.Size(275, 22);
            this.DPBefore.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(86, 522);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(617, 45);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 610);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DPBefore);
            this.Controls.Add(this.DPAfter);
            this.Controls.Add(this.CBInPromotion);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.TBMaxPrice);
            this.Controls.Add(this.TBMinPrice);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBReference);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBReference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBMinPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBMaxPrice;
        private System.Windows.Forms.CheckBox CBInPromotion;
        private System.Windows.Forms.DateTimePicker DPAfter;
        private System.Windows.Forms.DateTimePicker DPBefore;
        private MetroFramework.Controls.MetroTile SearchBtn;
    }
}