using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeerLibrary
{
    [Serializable()]
    public class MyBeerData : INotifyPropertyChanged
    {
        private ObservableCollection<Beer> _BeerCollection;
        private ObservableCollection<Brewery> _BreweryCollection;
        public MyBeerData(ObservableCollection<Beer> beerCollection, ObservableCollection<Brewery> breweryCollection)
        {
            BeerCollection = beerCollection;
            BreweryCollection = breweryCollection;
        }
        public MyBeerData()
        {
            BeerCollection = new ObservableCollection<Beer>();
            BreweryCollection = new ObservableCollection<Brewery>();
        }

        public ObservableCollection<Beer> BeerCollection
        {
            get { return _BeerCollection; }
            set
            {
                if (_BeerCollection != value)
                {
                    _BeerCollection = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Brewery> BreweryCollection
        {
            get { return _BreweryCollection; }
            set
            {
                if (_BreweryCollection != value)
                {
                    _BreweryCollection = value;
                    NotifyPropertyChanged();
                }
            }
        }
        protected void NotifyPropertyChanged([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
