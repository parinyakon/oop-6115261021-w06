using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w06
{
    class Faculty
    {
        private string name;
        private Person[] persons = new Person[20];
        public Faculty(string n)
        {
            this.name = n;
        }
        public string Name { get => this.name; set => this.name = value; }
        public void setPerson(Person p, int index)
        {
            this.persons[index] = p;
        }
        public Person getPerson(int index)
        {
            return this.persons[index];
        }
        public void printAll()
        {
            for (int i = 0; i < this.persons.Length; i++)
            {
                if (this.persons[i] != null)
                {
                    Console.WriteLine(this.persons[i].ToString());
                }
            }
        }
    }
}
