using ArticlesApp.Forms.Articles;
using ArticlesApp.Forms.Factures;
using FacturesApp.Forms.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp.Forms.Shared
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnArticles_Click(object sender, EventArgs e)
        {
            Articles.Factures articlesForm = new Articles.Factures(this);
            articlesForm.Show();
            this.Hide();
        }

        private void BtnFactures_Click(object sender, EventArgs e)
        {
            FacturesForm factures = new FacturesForm(this);
            factures.Show();
            this.Hide();
        }
    }
}
