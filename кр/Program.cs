using System;

namespace кр
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1, 2, 3");
            Console.Write("Какой день в году? ");
            int day = int.Parse(Console.ReadLine());
            int jan = 31;
            int feb = 28;
            int mar = 31;
            int apr = 30;
            int may = 31;
            int jun = 30;
            int jul = 31;
            int aug = 31;
            int sep = 30;
            int oct = 31;
            int nov = 30;
                if (day < 1 || day > 365)
                    Console.WriteLine("Ошибка. Такого дня в году нет");
                else if (day <= 31 && day >= 1)
                    Console.WriteLine(day + " января");
                else if (day <= 59 && day >= 32)
                    Console.WriteLine(day - jan + " февраля");
                else if (day <= 90 && day >= 60)
                    Console.WriteLine(day - jan - feb + " марта");
                else if (day <= 120 && day >= 91)
                    Console.WriteLine(day - jan - feb - mar + " апреля");
                else if (day <= 151 && day >= 121)
                    Console.WriteLine(day - jan - feb - mar - apr + " мая");
                else if (day <= 181 && day >= 152)
                    Console.WriteLine(day - jan - feb - mar - apr - may + " июня");
                else if (day <= 212 && day >= 182)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun + " июля");
                else if (day <= 243 && day >= 213)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul + " августа");
                else if (day <= 273 && day >= 244)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug + " сентября");
                else if (day <= 304 && day >= 274)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep + " октября");
                else if (day <= 334 && day >= 305)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep - oct + " ноября");
                else if (day <= 365 && day >= 335)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep - oct - nov + " декабря");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 3");
            Console.Write("Какой год? ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Какой день в году? ");
            int day1 = int.Parse(Console.ReadLine());
            int jan1 = 31;
            int feb1 = 28;
            int mar1 = 31;
            int apr1 = 30;
            int may1 = 31;
            int jun1 = 30;
            int jul1 = 31;
            int aug1 = 31;
            int sep1 = 30;
            int oct1 = 31;
            int nov1 = 30;
            if ((year % 4 == 0 & year % 100 != 0) || (year % 400 == 0))
            {
                if (day1 < 1 || day1 > 366)
                    Console.WriteLine("Ошибка. Такого дня в году нет");
                else if (day1 <= 31 && day1 >= 1)
                    Console.WriteLine(day1 + " января");
                else if (day1 <= 60 && day1 >= 32)
                    Console.WriteLine(day1 - jan1 + " февраля");
                else if (day1 <= 91 && day1 >= 61)
                    Console.WriteLine(day1 - jan1 - feb1 + " марта");
                else if (day1 <= 121 && day1 >= 92)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 + " апреля");
                else if (day1 <= 152 && day1 >= 122)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 + " мая");
                else if (day1 <= 182 && day1 >= 153)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 + " июня");
                else if (day1 <= 213 && day1 >= 183)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 - jun1 + " июля");
                else if (day1 <= 244 && day1 >= 214)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 - jun1 - jul1 + " августа");
                else if (day1 <= 274 && day1 >= 245)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 - jun1 - jul1 - aug1 + " сентября");
                else if (day1 <= 305 && day1 >= 275)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 - jun1 - jul1 - aug1 - sep1 + " октября");
                else if (day1 <= 335 && day1 >= 306)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 - jun1 - jul1 - aug1 - sep1 - oct1 + " ноября");
                else if (day1 <= 366 && day1 >= 336)
                    Console.WriteLine(day1 - jan1 - feb1 - mar1 - apr1 - may1 - jun1 - jul1 - aug1 - sep1 - oct1 - nov1 + " декабря");
            }
            else
            {
                if (day < 1 || day > 365)
                    Console.WriteLine("Ошибка. Такого дня в году нет");
                else if (day <= 31 && day >= 1)
                    Console.WriteLine(day + " января");
                else if (day <= 59 && day >= 32)
                    Console.WriteLine(day - jan + " февраля");
                else if (day <= 90 && day >= 60)
                    Console.WriteLine(day - jan - feb + " марта");
                else if (day <= 120 && day >= 91)
                    Console.WriteLine(day - jan - feb - mar + " апреля");
                else if (day <= 151 && day >= 121)
                    Console.WriteLine(day - jan - feb - mar - apr + " мая");
                else if (day <= 181 && day >= 152)
                    Console.WriteLine(day - jan - feb - mar - apr - may + " июня");
                else if (day <= 212 && day >= 182)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun + " июля");
                else if (day <= 243 && day >= 213)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul + " августа");
                else if (day <= 273 && day >= 244)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug + " сентября");
                else if (day <= 304 && day >= 274)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep + " октября");
                else if (day <= 334 && day >= 305)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep - oct + " ноября");
                else if (day <= 365 && day >= 335)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep - oct - nov + " декабря");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
