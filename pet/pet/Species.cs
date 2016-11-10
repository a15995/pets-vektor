using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOpgave
{
    public class Species
    {
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


        //constructor
        public Species(string Name, int NumberOfEyes, int NumberOfLegs)
        {
            this.name = Name;
            this.numberOfEyes = NumberOfEyes;
            this.numberOfLegs = NumberOfLegs;
        }
    }

    

    
}
