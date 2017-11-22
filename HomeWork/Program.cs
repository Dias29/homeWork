using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работа
            //Задание 1
            //Random rand = new Random();
            //int temp1;
            //temp1 = rand.Next(100);
            //int temp2;
            //temp2 = rand.Next(100);
            //int temp3;
            //temp3 = rand.Next(100);
            //Console.WriteLine(temp1+"  "+temp2+ "  " + temp3);

            //Задание 2
            //  Console.WriteLine("5\n10\n21");

            //Задание 3
            //Console.Write("Введите расстояние в см: ");
            //int distance = int.Parse(Console.ReadLine());
            //int cmInMeter = 100;
            //int meter = distance / cmInMeter;
            //Console.Write("Сдесь " + meter + " метров");

            //Задание 4
            //Console.WriteLine("C 01.04.2017 прошло 234 дня");
            //int days = 7;
            //int afterMoment = 234;
            //int week = afterMoment / days;
            //Console.Write("Всего недель прошло - " + week);

            //Задание 5
            //Console.Write("Введите двузначное число: ");
            //int x = int.Parse(Console.ReadLine());
            //int tenner = x / 10;
            //int unit = x % 10;
            //Console.WriteLine("Число десятков: "+tenner);
            //Console.Write("Число единиц: "+unit);


            //Задание 6
            //Console.WriteLine("A - true, B - false, C - falce");
            //bool A = true;
            //bool B = false;
            //bool C = false;
            //bool a = A || B;
            //bool b = A && B;
            //bool c = B || C;
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine("c = " + c);
            //Console.ReadLine();

            //Задание 7
            //Console.WriteLine("Введите радиус круга: ");
            //int rad = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите cторонy квадрата: ");
            //int b = int.Parse(Console.ReadLine());
            //var circle = 2 * 3.14 *rad;
            //var square = Math.Pow(b, 2);
            //Console.WriteLine("Площадь круга: " + circle);
            //Console.WriteLine("Площадь квадрата: " + square);
            //if (circle<square)
            //{
            //    Console.WriteLine("\nПлощадь квадрата больше!");
            //}
            //else
            //    Console.WriteLine("Площадь круга больше!");

            //Задание 8
            //Console.Write("Введите вид 1 материала: ");
            //string material = Console.ReadLine();
            //Console.Write("Введите массу: ");
            //var mass1 = int.Parse(Console.ReadLine());
            //Console.Write("Введите объем: ");
            //var volume1 = int.Parse(Console.ReadLine());
            //Console.Write("Введите вид 2 материала: ");
            //string materia2 = Console.ReadLine();
            //Console.Write("Введите массу: ");
            //var mass2 = int.Parse(Console.ReadLine());
            //Console.Write("Введите объем: ");
            //var volume2 = int.Parse(Console.ReadLine());
            //double density1 = mass1 / volume1;
            //double density2 = mass2 / volume2;
            //Console.WriteLine("Плотность 1 материала: " + density1 + " кг/м3");
            //Console.WriteLine("Плотность 2 материала: " + density2 + " кг/м3");
            //if(density1>density2)
            //{
            //    Console.WriteLine("Плотность 1 материала больше!");
            //}
            //else
            //{
            //    Console.WriteLine("Плотность 2 материала больше!");
            //}

            //Задание 9 аналогично с 8.

            //Задание 10
            //for (int i = 20; i < 36; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            //Console.Write("Введите предел чисел для возведения в квадрат: ");
            //int x = int.Parse(Console.ReadLine());
            //for(int i=10; i<x+1; i++)
            //{
            //             Console.Write(i+"^2 = "+Math.Pow(i, 2)+"\n");
            //}
            //Console.ReadKey();
            //Console.Write("Введите число старта для возведения в 3 степень: ");
            //int y = int.Parse(Console.ReadLine());
            //for(int i=y; i!=51; i++)
            //{
            //    Console.Write(i + "^3 = " + Math.Pow(i, 3) + "\n");
            //}
            //Console.ReadKey();
            Console.Write("Введите начало цифр: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конец цифр: ");
            int end = int.Parse(Console.ReadLine());
            for(int i = start; i<end+1; i++)
            {
                Console.Write(i + "\n");
            }
           

            Console.ReadLine();
        }
    }
}
