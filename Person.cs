using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Person
    {
        string name;

        DateTime birthYear;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime BirthYear
        {
            get => birthYear;
            set => birthYear = value;
        }
        public Person() { }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthYear.Year;
            return age;
        }

        public void Input()
        {
            Console.WriteLine("Please, type your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Please, type your date of birth: ");
            BirthYear = DateTime.Parse(Console.ReadLine());
        }

        public void ChangeName()
        {

            DateTime today = DateTime.Today;
            const string changedName = "Very young";
            if (today.Year - birthYear.Year < 16)
            {
                Name = changedName;
                Console.WriteLine("New name is: " + $"{Name}"); 
            }
            else Console.WriteLine("Name is : " + $"{Name}");
        }

        public override string ToString()
        {
            return $"name: {name}, birth year: {birthYear.ToShortDateString()}, age: {Age()}";
        }
        public void Output()
        {
            Console.WriteLine("Info about the person: " + $"{ToString()}") ;
        }


    }
}
