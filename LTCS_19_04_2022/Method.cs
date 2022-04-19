using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCS_19_04_2022
{
    class Method
    {
        public void Xuat(double a, double b, double c)
        {
            Console.WriteLine("Tam giác có độ dài các cạnh là: {0}, {1}, {2} ", a,b,c);
        }

        public void Xuat(double a, double b, double c, double d)
        {
            Console.WriteLine("Tứ giác có độ dài các cạnh là: {0}, {1}, {2}, {3} ", a,b,c,d);
        }


        public void Xuat(double a, double b)
        {
            double d=0, r=0;
            if (a > b)
            {
                d = a;
                r = b;
            }

            if (b > a)
            {
                d = b;
                r = a;
            }

            Console.WriteLine("Hình chữ nhật có chiều dài {0} và chiều rộng là {1} ", d, r);
        }

        public void Xuat(double a)
        {
            Console.WriteLine("Hình vuông có độ dài các cạnh là: {0} ", a);
        }

    }
}
