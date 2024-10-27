using System;

namespace GeoLabHW
{
    class Person
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I am Person");
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    class Student : Person
    {
        public string StudentID { get; set; }
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            StudentID = studentID;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Student ID: {StudentID}";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("I am Student");
        }
    }
    class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Subject: {Subject}";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("I am Teacher");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Giorgi", 30);
            Student student = new Student("Nino", 22, "S12345");
            Teacher teacher = new Teacher("Lasha", 45, "Mathematics");
            DisplayInfo(person);
            DisplayInfo(student);
            DisplayInfo(teacher);
        }
        static void DisplayInfo(Person person)
        {
            person.DisplayInfo();
            Console.WriteLine(person.ToString());
        }
    }
}
