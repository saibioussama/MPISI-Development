﻿using FacturesApp.Forms.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticlesApp.Forms.Factures
{
  public partial class SearchForm : MetroFramework.Forms.MetroForm
  {
    public SearchForm()
    {
      InitializeComponent();
    }

    public SearchForm(FacturesForm factures)
    {
      InitializeComponent();
    }
  }
}