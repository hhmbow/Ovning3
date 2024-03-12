// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Övning3;
using System;


class Program
{
 
  
       static void Main(string[] args)
        {
            try
            {
            PersonHandler handler = new PersonHandler();

            Person person1 = handler.CreatePerson(15, "Sidi", "Fall", 170, 78);
            Person person2 = handler.CreatePerson(15, "Mame", "Amdy", 165, 65);
            Person person3 = handler.CreatePerson(39, "Modou", "Mbenda", 180, 91);

            // Ändra åldern 
            handler.ChangeAge(person1, 26);

            // Ändra längden
            handler.ChangeHeight(person2, 185);

            // Ändra vikten 
            handler.ChangeWeight(person3, 72);

            Console.WriteLine($"Person 1: {person1.Fname} {person1.Lname}, Age: {person1.Age}, Height: {person1.Height}, Weight: {person1.Weight}");
            Console.WriteLine($"Person 2: {person2.Fname} {person2.Lname}, Age: {person2.Age}, Height: {person2.Height}, Weight: {person2.Weight}");
            Console.WriteLine($"Person 3: {person3.Fname} {person3.Lname}, Age: {person3.Age}, Height: {person3.Height}, Weight: {person3.Weight}");
            /* 
              Person person = new Person();
             person.Age = 7;
         person.Fname = "Sidi";
             person.Lname = "Fall";
             person.Height = 190;
             person.Weight = 70;

             Console.WriteLine($"Hey my fullname is: {person.Fname + " " + person.Lname}, my age is: {person.Age}, my height is: {person.Height}, and my weight is: {person.Weight} ");
        */
        }
        catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
     
    }

