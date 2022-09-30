using System;

namespace ДЗ_24._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Чему равна длина окна? ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равна ширина окна? ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Чему равен диаметр круглой головы Васи? ");
            int d = int.Parse(Console.ReadLine());
            int srzn_window = Math.Min(a, b) - 1;
            if (d - srzn_window > 0)
                Console.WriteLine("Не пролезет");
            else
                Console.WriteLine("Пролезет");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 2");
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


            Console.WriteLine("Task 3");
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


            Console.WriteLine("Task 4");
            Console.Write("Введите строку ");
            string s1 = Console.ReadLine();
            char[] char1 = s1.ToCharArray();
            int n = 0;
            for (int i = 0; i < char1.Length; i++)
            {
                if (char.IsUpper(char1[i]))
                {
                    n++;
                }
            }
            if (n == char1.Length)
                Console.WriteLine($"\"{s1}\" -> True");
            else
                Console.WriteLine($"\"{s1}\" -> False");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 5");
            Console.WriteLine("Сколько овец хочешь посчитать? ");
            int num_sheep = int.Parse(Console.ReadLine());
                for (int i = 1; i < num_sheep+1; i++ )
                {
                Console.Write($"{i} овца... ");
                }
            Console.ReadKey();
            Console.Clear();


            //Console.WriteLine("Task 6");


            Console.WriteLine("Task 7");
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

            Console.WriteLine("Task 8");
            string[] dolls = { "Anabel", "Hello Kitty", "Barbie doll", "doll1", "doll2", "doll3" };
            int bag = 0;
            foreach (string doll in dolls)
            {
                if (doll == "Hello Kitty" || doll == "Barbie doll")
                    bag++;
            }
            Console.WriteLine(bag);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 9");
            Console.WriteLine("Введите номер дня недели ");
            try
            {
                int den = int.Parse(Console.ReadLine());
                switch (den)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        break;
                    case 2:
                        Console.WriteLine("Вторник");
                        break;
                    case 3:
                        Console.WriteLine("Среда");
                        break;
                    case 4:
                        Console.WriteLine("Четверг");
                        break;
                    case 5:
                        Console.WriteLine("Пятница");
                        break;
                    case 6:
                        Console.WriteLine("Суббота");
                        break;
                    case 7:
                        Console.WriteLine("Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Нет дня недели такого номера");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Попробуйте еще раз, введите число ");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 10");
            int[] bubble = { 52, 44, 13, 26, 1 };
            int var;
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = 0; j < bubble.Length - 1 - i; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        var = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = var;
                    }

                }
            }
            for (int k = 0; k < bubble.Length; k++)
            {
                Console.Write(bubble[k] + " ");
            }
            Console.ReadKey();
            Console.Clear();


            //Console.WriteLine("Задание 11");
            //int[] numers = { 1, 2, 4, 3, 5, 6, 7 };
            //int m = 0;
            //for (int q = 0; q < numers.Length - 1; q++)
            //{
                //if (numers[q] < numers[q + 1])
                    //m++;
                //else
                    //Console.WriteLine($"{q}");
                //break;



            }
           
    }
}
