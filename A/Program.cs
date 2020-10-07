using System;

namespace A
{

    class Program
    {

        static Random rnd = new Random();
        public static int[] CreateArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1, 2);
            }
            return array;
        }
        public static void ShowArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                
                if (i % 10 == 0 && i!=0)
                {
                    Console.WriteLine();
                }
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        public static int[] MergeArray(ref int[] A, ref int[] B)
        {
            int[] C = new int[Math.Max(A.Length, B.Length)];
            for(int i=0; i < C.Length;i++)
            {
                if(i%2==0 && i < A.Length)
                {
                    C[i] = A[i];
                }
                if(i%2==1 && i < B.Length)
                {
                    C[i] = B[i];
                }
            }
            return C;
        }
        static void Main(string[] args)
        {

            int[] A = CreateArray(int.Parse(Console.ReadLine()));
            int[] B = CreateArray(int.Parse(Console.ReadLine()));
            int [] C =MergeArray(ref A, ref B);

            Console.WriteLine("Массив A");
            ShowArray(ref A);
            Console.WriteLine("Массив B");
            ShowArray(ref B);
            Console.WriteLine("Массив C");
            ShowArray(ref C);

        }
    }
}
