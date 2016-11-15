using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOpgave
{
    public enum AnimalTypeEnum { Bird, Fish }

    public class Species
    {
        private AnimalTypeEnum animalKind = AnimalTypeEnum.Fish;

        public AnimalTypeEnum AnimalType // Accessor, der giver adgang fra Pets-klassen
        {
            get
            {
                return animalKind;
            }
        }

        private string name;
        private int numberOfEyes;
        private int numberOfLegs;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int NumberOEyes
        {
            get
            {
                return numberOfEyes;
            }
        }

        public int NumberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
        }


        // Constructor
        public Species(string Name, int NumberOfEyes, int NumberOfLegs, AnimalTypeEnum animalKind)
        {
            this.name = Name;
            this.numberOfEyes = NumberOfEyes;
            this.numberOfLegs = NumberOfLegs;
            this.animalKind = animalKind;
        }
    }
}
