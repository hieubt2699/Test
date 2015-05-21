using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    class Program
    {
        static int[] ReadArray(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void WriteArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();
<<<<<<< HEAD
			//matthewtest
=======
			//abcdddd
>>>>>>> origin/master
        }
        static void Main(string[] args)
        {
            int[] arr;
            int n;
            Console.Write("Nhap vao gia tri n: ");
            n = int.Parse(Console.ReadLine());
            arr = ReadArray(n);
            WriteArray(arr, n);
            //hết phim
            //chán chủa, thấy ghét
        }
    }
}
