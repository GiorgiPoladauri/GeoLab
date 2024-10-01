//HomeWork1GPGeoLab

// using System;

// class Program {
//   public static void Main (string[] args) {
//     Console.WriteLine("Please, input number to identify it : ");
//     double InputNumber = double.Parse(Console.ReadLine());
//     if (InputNumber < 0)
//     {
//       Console.WriteLine("This number is negative");
//     }
//     else if (InputNumber == 0) 
//     {
//       Console.WriteLine("This number is zero");
//     }
//     else
//     {
//       Console.WriteLine("This number is positive");
//     }
//   }
// }

// using System;

// class Program {
//   public static void Main (string[] args) {
//     Console.WriteLine("Please, input number to identify it : ");
//     double InputNumber = double.Parse(Console.ReadLine());
//     if (InputNumber % 2 == 1)
//     {
//       Console.WriteLine("This number is even");
//     }
//     else if (InputNumber == 0) 
//     {
//       Console.WriteLine("This number is just zero");
//     }
//     else
//     {
//       Console.WriteLine("This number is odd");
//     }
//   }
// }

// using System;

// class Program {
//   public static void Main (string[] args) {
//     Console.WriteLine("Please, input number to identify it : ");
//     double InputNumber = double.Parse(Console.ReadLine());
//     if (InputNumber >= 0 && InputNumber<= 100)
//     {
//       if (InputNumber >= 90) 
//       {
//         Console.WriteLine("Your grade is A");
//       }
//       else if (InputNumber >= 80 && InputNumber < 90) 
//       {
//         Console.WriteLine("Your grade is B");
//       }
//       else if (InputNumber >= 70 && InputNumber < 80)
//       {
//         Console.WriteLine("Your grade is C");
//       }
//       else if (InputNumber >= 60 && InputNumber < 70) 
//       {
//         Console.WriteLine("Your grade is D");
//       }
//       else 
//       {
//         Console.WriteLine("Your grade is F");
//       }
//     }
//   }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter years (Separated by spaces):");
//         string input = Console.ReadLine();
//         string[] yearStrings = input.Split(' ');
//         foreach (string yearString in yearStrings)
//         {
//             if (int.TryParse(yearString, out int year))
//             {
//                 if (IsLeapYear(year))
//                 {
//                     Console.WriteLine($"{year} is a leap year.");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"{year} is not a leap year.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine($"{yearString} is not a valid year.");
//             }
//         }
//     }
//     static bool IsLeapYear(int year)
//     {
//         if (year % 400 == 0)
//             return true;
//         if (year % 100 == 0)
//             return false;
//         if (year % 4 == 0)
//             return true;
//         return false;
//     }
// }

// using System;

// class Program {
//   public static void Main (string[] args) {
//     var Password = "secret123";
//     Console.WriteLine("Please, input the password to log in : ");
//     var PasswordInput = Console.ReadLine();
//     if (PasswordInput == Password) {
//       Console.WriteLine("Access Granted");
//     }
//     else 
//     {
//       Console.WriteLine("Access Forbidden");
//     }
//   }
// }

// using System;

// class Program {
//     public static void Main(string[] args) {
//         Console.WriteLine("Please, input numbers with space between to identify them: ");
//         string inputNumber = Console.ReadLine();
//         string[] stringNumbers = inputNumber.Split(' ');

//         int maxNumber = int.MinValue;
//         foreach (string numberString in stringNumbers) {
//             if (int.TryParse(numberString, out int number)) {
//                 if (number > maxNumber) {
//                     maxNumber = number;
//                 }
//             } else {
//                 Console.WriteLine($"'{numberString}' is not a valid number.");
//             }
//         }
//         if (maxNumber != int.MinValue) {
//             Console.WriteLine($"The highest number is: {maxNumber}");
//         } else {
//             Console.WriteLine("No valid numbers were entered.");
//         }
//     }
// }

// using System;

// class Program {
//     public static void Main(string[] args) {
//         Console.WriteLine("Please, input two numbers with space between them: ");
//         string InputNumber = Console.ReadLine();
//         string[] stringNumbers = InputNumber.Split(' ');
//         int Number1 = int.Parse(stringNumbers[0]);
//         int Number2 = int.Parse(stringNumbers[1]);

//         int Plus = Number1 + Number2;
//         int Minus = Number1 - Number2;
//         int Multiply = Number1 * Number2;

//         Console.WriteLine($"Number1 + Number2 = {Plus}");
//         Console.WriteLine($"Number1 - Number2 = {Minus}");
//         Console.WriteLine($"Number1 * Number2 = {Multiply}");

//         if (Number2 == 0) {
//             Console.WriteLine("You can't divide by zero!");
//         } else {
//             double Divide = (double)Number1 / Number2; // Cast to double for accurate division
//             Console.WriteLine($"Number1 / Number2 = {Divide}");
//         }
//     }
// }

// using System;

// class Program {
//     public static void Main(string[] args) {
//         Console.WriteLine("გამარჯობა, გთხოვთ შეიყვანოთ თქვენი სახელი : ");
//         String Name = Console.ReadLine();
//         Console.WriteLine($"გამარჯობა, {Name} ! შეიყვანეთ თქვენი ასაკი : ");
//         int Age = int.Parse(Console.ReadLine());
//         if (Age < 18)
//         {
//             Console.WriteLine("თქვენ არ ხართ სრულწლოვანი და ვერ მიიღებთ არჩევნებში მონაწილეობას ! ");
//         }
//         else 
//         {
//             Console.WriteLine("თქვენი არჩევნებში მონაწილეობა დასაშვებია ! ");
//         }
//     }
// }

// using System;

// class Program {
//     public static void Main(string[] args) {
//         Console.WriteLine("Hello, please tell us your name : ");
//         String Name = Console.ReadLine();
//         DateTime CurrentTime = DateTime.Now;
//         if (CurrentTime.Hour >= 5 && CurrentTime.Hour < 12)
//         {
//         Console.WriteLine($"Good morning, {Name} !");
//         }
//         else if(CurrentTime.Hour >= 12 && CurrentTime.Hour < 17)
//         {
//         Console.WriteLine($"Good afternoon, {Name} !");
//         }
//         else if(CurrentTime.Hour >= 17 && CurrentTime.Hour < 21)
//         {
//         Console.WriteLine($"Good evening, {Name} !");
//         }
//         else
//         {
//             Console.WriteLine($"Goodnight, {Name}!");
//         }
//     }
// }

// using System;

// class Program {
//     public static void Main(string[] args) {
//         Console.WriteLine("Hello, please tell us amount of money $ you have to spent here : ");
//         double SpentMoney = Convert.ToDouble(Console.ReadLine());
//         if (SpentMoney < 100) 
//         {
//             Console.WriteLine("Your shopping amount doesn't qualify for discount");
//         }
//         else if (SpentMoney >= 100 && SpentMoney < 500)
//         {
//             Console.WriteLine("You are gifted with 10% discount ! ");
//         }
//         else 
//         {
//             Console.WriteLine("You are gifted with 20% discount ! ");
//         }
//     }
// }

// using System;
// using System.Threading;

// class Program {
//     public static void Main(string[] args) {
//         //Alcohol Shop
//         Console.WriteLine("Welcome to the Alcohol Shop");
//         Console.WriteLine("Please enter your age :");
//         int age = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Please enter your country(USA/Other) :");
//         string Country = Console.ReadLine();
//         int Delay = 2000;
//         Thread.Sleep(Delay);
//         Console.WriteLine("Oookkkeeeyy....");
//         Thread.Sleep(Delay);
//         if (Country != "USA")
//         {
//             if (age >= 18)
//             {
//                 Console.WriteLine("You can buy alcohol");
//             }
//             else 
//             {
//                 Console.WriteLine("You can't buy alcohol");
//             }
//         }
//         else
//         {
//             if (age >= 21)
//             {
//                 Console.WriteLine("You can buy alcohol");
//             }
//             else 
//             {
//                 Console.WriteLine("You can't buy alcohol");
//             }
//         }
//     }
// }

// using System;
// using System.Threading;

// class Program {
//     public static void Main(string[] args) {
//         Console.WriteLine("Hi, input your age : ");
//         int Age = int.Parse(Console.ReadLine());
//         Console.WriteLine("Hi, input your year salary in $s : ");
//         double YearSalary = double.Parse(Console.ReadLine());
//         if (Age >= 18)
//         {
//             if (YearSalary >= 25000)
//             {
//                 Console.WriteLine("You are eligible for a loan");
//             }
//             else 
//             {
//                 Console.WriteLine("You are not eligible for a loan, but you can take loan if someone guaratees you");
//             }
//         }
//         else 
//         {
//             Console.WriteLine("You are not eligible for a loan");
//         }
//     }
// }
