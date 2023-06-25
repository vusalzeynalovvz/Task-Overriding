using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

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
            Console.WriteLine(person);
        }
    }
}


////Hemin object-in ".ToString()" metodunu chaghiranda "Person " tipli objecting butov " +
////xususiyyetleri string shekilinde qaytarilmalidi. "Person " class-in ".ToString()" metodu qaytaran neticeni console-da gorsedin. 
////"Person " class-in 5 dene field-lari olmalidi: Name, Surname, Age, Weight, Height. Qeyd etmey isteyiremki bu fieldlar ancag ve 
////ancag contructor terefinden teyin olunmalidir. Kenardan bu field-lari teyin etmey imkani olmasin!!! 