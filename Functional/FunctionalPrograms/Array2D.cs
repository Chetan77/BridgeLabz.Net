using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Array2D
    {
        public static int[,] Array2DElements()
        {
            Console.WriteLine("Enter size of rows and columns");
            int m = Utility.IntInput();
            int n = Utility.IntInput();
            int[,] a=new int[m,n];
            Console.WriteLine("enter array elements");
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i,j] = Utility.IntInput();
                }
            }
            Console.WriteLine("array elements are");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }
            return a;
        }
    }
}
