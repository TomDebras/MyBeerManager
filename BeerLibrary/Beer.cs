using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeerLibrary
{
    [Serializable()]
    public class Beer : INotifyPropertyChanged
    {
        private int _NumberBeer;
        private string _Name;
        private string _Description;
        private string _imagepath;
        private DateTime _ProductionDate;
        private Brewery _brewery;
        #region PROPRIETES
        public int NumberBeer
        {
            get { return _NumberBeer; }
            set
            {
                if(_NumberBeer != value)
                {
                    _NumberBeer = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Brewery Brewery
        {
            get { return _brewery; }
            set
            {
                if (_brewery != value)
                {
                    _brewery = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                if (_Description != value)
                {
                    _Description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime ProductionDate
        {
            get { return _ProductionDate; }
            set
            {
                if (_ProductionDate != value)
                {
                    _ProductionDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ImagePath
        {
            get { return _imagepath; }
            set
            {
                if (_imagepath != value)
                {
                    _imagepath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region CONSTRUCTEURS

        public Beer() : this (0,"","", DateTime.Now, new Brewery(),"") { }
        public Beer(int number, string name,string description, DateTime productiondate,Brewery brewery,string imagePath = "")
        {
            NumberBeer = number;
            Name = name;
            Description = description;
            ProductionDate = productiondate;
            Brewery = brewery;

            if (imagePath == null || imagePath == "")
                ImagePath = @"Images\Default.png";
            else
                ImagePath = imagePath;
        }
        #endregion

        #region METHODES
        public override string ToString()
        {
            return Name;
            //return "Name :" + Name + "Number of beers remaining :" + NumberBeer + "Production date :" + ProductionDate + "Description :" + Description + "Brewery :" + Brewery;
        }

        public void Affiche()
        {
            Console.WriteLine(ToString());
        }
        public void NotifyPropertyChanged([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


    }
}
