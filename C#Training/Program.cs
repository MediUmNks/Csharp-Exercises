//Console.WriteLine("How many stars do you want to show?");

//int x = int.Parse(Console.ReadLine());
//int y = 0;
//while (y < x)
//{
//    Console.Write("*");
//    y++;
//}




//int res;
//do
//{
//    Console.WriteLine("Please choose your favorite game!! 1 or 2");
//    res = int.Parse(Console.ReadLine());
//    if (res == 1)
//    {
//        Console.WriteLine("Playing game 1");
//    }
//    else if (res == 2)
//    {
//        Console.WriteLine("Playing game 2");
//    }
//} while (res != 0);




//___________Fibonucci Number___________
//Console.WriteLine("Plese enter a number then we give you Fibonachi Number match the number you entered!!!");

//int FiboNumber = Convert.ToInt32(Console.ReadLine());

//if (FiboNumber <= 0)
//{
//    Console.WriteLine("Please enter a positive number");
//}
//else
//{
//    int[] Fibo = new int[FiboNumber];
//    if (FiboNumber >= 1)
//    {
//        Fibo[0] = 1;
//    }
//    if (FiboNumber >= 2)
//    {
//        Fibo[1] = 1; 
//    }
//    for (int i = 2; i < FiboNumber; i++)
//    {
//        Fibo[i] = Fibo[i - 1] + Fibo[i - 2];
//    }

//    Console.WriteLine($"the {FiboNumber}th Fibunachi Number is {Fibo[FiboNumber - 1]}");

//    Console.WriteLine("The sequence: " + string.Join(", ", Fibo));
//}



//int[] numbers = [1, 5, 8, 9, 12, 1578, 3648];
//string num = string.Join(", ",numbers);
//Console.WriteLine(num);


//Console.WriteLine("How many number from Fibonacci Numbers do you want?");
//int res = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("===================================================");
//if (res <= 0)
//{
//    Console.WriteLine("Pleaes Enter a Positive Number");
//}
//else
//{
//    int[] FibonacciNumber = new int[res];

//    if (res >= 1)
//    {
//        FibonacciNumber[0] = 1;
//    }
//    if (res >= 2)
//    {
//        FibonacciNumber[1] = 1;
//    }

//    for (int i = 2; i < res; i++)
//    {
//        FibonacciNumber[i] = FibonacciNumber[i - 1] + FibonacciNumber[i - 2];
//    }
//    for (int i = FibonacciNumber.Length - 1; i >= 0; i--)
//    {
//        Console.WriteLine(FibonacciNumber[i]);
//    }

//}

//string name = "Mohammad Mahdi ";
//string lastname = "Nakhei";
//string fullname = string.Concat(name, lastname);
//char show = name[3];
//int show2 = lastname.IndexOf('k');
//string sub = name.Substring(9, 5);
//Console.WriteLine(sub);
//Console.ReadKey();



//methodes
//<access specifire> <return type> Methode Name(<Parameters>)
//{
//Methode Body and return statement
//}




//Practic


        //public class Program
        //{
        //    public static void Main(String[] args)
        //    {
        //        List<double> weeklytemp = GetWeekleyTemperature();
        //        Console.WriteLine($"The avrage of this week is {CalculateAvarageOfTemp(weeklytemp)}");
        //    }

        //    public static List<double> GetWeekleyTemperature()
        //    {
        //        List<double> temperature = new List<double>();
        //        string[] days = new string[7] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        //        for (int i = 0; i < days.Length; i++)
        //        {
        //            Console.WriteLine($"Please enter the temperatures of {days[i]}   (Celsius)");
        //            if (double.TryParse(Console.ReadLine(), out double temp))
        //            {
        //                temperature.Add(temp);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Please enter a number");
        //            }
        //        }
        //        return temperature;

        //    }
        //    public static double CalculateAvarageOfTemp(List<double> temp)
        //    {
        //        double sum = 0;
        //        foreach(double t in temp)
        //        {
        //            sum += t;
        //        }
        //        if(temp.Count== 0)
        //        {
        //            return 0;
        //        }
        //        return sum / temp.Count;
        //    }
        //}