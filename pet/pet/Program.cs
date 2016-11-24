using System;
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
            Console.WriteLine("Name: {0}, Eyes: {1}, Legs: {2}", Animal1.Name, Animal1.NumberOfEyes, Animal1.NumberOfLegs);

            Console.WriteLine("******************");

            Pets Petty1 = new Pets("Bob", Animal1);
            Console.WriteLine(Petty1.Name, Petty1.Species.NumberOfEyes, Petty1.Species.NumberOfLegs);
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

            Species Animal2 = new Species("Vulcan Dragon", 4, 6, AnimalTypeEnum.Fish); // Tilføj ny race
            Pets Petty2 = new Pets("Firehole", Animal2); // Tilføj nyt kæledyr
            Person p2 = new Person("Egon", 1973, Petty2); // Tilføj ny person
            
            // Delegates

            var list = new List<Person>(); // Opret ny liste
            list.Add(p1); // Tilføj Person 1 til listen
            list.Add(p2); // Tilføj Person 2 til listen

            List<Person> result = list.FilterOut(person => (person.Name == "Egon") && (person.Pet.Species.NumberOfEyes > 2)); // Filtrerer locallist vha. delegates Egon and Eyes>2
            Console.WriteLine("Dear Console. Please give me Persons with Name Egon who have Pets with more than 2 eyes!");

            foreach (var p in result) // For hvert tilfælde i det filtrerede resultat
            {
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Name of pet: " + p.Pet.Name + " (" + p.Pet.Species.Name + ", " + p.Pet.Species.NumberOfEyes + " eyes)");
                Console.WriteLine("*****************");
            }

            // Dependency Injection, Modul #4 slides 60-61 (opgave I+II)

            var prime = new List<PrimeGenerator>();
            prime.Add(1);
            prime.Add(2);
            prime.Add(3);
            prime.Add(5);


            Console.ReadKey();
        }

        // EventHandler

        private static void Allan_NameChanged(object sender, string e)
        {
            Debug.WriteLine("Nyt navn: " + e);
        }
    }
}

