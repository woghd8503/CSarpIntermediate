using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var Person = new Person();
            Person.Name = str;

            return Person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            person.Introduce("Mosh");
        }
    }
}
