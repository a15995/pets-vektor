using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOpgave
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private int yearOfBirth;
        private Pets pet;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (this.Name != value) // hvis værdi er forskellig
                {
                    this.name = value;
                    OnNameChanged();
                    OnPropertyChanged("Name");
                }
            }
        }
        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
        }

        public Pets Pet
        {
            get
            {
                return pet;
            }
        }

        public Person(string name, int yearOfBirth, Pets pet)
        {
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.pet = pet;
        }
        public string GetName()
        {
            return this.Name;
        }
        public int GetAge()
        {
            DateTime d = DateTime.Now;
            var alder = d.Year - this.YearOfBirth;
            return alder;
        }
        public int GetEyes()
        {
            return this.Pet.Species.NumberOEyes;
        }
        public Person(string name)
        {
            this.name = name;
        }

        // Constructors

        public Person(string name, Pets pet)
        {
            this.name = name;
            this.pet = pet;
        }
        public Person(string name, string petName, Species specie)
        {
            this.name = name;
            var newPet = new Pets(petName, specie);
            this.pet = newPet;
        }

        // EventHandler

        public event EventHandler<string> NameChanged; // den metode, der skal tage imod eventen vil gerne have string som parameter
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNameChanged()
        {
            EventHandler<string> handler = NameChanged;
            if (handler != null)
            {
                handler(this, this.Name);
            }
        }

        // PropertyChanged

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    // Delegates
        
    public delegate bool Filter(Person person);

    public static class PersonExtensions
    {
        public static List<Person> FilterOut(this List<Person> personlist, Filter filter) // Filtrer personer baseret på delegate (filter = kommandoer)
        {
            var positivliste = new List<Person>();
            foreach (Person person in personlist)
            {
                if (filter.Invoke(person)) // Hvis filter returnerer true
                {
                    positivliste.Add(person); // så tilføj til listen.
                }

            }
            return positivliste;
        }
    }
}
