using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            int[] mas = new int[10];
            for (int i = 0; i != 10; i++)
            {
                Console.WriteLine("Введите элемент массива {0}", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ваш массив");
            Output(mas);

            int N, K=0;
            Console.WriteLine("введите N");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (N == mas[i])
                {
                    
                    Console.WriteLine("i=" + i);
                   
                    K += 1;
                    
                    
                }
                
            }
            if(K==0)
            {
                Console.WriteLine("-1");
            }


            Console.ReadKey();
        }
        
    }
}
