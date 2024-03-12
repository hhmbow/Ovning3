using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace övning3._2Arv
{
    // Gränssnittet IPerson med en metod Talk()
    public interface IPerson
    {
        void Talk();
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        // Metod för att returnera alla egenskaper för djuret
        public virtual string Stats()
        {
            StringBuilder statsBuilder = new StringBuilder();
            statsBuilder.AppendLine($"Name: {Name}");
            statsBuilder.AppendLine($"Weight: {Weight}");
            statsBuilder.AppendLine($"Age: {Age}");
            return statsBuilder.ToString();
        }

        // Abstrakt metod DoSound()
        public abstract void DoSound();

        // Konstruktor
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }

   

 
   

    

    
}
