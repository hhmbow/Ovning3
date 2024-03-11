// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Övning3;
using System;


class program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.age = 7;
        person.fname = "Sidi";
        person.lname = "Fall";
        person.height = 190;
        person.weight = 70;

        Console.WriteLine($"Hey my fullname is: {person.fname + " " + person.lname}, my age is: {person.age}, my height is: {person.height}, and my weight is: {person.weight} ");

    }
}

