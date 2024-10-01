// E1

//for (int i = 1; i < 100; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 2; i < 50; i = i + 2)
//{
//    Console.WriteLine(i);
//}

// E2

//int i = 1;
//int sum = 0;
//while (i <= 50)
//{
//    sum += i;
//    i++;
//}
//Console.WriteLine($"The sum of numbers from 1 to 50 is: {sum}");


//int sum = 0;
//int count = 0;
//while (count < 5)
//{
//    Console.Write("Input Number: ");
//    int number = int.Parse(Console.ReadLine());
//    sum += number;
//    count++;
//}
//Console.WriteLine($"Sum is: {sum}");

// E3

//decimal num = 0;
//do
//{
//    Console.Write("Please, input number below 10 or...");
//    num = decimal.Parse(Console.ReadLine());
//} while (num > 10);
//Console.WriteLine("Yo, that's correct ! ");

//decimal Question = 0;
//do
//{
//    Console.Write("Do you want to continue? (Yes/No): ");
//    string YesOrNo = Console.ReadLine();
//    if (YesOrNo.ToLower() == "yes")
//    {
//        Question++;
//    }
//    else if (YesOrNo.ToLower() == "no")
//    {
//        Console.WriteLine("Ok, Goodbye then!");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
//    }
//} while (Question < 3);

// E4

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}

// PE1

//decimal Price = 0;
//decimal Sum = 0;
//string YesOrNo;
//do
//{
//    Console.WriteLine("Please, input price of product :");
//    Price = decimal.Parse(Console.ReadLine());
//    Sum += Price;
//    Console.WriteLine("Do you want to continue ?");
//    YesOrNo = Console.ReadLine();
//} while (YesOrNo == "Yes");
//Console.WriteLine($"Total Price is {Sum} dollars.");

// PE2

//class AverageScore
//{
//   static void Main()
//    {
//        FirstMethod();
//    }
//    static void FirstMethod()
//    {
//        decimal Score = 0;
//        decimal Sum = 0;
//        decimal AvScore = 0;
//        decimal SubjectCounter = 0;
//        string YesOrNo;
//        do
//        {
//            Console.WriteLine($"Please input {SubjectCounter} subject score : ");
//            Score = decimal.Parse(Console.ReadLine());
//            Console.WriteLine("Do you want to continue ?(Yes/No) : ");
//            YesOrNo = Console.ReadLine();
//            SubjectCounter++;
//            Sum += Score;
//            AvScore = Sum / SubjectCounter;
//        } while ( YesOrNo == "Yes" );
//        Console.WriteLine($"Your average score is {AvScore} points...");
//    }
//}

// PE3

//class BankTransactions()
//{
//    static void Main()
//    {
//        TransactionCode();
//    }
//    static void TransactionCode()
//    {
//        decimal Balance = 230500;
//        string YesOrNo;
//        decimal Expenditure = 0;
//        decimal Income = 0;
//        decimal AmountOfMoney = 0;
//        do
//        {
//            Console.WriteLine("Do you want to add money to your balance ?(Yes/No) : ");
//            YesOrNo = Console.ReadLine();
//            if (YesOrNo == "Yes")
//            {
//                Console.WriteLine("How much ? : ");
//                AmountOfMoney = decimal.Parse(Console.ReadLine());
//                Income += AmountOfMoney;
//            }
//            else
//            {
//                Console.WriteLine("Do you want to take out money from your balance ?(Yes/No) : ");
//                YesOrNo = Console.ReadLine();
//                if (YesOrNo == "Yes")
//                {
//                    Console.WriteLine("How much ? : ");
//                    AmountOfMoney = decimal.Parse(Console.ReadLine());
//                    Expenditure += AmountOfMoney;
//                }
//                else
//                {
//                    Console.WriteLine("Goodbye then !");
//                }
//            }
//            Console.WriteLine("Do you want to do some transactions again ? : ");
//            YesOrNo = Console.ReadLine();
//        } while (YesOrNo == "Yes");
//        Balance -= Expenditure;
//        Balance += Income;
//        Console.WriteLine($"Alright then, your current balance is {Balance}$...");
//    }
//}
