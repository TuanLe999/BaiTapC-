using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCoBan2
{
    class Program
    {
        static void Bai31()
        {
            for (int i = 1; i <= 10; ++i)
            {
                for (int j = 2; j <= 9; ++j)
                    Console.Write("{0,2}{1,2} x {2,2} = {3,2}", "|", j, i, i * j);
                Console.Write("{0}\n", "|");
            }
        }
        static void Bai37()
        {
            Console.Write("Nhap N: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int m = 0;
            for(int i = 1; i<n; i++)
            {
                s = s + i;
                if (s >= n)
                {
                    m = i-1;
                    s = s - i;
                    break;
                }
            }
            for(int i = 1; i < m; i++)
            {
                Console.Write(i + "+");
            }
            Console.Write(m + "=" + s + "<" + n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Bai 31--------------------");
            Bai31();
            Console.WriteLine("--------------------Bai 37--------------------");
            Bai37();
            Console.ReadKey();
        }
    }
}
