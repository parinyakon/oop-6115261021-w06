using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w06
{
    class Person
    {
        private string personName;
        private string personLastname;
        private double personSalary;
        private string personPosition;
        public string PersonName
        {
            get { return personName; }
            set { this.personName = value; }
        }
        public string PersonLastname
        {
            get { return personLastname; }
            set { this.personLastname = value; }
        }
        public double PersonSalary
        {
            get { return personSalary; }
            set { this.personSalary = value; }
        }
        public string PersonPosition
        {
            get { return personPosition; }
            set { this.personPosition = value; }
        }

        public Person() { }
        public Person(string Name, string Lastname, double Salary, string Position)
        {
            this.PersonName = Name;
            this.PersonLastname = Lastname;
            this.PersonSalary = Salary;
            this.PersonPosition = Position;
        }
        public override string ToString()
        {
            return this.PersonName + " " + this.PersonLastname + " salary: "
            + this.PersonSalary + " tax: " + Tax.getTax(this.personSalary*12);

        }
    }
}
