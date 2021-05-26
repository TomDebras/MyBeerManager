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
        public static void WriteMyBeerData(String filename, MyBeerData data)
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

        public static MyBeerData ReadMyBeerData(String filename)
        {
            MyBeerData data = null;
            FileStream fs = new FileStream(filename, FileMode.Open);

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                data = (MyBeerData)formatter.Deserialize(fs);
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
    }
}
