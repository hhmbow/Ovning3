using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning3._2Arv
{
    public class Wolf : Animal
    {
        
            // Unik egenskap: Brown
            public string Brown { get; set; }

            public Wolf(string name, double weight, int age, string brown)
                : base(name, weight, age)
            {
                Brown = brown;
            }

        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Color: {Brown}");
            return birdStatsBuilder.ToString();
        }
        public override void DoSound()
            {
                Console.WriteLine("brrrrr");
            }
        
    }
}
