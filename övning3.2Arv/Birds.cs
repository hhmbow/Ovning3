using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning3._2Arv
{
    public class Bird : Animal
    {
       
      
            // Unik egenskap: WingSpan
            public double WingSpan { get; set; }

            public Bird(string name, double weight, int age, double wingSpan)
                : base(name, weight, age)
            {
                WingSpan = wingSpan;
            }

        // Override för Stats() för Bird
        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Wing Span: {WingSpan}");
            return birdStatsBuilder.ToString();
        }

        public override void DoSound()
            {
                Console.WriteLine("Chirp");
            }
    }

    public class Pelican : Bird
    {
        // Unik egenskap: BeakColor
        public string BeakColor { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, string beakColor)
            : base(name, weight, age, wingSpan)
        {
            BeakColor = beakColor;
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Beak color: {BeakColor}");
            return birdStatsBuilder.ToString();
        }
    }

    public class Flamingo : Bird
    {
        // Unik egenskap: LegLength
        public double LegLength { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, double legLength)
            : base(name, weight, age, wingSpan)
        {
            LegLength = legLength;
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Leg Length: {LegLength}");
            return birdStatsBuilder.ToString();
        }
    }

    public class Swan : Bird
    {
        // Unik egenskap: NeckLength
        public double NeckLength { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, double neckLength)
            : base(name, weight, age, wingSpan)
        {
            NeckLength = neckLength;
        }

        public override string Stats()
        {
            string baseStats = base.Stats();
            StringBuilder birdStatsBuilder = new StringBuilder(baseStats);
            birdStatsBuilder.AppendLine($"Neck Length: {NeckLength}");
            return birdStatsBuilder.ToString();
        }
    }
}

