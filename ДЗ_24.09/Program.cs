using System;

namespace ДЗ_24._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 *");
            Console.WriteLine("Чему равна длина окна? ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равна ширина окна? ");
            int b = int.Parse(Console.ReadLine());
            int d = Math.Min(a, b) - 1;
            Console.WriteLine($"Голова Васи должна быть как минимум диметром {d}, чтобы пролезть в окно");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 2 *");
            Console.Write("Напишите число: ");
            int num = int.Parse(Console.ReadLine());           
            Console.WriteLine($"Таблица умножения с числом {num}" + "\n" + 
             $"{num}*1 = {num*1}" + "\n" +
              $"{num}*2 = {num * 2}" + "\n" +
              $"{num}*3 = {num * 3}" + "\n" +
               $"{num}*4 = {num * 4}" + "\n" +
              $"{num}*5 = {num * 5}" + "\n" +
                $"{num}*6 = {num * 6}" + "\n" +
                $"{num}*7 = {num * 7}" + "\n" +
               $"{num}*8 = {num * 8}" + "\n" +
               $"{num}*9 = {num * 9}" + "\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 3 *");
            Console.Write("Напишите число: ");
            int numb = int.Parse(Console.ReadLine());
            if ((numb % 5 == 0) & (numb % 3 == 0))
                Console.WriteLine("БэнгБум");
            else if (numb % 3 == 0)
                Console.WriteLine("Бэнг");
            else if (numb % 5 == 0)
                Console.WriteLine("Бум");
            else
                Console.WriteLine("Мимо");
            Console.ReadKey();
            Console.Clear();

            // Console.WriteLine("Task 4");
            //  Console.WriteLine(" ");
            //  string a = Console.ReadLine();
            //  string[] arr = new string[a.Length];
            //   bool flag = true;
            //   for (int b = 0; b >= a.Length; b++)
            //  {
            //      if (Char.IsLower(a[b) || a[b] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0})
            //  }

            Console.WriteLine("Task 5 *");
            Console.WriteLine("Сколько овец хочешь посчитать? ");
            int num_sheep = int.Parse(Console.ReadLine());
                for (int i = 1; i < num_sheep+1; i++ )
                {
                Console.Write($"{i} овца... ");
                }
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("Task 6");
            // Console.WriteLine(" ");
            //   try
            // {   
            //   string[] posl = Console.ReadLine().Split(' ');
            //  int sum = 0;
            //  for (int a = 0; a < posl.Length; a++)
            //   {
            //      sum += posl[a];
            //   }
            //  }
            // catch ()
            // {
            //   Console.WriteLine("Впиши непустую последовательность неотрицательных целых чисел, оканчивающуюся отрицательным числом.");
            // }
            // finally
            // {
            //
            // }

            Console.WriteLine("Task 7 *");
            Console.Write("k = ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                switch (number)
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
            catch (System.FormatException)
            {
                Console.WriteLine("k = number from 6 to 14 ");
            }
            Console.ReadKey();
            Console.Clear();
        }
           
    }
}
