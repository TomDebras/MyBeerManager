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
    /// Interaction logic for SearchBeerWindow.xaml
    /// </summary>
    public partial class SearchBeerWindow : Window
    {
        ObservableCollection<Beer> Liste_beers;
        Beer CurrentBeer;
        public SearchBeerWindow()
        {
            InitializeComponent();
        }
        public SearchBeerWindow(ObservableCollection<Beer> b, Beer Curb)
        {
            InitializeComponent();
            Liste_beers = b;
            CurrentBeer = Curb;
            CB_Beers.ItemsSource = Liste_beers;
            CB_Beers.DataContext = Liste_beers;
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            if (CB_Beers.SelectedIndex == -1 || CB_Beers.SelectedIndex >= Liste_beers.Count)
            {
                LB_Error.Content = "U need to select a beer first !";
            }
            else
            {
                Beer tempBeer = new Beer();
                tempBeer = (Beer)CB_Beers.SelectedItem;
                CurrentBeer.Name = tempBeer.Name;
                CurrentBeer.ImagePath = tempBeer.ImagePath;
                CurrentBeer.Description = tempBeer.Description;
                this.DialogResult = true;
            }
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
