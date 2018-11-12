using System.Windows.Forms;

namespace ChartUserControls
{
    partial class Chart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
           
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Canvas);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "Chart";
            this.Dock = DockStyle.Fill;
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Resize += new System.EventHandler(this.Chart_Resize);
            this.ResumeLayout(false);
            this.Paint += new PaintEventHandler(this.Canvas_Paint);
        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
    }
}
