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
