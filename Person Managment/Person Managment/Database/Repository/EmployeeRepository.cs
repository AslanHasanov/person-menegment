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

        public static Employee GetById(int id)
        {
            foreach  (Employee person in _persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return null;
        }


        public List<Employee> GetAll()
        {
            return _persons;
        }


        public static void DeleteById(int id)
        {
            for (int i = 0; i < _persons.Count; i++)
            {
                if (_persons[i].Id == id)
                {
                    _persons.RemoveAt(i);
                }
            }
        }


        public static bool IsEmailUnique(string email)
        {
            foreach (Employee person in _persons)
            {
                if (email == person.Email)
                {
                    return false;
                }
            }
            return true;
        }





    }
}
