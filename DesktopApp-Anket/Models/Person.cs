using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp_Anket.Models
{
    internal class Person
    {
        public Person(string name, string surname, int age, string gender)
        {
            Name=name;
            Surname=surname;
            Id=Guid.NewGuid();
            Age=age;
            Gender=gender;
        }

        public String Name { get; set; }

        public string Surname { get; set; }

        public Guid Id { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }


    }
}
