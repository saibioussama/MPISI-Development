namespace ArticlesApp
{
    partial class SeachForm
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
            this.SearchBtn = new MetroFramework.Controls.MetroTile();
            this.ReferenceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EndPromotionPicker1 = new System.Windows.Forms.DateTimePicker();
            this.EndPromotionPicker2 = new System.Windows.Forms.DateTimePicker();
            this.PromotionCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(60, 315);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(488, 37);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search ";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ReferenceTextBox
            // 
            this.ReferenceTextBox.Location = new System.Drawing.Point(60, 94);
            this.ReferenceTextBox.Name = "ReferenceTextBox";
            this.ReferenceTextBox.PromptText = "Reference...";
            this.ReferenceTextBox.Text = "";
            this.ReferenceTextBox.Size = new System.Drawing.Size(218, 23);
            this.ReferenceTextBox.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(60, 145);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Text = "";

            this.DescriptionTextBox.PromptText = "Description...";
            this.DescriptionTextBox.Size = new System.Drawing.Size(488, 23);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(60, 199);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Text = "";

            this.PriceTextBox.PromptText = "Price...";
            this.PriceTextBox.Size = new System.Drawing.Size(218, 23);
            this.PriceTextBox.TabIndex = 3;
            // 
            // EndPromotionPicker1
            // 
            this.EndPromotionPicker1.Enabled = false;
            this.EndPromotionPicker1.Location = new System.Drawing.Point(60, 256);
            this.EndPromotionPicker1.Name = "EndPromotionPicker1";
            this.EndPromotionPicker1.Size = new System.Drawing.Size(200, 22);
            this.EndPromotionPicker1.TabIndex = 4;
            // 
            // EndPromotionPicker2
            // 
            this.EndPromotionPicker2.Enabled = false;
            this.EndPromotionPicker2.Location = new System.Drawing.Point(348, 256);
            this.EndPromotionPicker2.Name = "EndPromotionPicker2";
            this.EndPromotionPicker2.Size = new System.Drawing.Size(200, 22);
            this.EndPromotionPicker2.TabIndex = 4;
            // 
            // PromotionCheckBox
            // 
            this.PromotionCheckBox.AutoSize = true;
            this.PromotionCheckBox.Location = new System.Drawing.Point(348, 200);
            this.PromotionCheckBox.Name = "PromotionCheckBox";
            this.PromotionCheckBox.Size = new System.Drawing.Size(94, 21);
            this.PromotionCheckBox.TabIndex = 5;
            this.PromotionCheckBox.Text = "Promotion";
            this.PromotionCheckBox.UseVisualStyleBackColor = true;
            this.PromotionCheckBox.CheckedChanged += new System.EventHandler(this.PromotionCheckBox_CheckedChanged);
            // 
            // SeachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 375);
            this.Controls.Add(this.PromotionCheckBox);
            this.Controls.Add(this.EndPromotionPicker2);
            this.Controls.Add(this.EndPromotionPicker1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ReferenceTextBox);
            this.Controls.Add(this.SearchBtn);
            this.Name = "SeachForm";
            this.Text = "Seach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile SearchBtn;
        private MetroFramework.Controls.MetroTextBox ReferenceTextBox;
        private MetroFramework.Controls.MetroTextBox DescriptionTextBox;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private System.Windows.Forms.DateTimePicker EndPromotionPicker1;
        private System.Windows.Forms.DateTimePicker EndPromotionPicker2;
        private System.Windows.Forms.CheckBox PromotionCheckBox;
    }
}