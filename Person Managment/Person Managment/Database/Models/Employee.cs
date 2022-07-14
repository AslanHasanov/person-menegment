using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Managment.Database.Models
{
    class Employee
    {
        public int Id { get; private set; }


        public string Name { get; set; }

        public string  Surname { get; set; }

        public string  FatherName { get; set; }

        public string  FIN { get; set; }

        public string  Email { get; set; }

        private static int _idCounter = 1;


        public Employee(string name, string surname, string fatherName, string fin, string email)
        {
            Id = _idCounter; 
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            FIN = fin;
            Email = email;
            _idCounter++;
        }





    }
}
