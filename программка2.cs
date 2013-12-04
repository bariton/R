using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] mas = new int[12, 12] { { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9 }, { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, };



            int X, X1, Y, Y1;
            Console.WriteLine("Введите Х от 1 до 8");
            X = Convert.ToInt32(Console.ReadLine()) + 1;
            Console.WriteLine("Введите Y от 1 до 8");
            Y = Convert.ToInt32(Console.ReadLine()) + 1;
            Console.WriteLine("Введите Х1 от 1 до 8");
            X1 = Convert.ToInt32(Console.ReadLine()) + 1;
            Console.WriteLine("Введите Y1 от 1 до 8");
            Y1 = Convert.ToInt32(Console.ReadLine()) + 1;



            mas[X, Y] = 0;
            int Ni = 0;
            for (int M = 0; M < 6; M++)
            {

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (mas[i, j] == M)
                        {
                            if (mas[i + 2, j + 1] == 8)
                            {
                                mas[i + 2, j + 1] = Ni + 1;
                            }
                            if (mas[i + 2, j - 1] == 8)
                            {
                                mas[i + 2, j - 1] = Ni + 1;
                            }
                            if (mas[i - 2, j + 1] == 8)
                            {
                                mas[i - 2, j + 1] = Ni + 1;
                            }
                            if (mas[i - 2, j - 1] == 8)
                            {
                                mas[i - 2, j - 1] = Ni + 1;
                            }
                            if (mas[i + 1, j + 2] == 8)
                            {
                                mas[i + 1, j + 2] = Ni + 1;
                            }
                            if (mas[i + 1, j - 2] == 8)
                            {
                                mas[i + 1, j - 2] = Ni + 1;
                            }
                            if (mas[i - 1, j - 2] == 8)
                            {
                                mas[i - 1, j - 2] = Ni + 1;
                            }
                            if (mas[i - 1, j + 2] == 8)
                            {
                                mas[i - 1, j + 2] = Ni + 1;
                            }
                        }
                    }
                }
                Ni += 1;
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("i=" + mas[X1, Y1]);
            Console.ReadKey();

        }
    }
}
