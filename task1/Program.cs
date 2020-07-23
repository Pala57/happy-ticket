using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int N;
            int right = 0;
            int left = 0;
            int tmp;
            int tmp1;
            int Sum = 0;
            bool f;
            do
            {
                Console.WriteLine("Ввести N= ");
                f = int.TryParse(Console.ReadLine(), out N);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);


            tmp = N % 10;



            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                {
                    tmp = N % 10;
                    right += tmp;
                    N /= 10;
                }
                else
                {
                    tmp = N % 10;
                    left += tmp;
                    N /= 10;
                }


            }
            if (right == left)
            {
                Console.WriteLine("Билет счастливий");
            }
            else
            {
                Console.WriteLine("Билет не счастливий");
            }



            Console.ReadKey();
        }
    }
}

