using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_Mini_Project
{
    class Interface
    {
        private static int[] GenRNGA(int length, int maxValue)
        {
            int[] rngA = new int[length];
            int currentNumber = 0;
            for (int i = 0; i < length; i++)
            {
                Random rng = new Random();
                currentNumber = rng.Next(maxValue);
                if (!rngA.Contains(currentNumber))
                {
                    rngA[i] = currentNumber;
                }
                else
                {
                    i--;
                }
            }

            return rngA;
        }

        static void Main(string[] args)
        {
            Console.Title = "Kth smallest Integer";

            int size = 100;
            int maxNumber = size + 1;
            int K = 0;

            //Generates an array with distinct numbers
            int[] A = GenRNGA(size, maxNumber);

            var m = new MinHeapClass();
            var n = new RandomizedSelectClass();

            Console.WriteLine("Unique Array Size : " + size);
            Console.WriteLine("K = " + K);
            Console.WriteLine();
            /*
            //Randomized Select Function
            int j = n.RandomizedSelect(A, 0, A.Length - 1, K);
            Console.WriteLine("Randomized Select");
            Console.WriteLine("Kth Smallest : " + j); */

            Console.WriteLine();
            
            //MinHeap Function
            int i = m.MinHeap(A, A.Length, K);
            Console.WriteLine("Min Heap");
            Console.WriteLine("Kth Smallest : " + i); 
        }
    }
}
