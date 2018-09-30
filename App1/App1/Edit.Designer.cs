namespace App1
{
    partial class Edit
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
            this.EditBtn = new MetroFramework.Controls.MetroTile();
            this.DescriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RefTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PriceTextBlock = new MetroFramework.Controls.MetroLabel();
            this.DescriptionTextBlock = new MetroFramework.Controls.MetroLabel();
            this.RefTextBlock = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(211, 312);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(484, 45);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Update";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(211, 141);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(484, 100);
            this.DescriptionTextBox.TabIndex = 6;
            this.DescriptionTextBox.Text = "...";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(211, 265);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(484, 23);
            this.PriceTextBox.TabIndex = 7;
            this.PriceTextBox.Text = "0.00";
            // 
            // RefTextBox
            // 
            this.RefTextBox.Location = new System.Drawing.Point(211, 93);
            this.RefTextBox.Name = "RefTextBox";
            this.RefTextBox.ReadOnly = true;
            this.RefTextBox.Size = new System.Drawing.Size(484, 23);
            this.RefTextBox.TabIndex = 8;
            // 
            // PriceTextBlock
            // 
            this.PriceTextBlock.AutoSize = true;
            this.PriceTextBlock.Location = new System.Drawing.Point(106, 268);
            this.PriceTextBlock.Name = "PriceTextBlock";
            this.PriceTextBlock.Size = new System.Drawing.Size(40, 20);
            this.PriceTextBlock.TabIndex = 3;
            this.PriceTextBlock.Text = "Price";
            // 
            // DescriptionTextBlock
            // 
            this.DescriptionTextBlock.AutoSize = true;
            this.DescriptionTextBlock.Location = new System.Drawing.Point(106, 144);
            this.DescriptionTextBlock.Name = "DescriptionTextBlock";
            this.DescriptionTextBlock.Size = new System.Drawing.Size(79, 20);
            this.DescriptionTextBlock.TabIndex = 4;
            this.DescriptionTextBlock.Text = "Description";
            // 
            // RefTextBlock
            // 
            this.RefTextBlock.AutoSize = true;
            this.RefTextBlock.Location = new System.Drawing.Point(106, 96);
            this.RefTextBlock.Name = "RefTextBlock";
            this.RefTextBlock.Size = new System.Drawing.Size(73, 20);
            this.RefTextBlock.TabIndex = 5;
            this.RefTextBlock.Text = "Reference";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.RefTextBox);
            this.Controls.Add(this.PriceTextBlock);
            this.Controls.Add(this.DescriptionTextBlock);
            this.Controls.Add(this.RefTextBlock);
            this.MaximizeBox = false;
            this.Name = "Edit";
            this.Resizable = false;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile EditBtn;
        private MetroFramework.Controls.MetroTextBox DescriptionTextBox;
        private MetroFramework.Controls.MetroTextBox PriceTextBox;
        private MetroFramework.Controls.MetroTextBox RefTextBox;
        private MetroFramework.Controls.MetroLabel PriceTextBlock;
        private MetroFramework.Controls.MetroLabel DescriptionTextBlock;
        private MetroFramework.Controls.MetroLabel RefTextBlock;
    }
}