using ArticlesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp.Forms.Articles
{
    public partial class SearchForm : MetroFramework.Forms.MetroForm
    {
        Factures home;
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Factures _home)
        {
            InitializeComponent();
            home = _home;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBReference.Text) && !string.IsNullOrWhiteSpace(TBReference.Text))
                home.Articles = home.Articles.Where(a => a.Ref.Contains(TBReference.Text.ToLower())).ToList();
            if (!string.IsNullOrEmpty(TBDescription.Text) && !string.IsNullOrWhiteSpace(TBDescription.Text))
                home.Articles = home.Articles.Where(a => a.Description.ToLower().Contains(TBDescription.Text.ToLower())).ToList();
            if (!string.IsNullOrEmpty(TBQuantity.Text) && !string.IsNullOrWhiteSpace(TBQuantity.Text))
                home.Articles = home.Articles.Where(a => a.Quantity == Convert.ToInt32(TBQuantity.Text)).ToList();
            if (!string.IsNullOrEmpty(TBMaxPrice.Text) && !string.IsNullOrWhiteSpace(TBMinPrice.Text))
                home.Articles = home.Articles.Where(a => a.Price>Convert.ToDouble(TBMinPrice)&& a.Price<Convert.ToDouble(TBMaxPrice.Text)).ToList();
            if (CBInPromotion.Checked)
                home.Articles = home.Articles.Where(a=>a.DateEndPromot>Convert.ToDateTime(DPAfter.Text)&& a.DateEndPromot<Convert.ToDateTime(DPBefore.Text)).ToList();
            home.ArticleGridView.DataSource = home.Articles;
            this.Close();
        }
    }
}
