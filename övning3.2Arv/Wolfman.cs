using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning3._2Arv
{
   
        public class Wolfman : Wolf, IPerson
        {
            public Wolfman(string name, double weight, int age, string brown)
                : base(name, weight, age, brown)
            {
                
            }



            // 12. Implementera Talk() som skriver ut vad Wolfman säger.
            public void Talk()
            {
                Console.WriteLine("I am a wolfman!");
            }
        }
    
}
