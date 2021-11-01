using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            int X = 0;
            int Y = 0;
            try
            {
                Console.Write("Первое число: ");
                X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Второе число число: ");
                Y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число");
            }
            //Console.WriteLine("Вы ввели X={0}", X);
            //Console.WriteLine("Вы ввели Y={0}", Y);
            Console.WriteLine("Введите номер команды:\n\t1:если сложение;\n\t2:если вычитание;\n\t3:если умножение;\n\t4:если деление;");
            int P = 0;
            try
            {
                Console.Write("Ваш выбор: ");
                P = Convert.ToInt32(Console.ReadLine());//юзер вводит значение;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число");
            }
            catch (Exception)
            {
                if (P<1 && P>4)
                {
                    Console.WriteLine("Вы ввели недопустимое значение");
                }
            }
            int Z;
            for (int i = 0; i < 4; i++)
            {
                if (P == 1)
                {
                    Plus(X, Y, out Z);
                    Console.WriteLine("Сумма равна {0}", Z);
                    break;
                }
                if (P == 2)
                {
                    Minus(X, Y, out Z);
                    Console.WriteLine("Разница равна {0}", Z);
                    break;
                }
                if (P == 3)
                {
                    Times(X, Y, out Z);
                    Console.WriteLine("Результат умножения равен {0}", Z);
                    break;
                }
                if (P == 4)
                {
                    int del=0;
                    try
                    {
                        Divid(X, Y, out Z);
                    }
                    catch (DivideByZeroException) when (Y==0)
                    {
                        Console.WriteLine("Значение второго числа не должно равняться 0");
                    }
                    int m = del;
                    Console.WriteLine("Результат деления равен {0}", m);
                    break;
                }
            }
            Console.ReadKey();
        }
        static void Plus(int X, int Y, out int Z)
        {
            Z = X + Y;
        }
        static void Minus(int X, int Y, out int Z)
        {
            Z = X - Y;
        }
        static void Times(int X, int Y, out int Z)
        {
            Z = X * Y;
        }
        static void Divid(int X, int Y, out int Z)
        {
            Z = X / Y;
        }
    }
}
