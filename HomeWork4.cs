// T1

//using System;
//using System.Collections.Generic;
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public static List<string> AllNamesAndSurnames = new List<string>();
//    public static void Main()
//    {
//        Person person = new Person();
//        person.GetInfo();
//        person.DisplayAllNamesAndSurnames();
//    }
//    public void GetInfo()
//    {
//        string YesOrNo;
//        do
//        {
//            Console.WriteLine("Please, input your name first: ");
//            Name = Console.ReadLine();
//            AllNames.Add(Name);
//            Console.WriteLine("Please, input your age now in numbers: ");
//            try
//            {
//                Age = int.Parse(Console.ReadLine());
//                if (Age < 0)
//                {
//                    Age = 0;
//                    Console.WriteLine("Negative age is not allowed. Age set to 0.");
//                }
//                else if (Age > 120)
//                {
//                    Age = 120;
//                    Console.WriteLine("Age above 120 is not allowed. Age set to 120.");
//                }
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Invalid input. Age set to 0.");
//                Age = 0;
//            }
//            Console.WriteLine($"Name: {Name}; Age: {Age}");
//            Console.WriteLine("Do you want to do that again? (Yes/No)");
//            YesOrNo = Console.ReadLine();
//        } while (YesOrNo.Equals("Yes", StringComparison.OrdinalIgnoreCase));
//    }
//    public void DisplayAllNamesAndSurnames()
//    {
//        Console.WriteLine("\nAll names entered:");
//        foreach (var name in AllNames) Console.WriteLine(name);
//    }
//}

// T2

//using System;
//using System.Collections.Generic;

//public class Car
//{
//    public string Brand { get; set; }
//    public int Year { get; set; }

//    public Car(string brand, int year)
//    {
//        Brand = brand;
//        Year = year < 1886 ? 1886 : (year > DateTime.Now.Year ? DateTime.Now.Year : year);
//    }

//    public override string ToString()
//    {
//        return $"Brand: {Brand}, Year: {Year}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Car> cars = new List<Car>();
//        while (true)
//        {
//            Console.Write("Enter car brand: ");
//            string brand = Console.ReadLine();
//            Console.Write("Enter car year: ");
//            int year;
//            while (!int.TryParse(Console.ReadLine(), out year))
//            {
//                Console.Write("Invalid input. Please enter a valid year: ");
//            }

//            Car car = new Car(brand, year);
//            cars.Add(car);

//            Console.Write("Do you want to enter another car? (yes/no): ");
//            string response = Console.ReadLine().ToLower();
//            if (response != "yes") break;
//        }

//        Console.WriteLine("\nCars entered:");
//        foreach (var car in cars)
//        {
//            Console.WriteLine(car);
//        }
//    }
//}

// T3

//using System;

//public enum Currency
//{
//    GEL,
//    USD,
//    EUR
//}

//public class Product
//{
//    private string name;
//    private decimal price;
//    private Currency currency;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//    public decimal Price
//    {
//        get { return price; }
//        set { price = value < 0 ? 0 : value; }
//    }
//    public Currency Currency
//    {
//        get { return currency; }
//        set { currency = value; }
//    }
//    public Product(string name, decimal price, Currency currency)
//    {
//        Name = name;
//        Price = price;
//        Currency = currency;
//    }
//    public override string ToString()
//    {
//        return $"Name: {Name}, Price: {Price}, Currency: {Currency}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product product1 = new Product("Laptop", 1200.00m, Currency.USD);
//        Product product2 = new Product("Coffee", -5.00m, Currency.GEL);
//        Product product3 = new Product("Book", 15.50m, Currency.EUR);
//        Console.WriteLine(product1);
//        Console.WriteLine(product2);
//        Console.WriteLine(product3);
//    }
//}
