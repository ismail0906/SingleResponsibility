using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class PersonOperation
    {
        public Person[] peoples = new Person[0];

        public void Add(Person people) 
        {
            Array.Resize(ref peoples,peoples.Length+1);
            peoples[peoples.Length-1] = people;
        }
        public void ShowPersons() 
        {
            foreach (Person person in peoples)
            {
                Console.WriteLine($"{person.Name} - {person.Surname}");
            }

        }

    }
}
