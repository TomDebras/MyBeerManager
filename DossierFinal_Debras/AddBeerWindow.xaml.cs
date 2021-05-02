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
    /// Interaction logic for AddBeerWindow.xaml
    /// </summary>
    public partial class AddBeerWindow : Window
    {
        ObservableCollection<Beer> Liste_beers;
        ObservableCollection<Brewery> Liste_brewery;
        Beer CurrentBeer = new Beer();
        int i;
        public AddBeerWindow()
        {
            InitializeComponent();
        }

        public AddBeerWindow(ObservableCollection<Beer> b , ObservableCollection<Brewery> Br )
        {
            InitializeComponent();
            Button_Modify.Visibility = Visibility.Collapsed;
            Liste_beers = b;
            Liste_brewery = Br;
            Applic_Grid.DataContext = CurrentBeer;
            CB_Brewery.ItemsSource = Liste_brewery;
            CB_Brewery.DataContext = Liste_brewery;
        }
        public AddBeerWindow(ObservableCollection<Beer> b, ObservableCollection<Brewery> Br, Beer Curb)
        {
            InitializeComponent();
            TB_Name.IsReadOnly = true;
            Button_Add.Visibility = Visibility.Collapsed;
            Liste_beers = b;
            Liste_brewery = Br;
            CurrentBeer = Curb;
            CB_Brewery.SelectedIndex = FindIndex();
            Applic_Grid.DataContext = CurrentBeer;
            CB_Brewery.ItemsSource = Liste_brewery;
            CB_Brewery.DataContext = Liste_brewery;
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            bool cond = false;
            foreach(Beer item in Liste_beers)
            {
                if(item.Name.Equals(CurrentBeer.Name))
                {
                    cond = true;
                    LB_Error.Content = "Beer already existing !!";
                    break;
                }
            }
            if(CB_Brewery.SelectedIndex == -1)
            {
                LB_Error.Content = "U need to choose a brewery !!";
                cond = true;
            }

            if (!Int32.TryParse(TB_Number.Text, out _))
            {
                LB_Error.Content = "Number plz !!";
                cond = true;
            }

            if(!cond)
            {
                CurrentBeer.Brewery = (Brewery)CB_Brewery.SelectedItem;
                Liste_beers.Add(CurrentBeer);
                this.DialogResult = true;
            }
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private int FindIndex()
        {
            foreach(Brewery item in Liste_brewery)
            {
                if(item.Equals(CurrentBeer.Brewery))
                {
                    return i;
                }
                i++;
            }
            return 0;
        }

        private void Button_Modify_Click(object sender, RoutedEventArgs e)
        {
            bool cond = false;

            if (CB_Brewery.SelectedIndex == -1)
            {
                LB_Error.Content = "U need to choose a brewery !!";
                cond = true;
            }

            if (!Int32.TryParse(TB_Number.Text, out _))
            {
                LB_Error.Content = "Number plz !!";
                cond = true;
            }
            if(!cond)
            {
                CurrentBeer.Brewery = (Brewery)CB_Brewery.SelectedItem;
                this.DialogResult = true;
            }
        }
    }
}
