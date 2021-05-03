using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_Mini_Project
{
    class MinHeapClass
    {
        public static int heapSize;
        private static int Left(int i)
        {
            return 2 * i + 1;
        }
        private static int Right(int i)
        {
            return 2 * i + 2;
        }

        private static int ExtractMin(int[] A, int n)
        {
            if (heapSize == 0)
            {
                return A[0];
            }

            int root = A[0];

            if (heapSize > 1)
            {
                A[0] = A[n - 1];
                Heapify(A, n, 0);
            }
            heapSize--;

            return root;
        }

        private static void Heapify(int[] A, int n, int i)
        {
            int smallest = i;
            int l = Left(i);
            int r = Right(i);

            //left index is within array & left value is higher than index
            if (l < n && A[l] < A[smallest])
            {
                smallest = l;
            }

            //right index is within array & right value is higher than index
            if (r < n && A[r] < A[smallest])
            {
                smallest = r;
            }

            //if the left or the right was larger than index then swap and heapify smallest
            if (smallest != i)
            {
                int tmp = A[i];
                A[i] = A[smallest];
                A[smallest] = tmp;
                Heapify(A, n, smallest);
            }
        }

        private static void BuildMinHeap(int[] A, int n)
        {
            heapSize = n;
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                Heapify(A, n, i);
            }
        }

        public int MinHeap(int[] A, int n, int k)
        {
            int root = 0;
            BuildMinHeap(A, n);         //builds the heap


            for (int i = 0; i < k; i++)
            {
                root = ExtractMin(A, n);
            }

            return root;
        }

    }
}
