using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        private int Weight { get; set; }
        private int Height { get; set; }

        public Person(string name, string surname, int age, int weight, int height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            string about = "Name:" + Name + " " + "Surname: " + Surname + " " + "Weight :" + Weight + " " + "Height : " + Height;
            return about;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Vusal", "Zeynalov", 19, 75, 180);
            Console.WriteLine(person.ToString());
        }
    }
}


////Hemin object-in ".ToString()" metodunu chaghiranda "Person " tipli objecting butov " +
////xususiyyetleri string shekilinde qaytarilmalidi. "Person " class-in ".ToString()" metodu qaytaran neticeni console-da gorsedin. 
////"Person " class-in 5 dene field-lari olmalidi: Name, Surname, Age, Weight, Height. Qeyd etmey isteyiremki bu fieldlar ancag ve 
////ancag contructor terefinden teyin olunmalidir. Kenardan bu field-lari teyin etmey imkani olmasin!!! 