using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
 
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[6]; 

            for(int i = 0; i<people.Length; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }
            foreach (var person in people)
            {
                person.Output();
            }

            foreach(var person in people)
            {
                person.ChangeName();
            }
            //All new info with the changed name
            foreach (var person in people)
            {
                person.Output();
            }

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i].Name == people[j].Name)
                    {
                        Console.WriteLine(people[i].ToString());
                        Console.WriteLine(people[j].ToString());
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
