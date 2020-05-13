using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] parts = command.Split();
                var person = new Person(parts[0], parts[1], Convert.ToInt32(parts[2]));
                persons.Add(person);
            }
            persons = persons.OrderBy(x => x.Age).ToList();
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
