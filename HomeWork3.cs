// T1

//using System.ComponentModel;

//class Task1()
//{
//    static void Main()
//    {
//        Function1();
//    }
//    static void Function1()
//    {
//        string YesOrNo;
//        int SummedSalary = 0;
//        List<string> HardWorkersList = new List<string>();
//        do
//        {
//            Console.WriteLine("Hey, tell us your full name first : ");
//            string FullName = Console.ReadLine();
//            Console.WriteLine("Please, tell us how many full hours did you work today in sum ? : ");
//            int WorkedHour = int.Parse(Console.ReadLine());
//            int NormalSalaryPerHour = 40;
//            int BonusSalaryPerHour = 40 * 125 / 100;
//            if (WorkedHour <= 8 && WorkedHour > 0)
//            {
//                SummedSalary = WorkedHour * NormalSalaryPerHour;
//            }
//            else if (WorkedHour > 8)
//            {
//                int ExtraWorkedTime = WorkedHour - 8;
//                SummedSalary = 8 * NormalSalaryPerHour + ExtraWorkedTime * BonusSalaryPerHour;
//                HardWorkersList.Add(FullName);
//            }
//            else
//            {
//                Console.WriteLine("You either worked 0 full hours or you are just messing with me and try to brake my console app by putting negative numbers or letters/symbols... GET OUT !");
//            }
//            Console.WriteLine("Do you want to calculate another persons salary ?(Yes/No) : ");
//            YesOrNo = Console.ReadLine();
//        } while (YesOrNo == "Yes");
//        Console.WriteLine($"Your Salary is {SummedSalary}$ ; List of HardWorkers : {HardWorkersList}");
//    }
//}

// T2

//class Task2()
//{
//    static void Main()
//    {
//        Function2();
//    }
//    static void Function2()
//    {
//        string Product1name;
//        string Product2name;
//        string Product3name;
//        decimal Product1available;
//        decimal Product2available;
//        decimal Product3available;
//        decimal Product1price;
//        decimal Product2price;
//        decimal Product3price;
//        Console.WriteLine("Please input Product 1 name : ");
//        Product1name = Console.ReadLine();
//        Console.WriteLine("Please input Product 1 quantity : ");
//        Product1available = decimal.Parse(Console.ReadLine());
//        Console.WriteLine("Please input Product 1 price : ");
//        Product1price = decimal.Parse(Console.ReadLine());
//        Console.WriteLine("Please input Product 2 name : ");
//        Product2name = Console.ReadLine();
//        Console.WriteLine("Please input Product 2 quantity : ");
//        Product2available = decimal.Parse(Console.ReadLine());
//        Console.WriteLine("Please input Product 2 price : ");
//        Product2price = decimal.Parse(Console.ReadLine());
//        Console.WriteLine("Please input Product 3 name : ");
//        Product3name = Console.ReadLine();
//        Console.WriteLine("Please input Product 3 quantity : ");
//        Product3available = decimal.Parse(Console.ReadLine());
//        Console.WriteLine("Please input Product 3 price : ");
//        Product3price = decimal.Parse(Console.ReadLine());
//        if (Product1price > 0 && Product2price > 0 && Product3price > 0 && Product1available >= 0 && Product2available >= 0 && Product3available >= 0)
//        {
//            decimal Product1sum = Product1available * Product1price;
//            decimal Product2sum = Product2available * Product2price;
//            decimal Product3sum = Product3available * Product3price;
//            decimal ProductsPriceSum = Product1sum + Product2sum + Product3sum;
//            Console.WriteLine($"{Product1name} sum is {Product1sum} ,{Product2name} sum is {Product2sum} ,{Product3name} sum is {Product3sum} , full price of everything summed is {ProductsPriceSum} .");
//        }
//        else
//        {
//            Console.WriteLine("You have told us that either price is <= 0 or quantity is negative, try again !");
//        }
//    }
//}
