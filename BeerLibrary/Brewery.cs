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
    public class Brewery : INotifyPropertyChanged
    {
        private string _Name;
        public Brewery() : this("") { }
   
        public Brewery(string name)
        {
            Name = name;
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
        public override string ToString()
        {
            return Name;
        }

        public void Affiche()
        {
            Console.WriteLine(ToString());
        }
        protected void NotifyPropertyChanged([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
