

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task10();
            Console.ReadLine();
        }

        private static void Task10()
        {
            for(int i = 20; i < 35;i++)
            {
                Console.WriteLine(i);
            }
            int a,b;

            Console.Write("C 10 до какого числа выводить квадраты чисел:");
            b = int.Parse(Console.ReadLine());
            for(int i = 10;i<b;i++)
            {
                Console.WriteLine(i * i);
            }

            Console.Write("С кого числа выводить третью степень числа до 50:");
            b = int.Parse(Console.ReadLine());
            for(int i = b;i<50;i++)
            {
                Console.WriteLine(i * i * i);
            }

            Console.Write("Ведите число с которого начинать выводить числа:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ведите чило до кокой выводить числа:");
            b = int.Parse(Console.ReadLine());
            for(int i = a;i<b;i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Task7()
        {
            int radius, storanaKv, ploshadKr,ploshadKv;
            Console.Write("Ведите радиус круга:");
            radius = int.Parse(Console.ReadLine());
            Console.Write("Ведите сторону квадрата:");
            storanaKv = int.Parse(Console.ReadLine());
            ploshadKr = (int)Math.PI * (radius * radius);
            ploshadKv = storanaKv * storanaKv;
            if(ploshadKv > ploshadKr)
            {
                Console.WriteLine("Площадь квадрата больше чем круга");
                Console.WriteLine(ploshadKv + ">" + ploshadKr);
            }
            else
            {
                Console.WriteLine("Площадь груга больше чем квадрата");
                Console.WriteLine(ploshadKv + "<" + ploshadKr);
            }

        }

        private static void Task6()
        {
            bool ACD, A = true, B = false, C = false;
            ACD = A && B;
            Console.WriteLine(ACD);
            ACD = A || B;
            Console.WriteLine(ACD);
            ACD = B && C;
            Console.WriteLine(ACD);
        }

        private static void Task5()
        {
            int chislo, disatki, edeniui, summa, proizvedenie, desit = 10;
            Console.Write("Ведите двух значное число ");
            chislo = int.Parse(Console.ReadLine());
            Console.Write("\nВ вашем числе: \na)");
            disatki = chislo / desit;
            Console.Write(disatki);
            Console.Write(" десяток \nb)");
            edeniui = chislo % desit;
            Console.Write(edeniui);
            Console.Write(" едениц \nc)сложение = ");
            summa = disatki + edeniui;
            Console.Write(summa);
            Console.Write("\nd)пройзведение = ");
            proizvedenie = disatki * edeniui;
            Console.Write(proizvedenie);
            Console.ReadLine();
        }

        private static void Task4()
        {
            int day = 234, week, sem = 7;
            Console.Write("С того момента прошло ");
            Console.Write(day);
            Console.Write(" дней или ");
            week = day / sem;
            Console.Write(week);
            Console.Write(" недель");
            Console.ReadLine();
        }

        private static void Task3()
        {
            int santimetr, metr, sto = 100;
            Console.Write("Ведите число в см :");
            santimetr = int.Parse(Console.ReadLine());
            metr = santimetr * sto;
            Console.WriteLine("Ваше число в метрах: " + metr);
        }

        private static void Task2()
        {
            int number1 = 5, number2 = 10, number3 = 21;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }

        private static void Task1()
        {
            int number1 = 5, number2 = 10, number3 = 15;
            Console.WriteLine(number1 + "  " + number2 + "  " + number3);
        }
    }
}

