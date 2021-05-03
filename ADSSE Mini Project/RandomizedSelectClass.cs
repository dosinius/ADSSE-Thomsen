using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSSE_Mini_Project
{
    class RandomizedSelectClass
    {
        private static int Partition(int[] A, int p, int r)
        {
            int x = A[r];
            int i = p;
            int tmp;

            for (int j = p; j < r; j++)
            {
                if (A[j] <= x)
                {
                    tmp = A[j];
                    A[j] = A[i];
                    A[i] = tmp;
                    i++;
                }
            }

            A[r] = A[i];
            A[i] = x;

            return i;
        }

        private static int RandomizedPartition(int[] A, int p, int r)
        {
            Random random = new Random();
            int i = random.Next(p, r);

            int tmp = A[i];
            A[i] = A[r];
            A[r] = tmp;

            return Partition(A, p, r);
        }
        public int RandomizedSelect(int[] A, int p, int r, int i)
        {
            if (p == r)
            {
                return A[p];
            }
            int q = RandomizedPartition(A, p, r);
            int k = q - p + 1;
            if (i == k)
            {
                return A[q];
            }
            else if (i < k)
            {
                return RandomizedSelect(A, p, q - 1, i);
            }
            else return RandomizedSelect(A, q+1, r, i-k);
        }
    }
}
