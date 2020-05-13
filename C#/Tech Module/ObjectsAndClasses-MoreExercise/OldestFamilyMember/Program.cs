using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var peopleNumber = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < peopleNumber; i++)
            {
                var nameAge = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var person = new Person();
                person.Name = nameAge[0];
                person.Age = int.Parse(nameAge[1]);
                family.AddMember(person);
            }
            var personWithMaxAge = family.GetOldestMember();
            Console.WriteLine($"{personWithMaxAge.Name} {personWithMaxAge.Age}");
        }

    }
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age) : this()
        {
            this.Age = age;
        }
        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

    }
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }
        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(a => a.Age).First();
        }

    }

}
