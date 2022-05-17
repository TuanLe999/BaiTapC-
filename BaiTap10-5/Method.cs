using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap10_5
{
    class Method

    {
        public int[] createArray(int[] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the number " + i + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

            return a;
        }
        public int max(int[] a, int n)
        {
            int m = a[1];
            for (int i = 1; i <= n; i++)
            {
                if (a[i] > m)
                    m = a[i];
            }
            return m;
        }

        public int min(int[] a, int n)
        {
            int m = a[1];
            for (int i = 1; i <= n; i++)
            {
                if (a[i] < m)
                    m = a[i];
            }
            return m;
        }

        public int count(int[] a, int n, int b)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (a[i] == b)
                    c = c + 1;
            }
            return c;
        }

        public int maxCount(int[] a, int n)
        {
            int m = count(a, n, a[1]);
            int b = a[1];
            for (int i = 1; i <= n; i++)
            {
                if (count(a, n, a[i]) > m)
                {
                    m = count(a, n, a[i]);
                    b = a[i];
                }
            }
            return b;
        }

        public void softMinMax(ref int[] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (a[j] < a[i])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
        }

        public void softMaxMin(ref int[] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (a[j] > a[i])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
        }

        public void display(int[] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine("");
        }

    }
}
