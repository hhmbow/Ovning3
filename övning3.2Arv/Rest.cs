using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning3._2Arv
{
  
        public class Hedgehog : Animal
        {
            // Unik egenskap: NumberOfSpikes
            public int NumberOfSpikes { get; set; }

            public Hedgehog(string name, double weight, int age, int numberOfSpikes)
                : base(name, weight, age)
            {
                NumberOfSpikes = numberOfSpikes;
            }
        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Number of Spikes: {NumberOfSpikes}");
            return birdStatsBuilder.ToString();
        }
        public override void DoSound()
            {
                Console.WriteLine("Snuffle");
            }
        }

    public class Dog : Animal
    {
        // Unik egenskap: Breed
        public string Breed { get; set; }
        public string DogInfo { get; set; }

        public Dog(string name, double weight, int age, string breed)
            : base(name, weight, age)
        {
            Breed = breed;
            // Validera info
            DogInfo = ValidateInfo();
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Breed: {Breed}");
            return birdStatsBuilder.ToString();
        }
        public override void DoSound()
        {
            Console.WriteLine("Woof");
        }

        public string GetDogInfo()
        {
            return DogInfo;
        }
        // Validera info
        private string ValidateInfo()
        {
            // Enkelt exempel på validering
            return $"{Name} is a {Breed} with ID {Age}";
        }
    }

    public class Horse : Animal
    {
        // 6. Unik egenskap: HorsePower
        public int HorsePower { get; set; }

        public Horse(string name, double weight, int age, int horsePower)
            : base(name, weight, age)
        {
            HorsePower = horsePower;
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Horsepower: {HorsePower}");
            return birdStatsBuilder.ToString();
        }

        // 7. Implementera DoSound() för Horse
        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }
    }


}

