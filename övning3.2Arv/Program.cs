// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
//attribut, i vilken klass bör vi lägga det? 
//Eftersom alla fåglar ärver från Bird, kommer alla underklasser av Bird, inklusive Pelican,
//Flamingo och Swan, att ärva detta nya attribut och kan använda det enligt behov.


//14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
//  Eftersom alla djur ärver från Animal, kommer alla underklasser av Animal,
//  inklusive Horse, Dog, Hedgehog, Worm, Bird och Wolf,
//  att ärva detta nya attribut och kan använda det enligt behov.

using System;

namespace övning3._2Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            // Skapa en lista för hundar
            List<Dog> dogs = new List<Dog>();

            // Skapa några hundar och lägg till dem i listan
            dogs.Add(new Dog("Rex", 25, 3, "Labrador"));
            dogs.Add(new Dog("Buddy", 20, 4, "Golden Retriever"));


            // Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // Häst kan inte läggas till i listan av hundar eftersom listan är specificerad att endast acceptera objekt av typen Dog.
            // Att lägga till en häst i listan skulle bryta mot typsäkerheten.
            // Exempel:
            // dogs.Add(new Horse("Thunder", 500, 5, 250)); // Detta kommer att ge ett kompileringsfel

            // F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            //Måste listan vara av typen Animal eller IPerson.
            // På så sätt kan alla objekt av klasser som ärver från Animal eller implementerar IPerson lagras i listan.

            // Exempel på lista där alla klasser kan lagras tillsammans:
            //List<Animal> animals = new List<Animal>();
            //animals.Add(new Dog("Rex", 25, 3, "Labrador"));
            //animals.Add(new Horse("Thunder", 500, 5, 250));
            //animals.Add(new Bird("Polly", 0.5, 1, 0.3));




            /*
             Wolfman wolfman = new Wolfman("John", 80.5, 35, "Gray");
             wolfman.DoSound(); // Call DoSound method of Wolfman
             wolfman.Talk();    // Call Talk method of Wolfman

             // Create a Bird
             Bird bird = new Bird("Sparrow", 0.1, 2, 10.0);
             bird.DoSound(); // Call DoSound method of Bird


             // Keep the console window open
             Console.ReadLine();
            */

            List<Animal> animals = new List<Animal>();

            animals.Add(new Horse("Thunder", 500, 5, 250));
            animals.Add(new Dog("Rex", 25, 3, "Labrador"));
            animals.Add(new Hedgehog("Sonic", 1, 2, 5000));
            animals.Add(new Bird("Polly", 0.5, 1, 0.3));
            animals.Add(new Wolf("Alpha", 70, 6, "Gray"));

            // 5. Skriv ut vilka djur som finns i listan med hjälp av en foreach-loop
            Console.WriteLine("Stats of all animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());

                // Check if the animal is also of type IPerson
                if (animal is IPerson)
                {
                    // Type cast to IPerson and call Talk() method
                    IPerson person = (animal as IPerson);
                    if (person != null)
                    {
                        person.Talk();
                    }
                }
                // Kontrollera om djuret är en hund
                if (animal is Dog)
                {
                    // Om det är en hund, anropa Stats() för den
                    //Console.WriteLine(animal.Stats());
                    Dog dog = animal as Dog;
                    Console.WriteLine(dog.GetDogInfo());
                }
            }

            // 6. Anropa även Animals DoSound() metod i foreach-loopen
            Console.WriteLine("\nSounds of the animals:");
            foreach (var animal in animals)
            {
                animal.DoSound();
            }

        }
    }
}