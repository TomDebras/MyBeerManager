﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DossierFinal_Debras
{
    /// <summary>
    /// Interaction logic for WindowOption.xaml
    /// </summary>
    public partial class WindowOption : Window
    {

        public OptionWindow OptWin;

        public WindowOption()
        {
            InitializeComponent();
        }
        public WindowOption(OptionWindow e )
        {
            InitializeComponent();
            OptWin = e;
            TB_Red.Text = e.R.ToString();
            TB_Green.Text = e.G.ToString();
            TB_Blue.Text = e.B.ToString();
            TB_Size.Text = e.Width.ToString();
        }

        private void Button_Apply_Click(object sender, RoutedEventArgs e)
        {
            OptWin.R = Convert.ToInt32(TB_Red.Text);
            OptWin.G = Convert.ToInt32(TB_Green.Text);
            OptWin.B = Convert.ToInt32(TB_Blue.Text);
            OptWin.Width = Convert.ToInt32(TB_Size.Text);
            this.DialogResult = true;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
