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
        public static List<Employee> _persons = new List<Employee>();
        
        public static Employee Add(string name, string surname, string fatherName, string fin, string email)
        {
            Employee person = new Employee(name, surname, fatherName, fin, email);


            _persons.Add(person);
            return person;
            
        }

        public static Employee Update(string name, int id ,string surname, string fatherName, string fin, string email)
        {
            foreach (Employee person in _persons)
            {
                if (person.Id == id)
                {
                    person.Name = name;
                    person.Surname = surname;
                    person.FatherName = fatherName;
                    person.FIN = fin;
                    person.Email = email;

                    return person;

                }
            }
            return null;
        }

    }
}
