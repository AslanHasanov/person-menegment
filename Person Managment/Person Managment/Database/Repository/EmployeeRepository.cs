using Person_Managment.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Managment.Database.Repository
{
    class EmployeeRepository
    {
        public static List<Employee> _person = new List<Employee>();
        
        public static Employee Add(string name, string surname, string fatherName, string fin, string email)
        {
            Employee person = new Employee(name, surname, fatherName, fin, email);


            _person.Add(person);
            return person;
            
        }

    }
}
