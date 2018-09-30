namespace App1
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
            this.RefTextBlock = new MetroFramework.Controls.MetroLabel();
            this.RefTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionTextBlock = new MetroFramework.Controls.MetroLabel();
            this.DescriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PriceTextBlock = new MetroFramework.Controls.MetroLabel();
            this.PriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // RefTextBlock
            // 
            this.RefTextBlock.AutoSize = true;
            this.RefTextBlock.Location = new System.Drawing.Point(129, 111);
            this.RefTextBlock.Name = "RefTextBlock";
            this.RefTextBlock.Size = new System.Drawing.Size(73, 20);
            this.RefTextBlock.TabIndex = 0;
            this.RefTextBlock.Text = "Reference";
            // 
            // RefTextBox
            // 
            this.RefTextBox.Location = new System.Drawing.Point(234, 108);
            this.RefTextBox.Name = "RefTextBox";
            this.RefTextBox.ReadOnly = true;
            this.RefTextBox.Size = new System.Drawing.Size(484, 23);
            this.RefTextBox.TabIndex = 1;
            this.RefTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // DescriptionTextBlock
            // 
            this.DescriptionTextBlock.AutoSize = true;
            this.DescriptionTextBlock.Location = new System.Drawing.Point(129, 159);
            this.DescriptionTextBlock.Name = "DescriptionTextBlock";
            this.DescriptionTextBlock.Size = new System.Drawing.Size(79, 20);
            this.DescriptionTextBlock.TabIndex = 0;
            this.DescriptionTextBlock.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(234, 156);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(484, 100);
            this.DescriptionTextBox.TabIndex = 1;
            this.DescriptionTextBox.Text = "...";
            this.DescriptionTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // PriceTextBlock
            // 
            this.PriceTextBlock.AutoSize = true;
            this.PriceTextBlock.Location = new System.Drawing.Point(129, 283);
            this.PriceTextBlock.Name = "PriceTextBlock";
            this.PriceTextBlock.Size = new System.Drawing.Size(40, 20);
            this.PriceTextBlock.TabIndex = 0;
            this.PriceTextBlock.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(234, 280);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(484, 23);
            this.PriceTextBox.TabIndex = 1;
            this.PriceTextBox.Text = "0.00";
            this.PriceTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(234, 327);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(484, 45);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Submit";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.RefTextBox);
            this.Controls.Add(this.PriceTextBlock);
            this.Controls.Add(this.DescriptionTextBlock);
            this.Controls.Add(this.RefTextBlock);
            this.MaximizeBox = false;
            this.Name = "Add";
            this.Resizable = false;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel RefTextBlock;
        private MetroFramework.Controls.MetroTextBox RefTextBox;
        private MetroFramework.Controls.MetroLabel DescriptionTextBlock;
        private MetroFramework.Controls.MetroTextBox DescriptionTextBox;
        private MetroFramework.Controls.MetroLabel PriceTextBlock;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private MetroFramework.Controls.MetroTile AddBtn;
    }
}