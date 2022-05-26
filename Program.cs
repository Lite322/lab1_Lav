using lab1_Lav;
using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа даёт решение двух формул по заданным углам");
            Console.WriteLine("Формулы: z1 = (cos(a) - cos(b))^2 - (sin(a) - sin(b))^2 ");
            Console.WriteLine("z2 = -4sin^2((a-b)/2) * cos(a + b)");
            Console.WriteLine("Введите угол a:");
            double a = Convert.ToInt32(Console.ReadLine()); //угол α в градусах
            Console.WriteLine("Введите угол b:");
            double b = Convert.ToInt32(Console.ReadLine()); //угол β в градусах
            Console.WriteLine("Результат первой формулы");
            double z1 = Formuly.Form1(a, b); //первая формула
            double z11 = Math.Round(z1, 3); //округление до 3 знаков после запятой
            Console.WriteLine(z11);
            Console.WriteLine("Результат второй формулы");
            double z2 = Formuly.Form2(a, b); //вторая формула
            double z22 = Math.Round(z2, 3); //округление до 3 знаков после запятой
            Console.WriteLine(z22);
            Console.ReadLine();
        }
    }
}