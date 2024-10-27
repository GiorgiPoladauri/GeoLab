// using System;

// namespace GeoLabHW
// {
//     class Person
//     {
//         public virtual void DisplayInfo()
//         {
//             Console.WriteLine("I am Person");
//         }
//         public int Age { get; set; }
//         public string Name { get; set; }
//         public Person(string name, int age)
//         {
//             Name = name;
//             Age = age;
//         }
//         public override string ToString()
//         {
//             return $"Name: {Name}, Age: {Age}";
//         }
//     }
//     class Student : Person
//     {
//         public string StudentID { get; set; }
//         public Student(string name, int age, string studentID)
//             : base(name, age)
//         {
//             StudentID = studentID;
//         }
//         public override string ToString()
//         {
//             return $"{base.ToString()}, Student ID: {StudentID}";
//         }
//         public override void DisplayInfo()
//         {
//             Console.WriteLine("I am Student");
//         }
//     }
//     class Teacher : Person
//     {
//         public string Subject { get; set; }
//         public Teacher(string name, int age, string subject)
//             : base(name, age)
//         {
//             Subject = subject;
//         }
//         public override string ToString()
//         {
//             return $"{base.ToString()}, Subject: {Subject}";
//         }
//         public override void DisplayInfo()
//         {
//             Console.WriteLine("I am Teacher");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person person = new Person("Giorgi", 30);
//             Student student = new Student("Nino", 22, "S12345");
//             Teacher teacher = new Teacher("Lasha", 45, "Mathematics");
//             DisplayInfo(person);
//             DisplayInfo(student);
//             DisplayInfo(teacher);
//         }
//         static void DisplayInfo(Person person)
//         {
//             person.DisplayInfo();
//             Console.WriteLine(person.ToString());
//         }
//     }
// }

using System;
using System.Collections.Generic;

abstract class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }
    public abstract int GiveDamage();
}
class Sword : Weapon
{
    public Sword(string name, int damage) : base(name, damage) { }
    public override int GiveDamage()
    {
        return Damage;
    }
}
class Bow : Weapon
{
    public Bow(string name, int damage) : base(name, damage) { }
    public override int GiveDamage()
    {
        return Damage;
    }
}
class Axe : Weapon
{
    public Axe(string name, int damage) : base(name, damage) { }
    public override int GiveDamage()
    {
        return Damage;
    }
}
class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<Weapon> Weapons { get; set; }
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
        Weapons = new List<Weapon>();
    }
    public void Hit(Weapon weapon, Character target)
    {
        int damage = weapon.GiveDamage();
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} hits {target.Name} with {weapon.Name} for {damage} damage.");
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} takes {damage} damage. Health is now {Health}.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Character hero = new Character("Hero", 100);
        Character villain = new Character("Villain", 80);
        Weapon sword = new Sword("Excalibur", 25);
        Weapon bow = new Bow("Longbow", 15);
        Weapon axe = new Axe("Battle Axe", 30);
        hero.Weapons.Add(sword);
        hero.Weapons.Add(bow);
        villain.Weapons.Add(axe);
        hero.Hit(sword, villain);
        villain.Hit(axe, hero);
    }
}
