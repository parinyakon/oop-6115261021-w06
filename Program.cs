using System;

namespace oop_6115261021_w06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ryu", "", 20000, "Lecturer");
            Person p2 = new Person("Ken", "", 25000, "Lecturer");
            Person p3 = new Person("Guile", "", 30000, "Staff");
            Person p4 = new Person("Orange", "", 50000, "Staff");
            Faculty f1 = new Faculty("Faculty of Educational");
            f1.setPerson(p1, 0);
            f1.setPerson(p2, 1);
            f1.setPerson(p3, 2);
            f1.setPerson(p4, 3);
            f1.printAll();
        }
    }
}
