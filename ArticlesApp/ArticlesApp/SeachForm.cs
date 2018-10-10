using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp
{
    public partial class SeachForm : MetroFramework.Forms.MetroForm
    {
        Home home;
        
        public SeachForm()
        {
            InitializeComponent();
        }

        public SeachForm(Home _home)
        {
            InitializeComponent();
            home = _home;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            home.ArticleGridView.DataSource = home.Articles.Where(a => a.Ref.Contains(ReferenceTextBox.Text.ToLower()) &&
                                                                       a.Description.Contains(DescriptionTextBox.Text.ToLower()) &&
                                                                       a.IsInPromot.Value == PromotionCheckBox.Checked);
            this.Hide();
        }

        private void PromotionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EndPromotionPicker1.Enabled = PromotionCheckBox.Checked;
            EndPromotionPicker2.Enabled = PromotionCheckBox.Checked;
        }
    }
}
