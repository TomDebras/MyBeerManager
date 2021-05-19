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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DossierFinal_Debras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OptionWindow OptWin = new OptionWindow();
        MyBeerData MyCollection = new MyBeerData();
        Beer CurrentBeer = new Beer();
        MyAppParamManager AppManager = new MyAppParamManager("AppBaseParam");

        public MainWindow()
        {
            InitializeComponent();
            #region Brewery && Beer
            //Brewery TKBrewery = new Brewery("Triple Karmeleit Brewery");
            //Brewery LeffeBrewery = new Brewery("Leffe Brewery");
            //Brewery RochefortBrewery = new Brewery("Rochefort Brewery");
            //Brewery JupilerBrewery = new Brewery("Jupiler Brewery");
            //Brewery ChimayBrewery = new Brewery("Chimay Brewery");
            //Brewery CuveeBrewery = new Brewery("Cuvee Brewery");
            //Brewery DeliriumBrewery = new Brewery("Delirium Brewery");
            //Brewery DuvelBrewery = new Brewery("Duvel Brewery");
            //Brewery KasteelBrewery = new Brewery("Kasteel Brewery");
            //Brewery KwakBrewery = new Brewery("Kwak Brewery");
            //Brewery LiefmansBrewery = new Brewery("Liefmans Brewery");
            //Brewery LupulusBrewery = new Brewery("Lupulus Brewery");
            //Brewery LindermansBrewery = new Brewery("Lindermans Brewery");
            //Brewery WestmalleBrewery = new Brewery("Westmalle Brewery");
            //Brewery ValDieuBrewery = new Brewery("ValDieu Brewery");

            //MyCollection.BreweryCollection.Add(TKBrewery);
            //MyCollection.BreweryCollection.Add(LeffeBrewery);
            //MyCollection.BreweryCollection.Add(RochefortBrewery);
            //MyCollection.BreweryCollection.Add(JupilerBrewery);
            //MyCollection.BreweryCollection.Add(ChimayBrewery);
            //MyCollection.BreweryCollection.Add(CuveeBrewery);
            //MyCollection.BreweryCollection.Add(DeliriumBrewery);
            //MyCollection.BreweryCollection.Add(DuvelBrewery);
            //MyCollection.BreweryCollection.Add(KasteelBrewery);
            //MyCollection.BreweryCollection.Add(KwakBrewery);
            //MyCollection.BreweryCollection.Add(LiefmansBrewery);
            //MyCollection.BreweryCollection.Add(LupulusBrewery);
            //MyCollection.BreweryCollection.Add(LindermansBrewery);
            //MyCollection.BreweryCollection.Add(WestmalleBrewery);
            //MyCollection.BreweryCollection.Add(ValDieuBrewery);


            //MyCollection.BeerCollection.Add(new Beer(10, "Triple Karmeleit", "8% blond beer", new DateTime(2001, 9, 14), TKBrewery, @"Images\TripleKarmeleit.png"));
            //MyCollection.BeerCollection.Add(new Beer(24, "Leffe Blonde", "7% blond beer", new DateTime(2002, 3, 11), LeffeBrewery, @"Images\LeffeBlonde.png"));
            //MyCollection.BeerCollection.Add(new Beer(20, "Leffe Rituel", "8% blond beer", new DateTime(2006, 6, 10), LeffeBrewery, @"Images\LeffeRituel.png"));
            //MyCollection.BeerCollection.Add(new Beer(5, "Trappiste Rochefort 10", "10% Dark beer", new DateTime(2001, 1, 10), RochefortBrewery, @"Images\Rochefort10.png"));
            //MyCollection.BeerCollection.Add(new Beer(100, "Trappiste Rochefort 8", "8% Dark beer", new DateTime(2002, 6, 18), RochefortBrewery, @"Images\Rochefort8.png"));
            //MyCollection.BeerCollection.Add(new Beer(34, "Trappiste Rochefort 6", "6% Dark beer", new DateTime(2003, 3, 12), RochefortBrewery, @"Images\Rochefort6.png"));
            //MyCollection.BeerCollection.Add(new Beer(24, "Jupiler", "5,2% blond beer", new DateTime(2000, 12, 3), JupilerBrewery, @"Images\Jupiler.png"));
            //MyCollection.BeerCollection.Add(new Beer(90, "Chimay Bleue", "8% dark beer", new DateTime(1990, 11, 8), ChimayBrewery, @"Images\ChimayBleue.png"));
            //MyCollection.BeerCollection.Add(new Beer(8, "Cuvee des trolls", "6,7% blond beer", new DateTime(2002, 7, 22), CuveeBrewery, @"Images\CuveeDesTrolls.png"));
            //MyCollection.BeerCollection.Add(new Beer(14, "Delirium", "9% blond beer", new DateTime(2010, 8, 19), DeliriumBrewery, @"Images\delirium.png"));
            //MyCollection.BeerCollection.Add(new Beer(56, "Duvel", "8,3% blond beer", new DateTime(2000, 8, 11), DuvelBrewery, @"Images\Duvel.png"));
            //MyCollection.BeerCollection.Add(new Beer(67, "Kasteel Red", "8% Fruit beer", new DateTime(2006, 8, 11), KasteelBrewery, @"Images\KasteelRed.png"));
            //MyCollection.BeerCollection.Add(new Beer(200, "Kwak", "6,2% Blond beer", new DateTime(2004, 12, 9), KwakBrewery, @"Images\Kwak.png"));
            //MyCollection.BeerCollection.Add(new Beer(22, "Liefmans", "3,4% Fruit beer", new DateTime(2001, 12, 9), LiefmansBrewery, @"Images\liefmans.png"));
            //MyCollection.BeerCollection.Add(new Beer(400, "Lindermans Kriek", "3,8% Fruit beer", new DateTime(2009, 9, 10), LindermansBrewery, @"Images\lindemansKriek.png"));
            //MyCollection.BeerCollection.Add(new Beer(42, "Lupulus", "7,5% Blond beer", new DateTime(2005, 4, 10), LupulusBrewery, @"Images\Lupulus.png"));
            //MyCollection.BeerCollection.Add(new Beer(42, "Triple Westmalle", "12% Blond beer", new DateTime(2009, 2, 10), WestmalleBrewery, @"Images\TripleWestmalle.png"));
            //MyCollection.BeerCollection.Add(new Beer(42, "ValDieu", "9% Blond beer", new DateTime(2007, 6, 16), ValDieuBrewery, @"Images\ValDieu.png"));

            //Serialization.WriteMyBeerData("MyBeerDataFile", MyCollection);

            #endregion
            MyCollection = Serialization.ReadMyBeerData("MyBeerDataFile");
            Application.Current.MainWindow.Background = AppManager.AppBaseColor;
            DG_Beers.ItemsSource = MyCollection.BeerCollection;
            DG_Beers.DataContext = MyCollection.BeerCollection;
            Search_Grid.DataContext = CurrentBeer;
            OptWin.R = AppManager.AppBaseColor.Color.R;
            OptWin.G = AppManager.AppBaseColor.Color.G;
            OptWin.B = AppManager.AppBaseColor.Color.B;
            OptWin.Width = AppManager.AppBaseWidth;
        }

        private void Button_WindowOption_Click(object sender, RoutedEventArgs e)
        {
            WindowOption W = new WindowOption(OptWin);
            W.Owner = this;
            W.ShowDialog();
            if (W.DialogResult == true)
            {
                SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, (byte)OptWin.R, (byte)OptWin.G, (byte)OptWin.B));
                Application.Current.MainWindow.Background = brush;
                DG_Beers.Background = brush;
                Top_Grid.Background = brush;
                Application.Current.MainWindow.Width = OptWin.Width;
            }
        }

        private void Button_AddBeers_Click(object sender, RoutedEventArgs e)
        {
            Button_reset_Click(sender, e);
            AddBeerWindow W = new AddBeerWindow(MyCollection.BeerCollection,MyCollection.BreweryCollection);
            W.ShowDialog();
        }

        private void Button_Modify_Click(object sender, RoutedEventArgs e)
        {
            if(DG_Beers.IsVisible)
            {
                if (MyCollection.BeerCollection.Count > DG_Beers.SelectedIndex && DG_Beers.SelectedIndex != -1)
                {
                    Beer CurentBeer = new Beer();
                    CurentBeer =(Beer)DG_Beers.SelectedItem;
                    AddBeerWindow W = new AddBeerWindow(MyCollection.BeerCollection, MyCollection.BreweryCollection, CurentBeer);
                    W.ShowDialog();
                }
            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DG_Beers.IsVisible)
            {
               if (MyCollection.BeerCollection.Count > DG_Beers.SelectedIndex && DG_Beers.SelectedIndex != -1)
                {
                     MyCollection.BeerCollection.RemoveAt(DG_Beers.SelectedIndex);
                }
            }

        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            SearchBeerWindow w = new SearchBeerWindow(MyCollection.BeerCollection, CurrentBeer);
            w.ShowDialog();
            if(w.DialogResult == true)
            {
                DG_Beers.Visibility = Visibility.Collapsed;
                BorderBeer.Visibility = Visibility.Visible;
                LB_NameBeer.Visibility = Visibility.Visible;
                LB_DescriptionBeer.Visibility = Visibility.Visible;
                IM_Beer.Visibility = Visibility.Visible;
                Search_Grid.DataContext = CurrentBeer;
            }
        }

        private void Button_reset_Click(object sender, RoutedEventArgs e)
        {
            DG_Beers.Visibility = Visibility.Visible;
            BorderBeer.Visibility = Visibility.Collapsed;
            LB_NameBeer.Visibility = Visibility.Collapsed;
            IM_Beer.Visibility = Visibility.Collapsed;
            LB_DescriptionBeer.Visibility = Visibility.Collapsed;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Serialization.WriteBeer("BeerFile", MyCollection.BeerCollection);
            //Serialization.WriteBrewery("BreweryFile", MyCollection.BreweryCollection);
            Serialization.WriteMyBeerData("MyBeerDataFile", MyCollection);
        }

        private void Button_AddBrewery_Click(object sender, RoutedEventArgs e)
        {
            Button_reset_Click(sender, e);
            AddBreweryWindow W = new AddBreweryWindow(MyCollection.BreweryCollection);
            W.ShowDialog();
        }
    }
}
