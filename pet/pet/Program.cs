﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOpgave
{
    class Program
    {


        static void Main(string[] args)
        {

            Species Animal1 = new Species("cat", 2, 4, AnimalTypeEnum.Bird);
            Console.WriteLine("Name: {0}, Eyes: {1}, Legs: {2}", Animal1.Name, Animal1.NumberOEyes, Animal1.NumberOfLegs);

            Console.WriteLine("******************");

            Pets Petty1 = new Pets("Bob", Animal1);
            Console.WriteLine(Petty1.Name, Petty1.Species.NumberOEyes, Petty1.Species.NumberOfLegs);
            Console.WriteLine("*****************");
            Person p1 = new Person("Allan", 1968, Petty1);
            //p1.Name = "Allan";
            //p1.YearOfBirth = DateTime.Now;
            //p1.Pet = new Pets("Cow", 2, 4);

            Console.WriteLine("Name: {0}, Date: {1}, Pet: {2} ", p1.Name, p1.YearOfBirth, p1.Pet.Name);
            Console.WriteLine("*****************");
            Console.WriteLine("Name: {0}, Age: {1}, Eyes of Pet: {2}", p1.GetName(), p1.GetAge(), p1.GetEyes());
            Console.WriteLine("*****************");

            p1.NameChanged += Allan_NameChanged;
            p1.Name = "Hr. Badehætte";
            Console.WriteLine("*****************");
            Console.WriteLine("Petty says: {0}", Petty1.Talk()); // Petty1 taler og siger Pip! hvis Petty1 er Bird.
            Console.WriteLine("*****************");

            Species Animal2 = new Species("Vulcan Dragon", 4, 6, AnimalTypeEnum.Fish);
            Pets Petty2 = new Pets("Firehole", Animal2);
            Person p2 = new Person("Egon", 1973, Petty2);
            

            var locallist = new List<Person>();
            locallist.Add(p1);
            locallist.Add(p2);

            List<Person> result = locallist.FilterOut(person => (person.Name == "Egon") && (person.Pet.Species.NumberOEyes > 2));

            foreach (var p in result)
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Name of pet: " + p.Pet.Name + " (" + p.Pet.Species.Name + ", " + p.Pet.Species.NumberOEyes + " eyes)");
            }
            Console.WriteLine("*****************");
            Console.ReadKey();
        }

        //EventHandler

        private static void Allan_NameChanged(object sender, string e)
        {
            Debug.WriteLine("Nyt navn: " + e);
        }
    }
}

