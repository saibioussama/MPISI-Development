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
      var list = new List<Article>(home.Articles);
      if (!string.IsNullOrEmpty(TBReference.Text) && !string.IsNullOrWhiteSpace(TBReference.Text))
        list = home.Articles.Where(a => a.Reference.ToLower().Contains(TBReference.Text.ToLower())).ToList();
      if (!string.IsNullOrEmpty(TBDescription.Text) && !string.IsNullOrWhiteSpace(TBDescription.Text))
        list = home.Articles.Where(a => a.Designation.ToLower().Contains(TBDescription.Text.ToLower())).ToList();
      if (!string.IsNullOrEmpty(TBQuantity.Text) && !string.IsNullOrWhiteSpace(TBQuantity.Text))
        list = home.Articles.Where(a => a.Quantite == Convert.ToInt32(TBQuantity.Text)).ToList();
      if (!string.IsNullOrEmpty(TBMaxPrice.Text) && !string.IsNullOrWhiteSpace(TBMaxPrice.Text))
      {
        float max = 0;
        float.TryParse(TBMaxPrice.Text, out max);
        list = home.Articles.Where(a => a.Prix < max).ToList();
      }
      if (!string.IsNullOrEmpty(TBMinPrice.Text) &&  !string.IsNullOrWhiteSpace(TBMinPrice.Text))
      {
        float min = 0;
        float.TryParse(TBMinPrice.Text, out min);
        list = home.Articles.Where(a => a.Prix > min).ToList();
      }
      if (CBInPromotion.Checked)
        list = home.Articles.Where(a => a.DateFinPromo > Convert.ToDateTime(DPAfter.Text) && a.DateFinPromo < Convert.ToDateTime(DPBefore.Text)).ToList();
      home.ArticleGridView.DataSource = list;
      this.Close();
    }

    private void CBInPromotion_CheckedChanged(object sender, EventArgs e)
    {
      if (CBInPromotion.Checked)
      {
        DPAfter.Enabled = true;
        DPBefore.Enabled = true;
      }
      else
      {
        DPAfter.Enabled = false;
        DPBefore.Enabled = false;
      }
    }
  }
}
