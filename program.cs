using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class228
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[4, 5];
            Console.WriteLine("Исходная матрица: \n ");
            MyClass matrix = new MyClass(m);
            matrix.vivod(m);
            Console.WriteLine("\nКоличество строк = " + matrix.L);
            Console.WriteLine("Количество столбцов = "+ matrix.K);
            matrix.geta(m);
            Console.WriteLine("Конечная матрица: \n");
            matrix.vivod(m);
            Console.ReadLine();
        }
    }

    class MyClass
    {
        int[,] mm=new int[4,5];
        int l;
        int k;
        Random r = new Random();
        public MyClass(int[,] mm)
        {
            for (int i = 0; i < mm.GetLength(0); i++)
            {
                for (int j = 0; j < mm.GetLength(1); j++)
                {
                    mm[i, j] = r.Next(10, 100);
                }
            }
        }
        
        public int L
        {
            get
            {
                return this.mm.GetLength(0);
            }
        }
        public int K
        {
            get
            {
                return mm.GetLength(1);
            }
        }
        public int[,] geta(int [,]mm)
        {
            int[] a = new int[mm.GetLength(0)];
            int[] b = new int[mm.GetLength(0)];
            for (int i = 0; i < a.Length; i++)
                a[i] = mm[i, 0];
            for (int i = 0; i <b.Length; i++)
                b[i] = mm[i, 2];
            for (int i = 0; i < a.Length; i++)
            {
                mm[i, 0] = b[i];
                mm[i, 2] = a[i];
            }
                return mm;
        }

        public void vivod(int[,] mm)
        {
            for(int i=0;i<mm.GetLength(0);i++)
            {
                for (int j = 0; j < mm.GetLength(1); j++)
                    Console.Write(mm[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

