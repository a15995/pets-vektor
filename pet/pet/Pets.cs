using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetsOpgave
{
    public class Pets
    {
        private string name;
        private Species species;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public Species Species
        {
            get
            {
                return species;
            }
        }

        public Pets(string name, Species species)
        {
            this.name = name;
            this.species = species;
        }


        //public Pets(string Name, int NumberOfEyes, int NumberOfLegs) : base(Name, NumberOfEyes, NumberOfLegs)
        //{
        //}
    }
}
