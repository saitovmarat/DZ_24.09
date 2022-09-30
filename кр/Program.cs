using System;

namespace кр
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7");
            Console.Write("k = ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 6:
                        Console.WriteLine("Это шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Это семерка");
                        break;
                    case 8:
                        Console.WriteLine("Это восьмерка");
                        break;
                    case 9:
                        Console.WriteLine("Это девятка");
                        break;
                    case 10:
                        Console.WriteLine("Это десятка");
                        break;
                    case 11:
                        Console.WriteLine("Это валет");
                        break;
                    case 12:
                        Console.WriteLine("Это дама");
                        break;
                    case 13:
                        Console.WriteLine("Это король");
                        break;
                    case 14:
                        Console.WriteLine("Это туз");
                        break;
                    default:
                        Console.WriteLine("Карты под таким номером нет");
                        break;
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("k = number from 6 to 14 ");
            }
           
        } 
    }
}
