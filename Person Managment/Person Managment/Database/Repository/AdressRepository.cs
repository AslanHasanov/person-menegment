using Person_Managment.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Managment.DataBase.Repository
{
    internal class AdressRepository
    {
       public static List<Adress> _adresses = new List<Adress>();

        public static Adress Add(string name)
        {
            Adress adress = new Adress(name);
            _adresses.Add(adress);
            return adress;
        }
    }
}
