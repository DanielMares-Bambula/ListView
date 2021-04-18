using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Listview
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string dateOfBirth;
        public string DateOfBirth
        {
            get => dateOfBirth;
            set { dateOfBirth = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth")); }
        }
        private int birthNumber;
        public int BirthNumber
        {
            get => birthNumber;
            set { birthNumber = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BirthNumber")); }
        }
        public static Dictionary<string, Person> AllPersons = new Dictionary<string, Person>();
        public static void InitPersons()
        {
            AllPersons["Tonda Houška"] = new Person
            {
                DateOfBirth = "2002",
                BirthNumber = 25263732,

            };
            AllPersons["Lucie Houšková"] = new Person
            {
                DateOfBirth = "2005",
                BirthNumber = 25263732,

            };
        }
    }
}
