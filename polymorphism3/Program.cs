using System;

namespace polymorphism3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = {

                new Person("Adrian", "070110101"),
                new Student("Adrian", "070110101"),
                new Teacher("Adrian", "070110101"),
            };

            foreach (var p in person)
            {
                Console.WriteLine(p.Something());
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        protected string name;
        protected string nr;

        public string Name()
        {
            return name;
        }

        public string Nr()
        {
            return nr;
        }

        public Person(string name, string nr)
        {
            this.name = name;
            this.nr = nr;
        }

        public virtual string Something()
        {
            return $"Person: {name}, {nr}";
        }
    }

    class Student : Person
    {
        public Student(string name, string nr): base(name,nr)
        {
            
        }

        public override string Something()
        {
            return $"Student: {name}, {nr}";
        }
    }

class Teacher:Person
    {
        public Teacher(string name, string nr): base(name, nr)
        {

        }

        public override string Something()
        {
            return $"Teacher: {name}, {nr}";
        }
    }
}
