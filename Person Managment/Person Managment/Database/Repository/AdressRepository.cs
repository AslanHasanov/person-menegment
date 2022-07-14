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

        public static Adress Update(string name,int id)
        {
            foreach (Adress adress in _adresses)
            {
                if(adress.Id == id)
                {
                    adress.Name = name;
                    return adress;
                }
            }
            return null;    
        }

        public static Adress GetById(int id)
        {
            foreach(Adress adress in _adresses)
            {
                if(id == adress.Id)
                {
                    return adress;
                }
            }
            return null;
        }

       
    }
}
