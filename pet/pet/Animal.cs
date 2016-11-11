using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOpgave
{
    public class Animal
    {
        private int heads;
        private int feet;
        
        public Animal(int heads, int feet)
        {
            this.heads = heads;
            this.feet = feet;
        }

        public Animal(int feet) : this(1, feet: feet) { }
        // Følgende bliver unødvendigt ved brug af ovenstående chaining - chaining giver mulighed for at udvide en klasse
        // public class anstract - giver udelukkende mulighed for chaining men er ikke nødvendig
        // {
        // this.heads = 1
        // this.feet = feet;
        // }

        public int Feet
        {
            get { return feet; }
        }

        public static List<Animal> CreateFarm()
        {
            var animals = new List<Animal>();
            animals.Add(new PetsOpgave.Animal(4));

            return animals;
        }
    }

    class Usage
    {
        public void DoStuff()
        {
            List<Animal> farm = Animal.CreateFarm();

            Animal dyr = new Animal(2);
            dyr.Feet;

        }
    }
}