using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DossierFinal_Debras
{
    public class MyAppParamManager
    {
        private RegistryKey _userKey;

        public MyAppParamManager() { }

        public MyAppParamManager(string userPseudo)
        {
            //Création/Ouverture du dossier "Software"
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("Software");

            //Création/Ouverture du dossier Param de l'application
            RegistryKey SoftwareKey = rk.CreateSubKey("MyBeerManager");

            UserKey = SoftwareKey.CreateSubKey(userPseudo);

        }
        public RegistryKey UserKey { get => _userKey; set => _userKey = value; }

        public SolidColorBrush AppBaseColor
        {
            get
            {
                Color color = (Color)ColorConverter.ConvertFromString((string)UserKey.GetValue("AppBaseColor"));
                return new SolidColorBrush(color);
            }
            set
            {
                UserKey.SetValue("AppBaseColor", value.ToString());
            }
        }

        public int AppBaseWidth
        {
            get
            {
                int Width =(int)UserKey.GetValue("AppBaseWidth");
                return Width;
            }
            set
            {
                UserKey.SetValue("AppBaseWidth", value);
            }
        }
    }
}
