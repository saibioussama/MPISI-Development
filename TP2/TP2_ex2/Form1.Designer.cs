namespace TP2_ex2
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
            this.label1 = new System.Windows.Forms.Label();
            this.int2TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.int1TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultTB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entier 1";
            // 
            // int2TB
            // 
            this.int2TB.Location = new System.Drawing.Point(235, 188);
            this.int2TB.Name = "int2TB";
            this.int2TB.Size = new System.Drawing.Size(162, 22);
            this.int2TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entier 2";
            // 
            // int1TB
            // 
            this.int1TB.Location = new System.Drawing.Point(235, 106);
            this.int1TB.Name = "int1TB";
            this.int1TB.Size = new System.Drawing.Size(162, 22);
            this.int1TB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(530, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.AutoSize = true;
            this.ResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTB.Location = new System.Drawing.Point(169, 337);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(154, 42);
            this.ResultTB.TabIndex = 3;
            this.ResultTB.Text = "Result : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.int1TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.int2TB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox int2TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox int1TB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultTB;
    }
}

