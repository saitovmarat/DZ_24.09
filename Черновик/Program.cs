using System;

namespace Черновик
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            Console.Write("Какой год? ");
            int year = int.Parse(Console.ReadLine());
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
            if ((year % 4 == 0 & year % 100 != 0) || (year % 400 == 0))
            {
                if (day < 1 || day > 366)
                    Console.WriteLine("Ошибка. Такого дня в году нет");
                else if (day <= 31 && day >= 1)
                    Console.WriteLine(day + " января");
                else if (day <= 60 && day >= 32)
                    Console.WriteLine(day - jan + " февраля");
                else if (day <= 91 && day >= 61)
                    Console.WriteLine(day - jan - feb + " марта");
                else if (day <= 121 && day >= 92)
                    Console.WriteLine(day - jan - feb - mar + " апреля");
                else if (day <= 152 && day >= 122)
                    Console.WriteLine(day - jan - feb - mar - apr + " мая");
                else if (day <= 182 && day >= 153)
                    Console.WriteLine(day - jan - feb - mar - apr - may + " июня");
                else if (day <= 213 && day >= 183)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun + " июля");
                else if (day <= 244 && day >= 214)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul + " августа");
                else if (day <= 274 && day >= 245)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug + " сентября");
                else if (day <= 305 && day >= 275)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep + " октября");
                else if (day <= 335 && day >= 306)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep - oct + " ноября");
                else if (day <= 366 && day >= 336)
                    Console.WriteLine(day - jan - feb - mar - apr - may - jun - jul - aug - sep - oct - nov + " декабря");
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
