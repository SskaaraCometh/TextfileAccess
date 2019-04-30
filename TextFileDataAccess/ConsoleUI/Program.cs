using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demos\Text.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach(string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("Sue,Storm");

            //File.WriteAllLines(filePath, lines);
            //Console.ReadLine();

            List<Person> people = new List<Person>();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                
                Person newPerson = new Person();
                newPerson.FirstName = entries[0];
                newPerson.SecondName = entries[1];
                newPerson.Url = entries[2];

                people.Add(newPerson);
           
            }

            foreach(var person in people)
            {
                Console.WriteLine($"{person.FirstName},{person.SecondName},{person.Url}");
            }

            people.Add(new Person { FirstName = "Greg", SecondName = "Jon", Url = "www.test.com" });

            List<string> output = new List<string>();

            foreach(var person in people)
            {
                output.Add($"{person.FirstName},{person.SecondName},{person.Url}");
            }

            File.WriteAllLines(filePath, output);
            Console.ReadLine();
        }
    }
}
