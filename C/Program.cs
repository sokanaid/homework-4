using System;
using System.Dynamic;

namespace C
{
    class Program
    {
        /// <summary>
        /// Массив степеней двоек
        /// </summary>
        /// <param name="n">колличество элеменотов</param>
        /// <returns>Массив степеней двоек</returns>
        public static int[] CreateArray2(int n)
        {
            int[] array=new int [n];
            for(int i=1,j=0 ;j<n; i *= 2, j++)
            {
                array[j] = i;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            return array;
        }
        /// <summary>
        /// Массив нечетных элементов
        /// </summary>
        /// <param name="n">колличество элементов массива</param>
        /// <returns>Массив нечетных элементов</returns>
        public static int[] CreateArray1(int n)
        {
            int[] array = new int[n];
            for (int i = 1, j = 0; j < n; i+= 2, j++)
            {
                array[j] = i;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            return array;
        }
        /// <summary>
        /// массив вида a+k*d
        /// </summary>
        /// <param name="n">колличество элементов массива</param>
        /// <param name="a">число</param>
        /// <param name="d">число </param>
        /// <returns>массив</returns>
        public static int[] CreateArray3(int n,int a,int d)
        {
            int[] array = new int[n];
            for (int i = a, j = 0; j < n; i += d, j++)
            {
                array[j] = i;
            }
            for (int i =0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            return array;

        }
        /// <summary>
        /// Последовательность Фибоначи
        /// </summary>
        /// <param name="n">колличество элементов</param>
        /// <returns>массив</returns>
        public static int[] CreateArray4(int n)
        {
            int[] array = new int[n];
            array[0] = array[1] = 1;
            for (int j = 2; j < n; j++)
            {
                array[j] = array[j-1]+array[j-2];
            }
            for(int i=n-1; i>=0; i--)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
            return array;
        }
        static void Main(string[] args)
        {
            CreateArray2(6);
            CreateArray1(6);
            CreateArray3(6,2,1);
            CreateArray4(6);
        }
    }
}
