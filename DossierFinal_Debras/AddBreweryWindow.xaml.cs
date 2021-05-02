using BeerLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AddBreweryWindow.xaml
    /// </summary>
    public partial class AddBreweryWindow : Window
    {
        ObservableCollection<Brewery> Liste_brewery;
        Brewery CurrentBrewery;
        public AddBreweryWindow()
        {
            InitializeComponent();
        }
        public AddBreweryWindow(ObservableCollection<Brewery> lb)
        {
            InitializeComponent();
            CurrentBrewery = new Brewery();
            Liste_brewery = lb;
            TB_Brewery.DataContext = CurrentBrewery;
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            foreach(Brewery item in Liste_brewery)
            {
                if(CurrentBrewery.Name.Equals(item.Name))
                {
                    cond = true;
                    LB_Error.Content = "Brewery already existing !";
                    break;
                }
            }
            if(!cond)
            {
                Liste_brewery.Add(CurrentBrewery);
                this.DialogResult = true;
            }
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
