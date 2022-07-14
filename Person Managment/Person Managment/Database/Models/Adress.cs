using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Managment.DataBase.Models
{
    internal class Adress
    {
        public int Id { get;private set; }
        public string Name { get; set; }

        public int _counter = 1;

        public Adress( string name)
        {
            Id = _counter++;
            Name = name;
            
        }
    }
}
