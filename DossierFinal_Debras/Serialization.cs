using BeerLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DossierFinal_Debras
{
    class Serialization
    {
        public static void WriteBeer(String filename, ObservableCollection<Beer> data)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, data);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("write failed: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static ObservableCollection<Beer> ReadBeer(String filename)
        {
            ObservableCollection<Beer> data = null;
            FileStream fs = new FileStream(filename, FileMode.Open);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                data = (ObservableCollection<Beer>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Load failed: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            return data;
        }

        //*******
        //Brewery
        //********

        public static ObservableCollection<Brewery> ReadBrewery(String filename)
        {
            ObservableCollection < Brewery > data = null;
            FileStream fs = new FileStream(filename, FileMode.Open);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                data = (ObservableCollection<Brewery>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Load failed: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            return data;
        }

        public static void WriteBrewery(String filename, ObservableCollection<Brewery> data)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, data);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("write failed: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
