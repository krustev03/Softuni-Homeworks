using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;
        private int id = 0;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Person person)
        {
            this.data.Add(id, person);
            id++;
        }

        public Person Get(int id)
        {
            var foundPerson = this.data.Where(x => x.Key == id).FirstOrDefault();
            return foundPerson.Value;
        }

        public bool Update(int id, Person newPerson)
        {
            int k = 0;

            foreach (var item in this.data)
            {
                if (item.Key == id)
                {
                    k = 1;
                }
            }

            if (k == 0)
            {
                return false;
            }
            else
            {
                var person = this.data.Where(x => x.Key == id).FirstOrDefault().Value;
                person.Age = newPerson.Age;
                person.Name = newPerson.Name;
                person.Birthdate = newPerson.Birthdate;

                return true;
            }
        }

        public bool Delete(int id)
        {
            int k = 0;

            foreach (var item in this.data)
            {
                if (item.Key == id)
                {
                    k = 1;
                }
            }

            if (k == 0)
            {
                return false;
            }
            else
            {
                this.data.Remove(id);

                return true;
            }
        }
    }
}
