using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
         
        }


        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person
            {
                Age = age,
                Fname = fname,
                Lname = lname,
                Height = height,
                Weight = weight
            };
        }

        // Ändra ålder 
        public void ChangeAge(Person person, int newAge)
        {
            person.Age = newAge;
        }

        // Ändra förnamn 
        public void ChangeFirstName(Person person, string newFirstName)
        {
            person.Fname = newFirstName;
        }

        // Ändra efternamn 
        public void ChangeLastName(Person person, string newLastName)
        {
            person.Lname = newLastName;
        }

        // Ändra längd 
        public void ChangeHeight(Person person, double newHeight)
        {
            person.Height = newHeight;
        }

        // Ändra vikt 
        public void ChangeWeight(Person person, double newWeight)
        {
            person.Weight = newWeight;
        }

    }

}

