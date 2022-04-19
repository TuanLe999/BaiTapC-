using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra1
{
    class Program
    {
        static void bai1()
        {
            Console.Write("Nhap a: ");
            double a_20 = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b_20 = double.Parse(Console.ReadLine());
            Console.WriteLine("Tong 2 so la: " + (a_20 + b_20));
            Console.WriteLine("Hieu 2 so la: " + (a_20 - b_20));
            Console.WriteLine("Tich 2 so la: " + (a_20 * b_20));
            Console.WriteLine("Thuong 2 so la: " + (a_20 / b_20));
        }

        static void bai2()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=                 *                   =");
            Console.WriteLine("=                ***                  =");
            Console.WriteLine("=          ***************            =");
            Console.WriteLine("=             *********               =");
            Console.WriteLine("=             **** ****               =");
            Console.WriteLine("=            ***     ***              =");
            Console.WriteLine("=           *           *             =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=======================================");
        }

        static void bai3()
        {
            int n_20, i_20, j_20, binno_20 = 0, dn_20;
            Console.Write("Nhap so bat ky: ");
            n_20 = int.Parse(Console.ReadLine());
            dn_20 = n_20;
            i_20 = 1;
            for (j_20 = n_20; j_20 > 0; j_20 = j_20 / 2)
            {
                binno_20 = binno_20 + (n_20 % 2) * i_20;
                i_20 = i_20 * 10;
                n_20 = n_20 / 2;
            }
            Console.Write("\nSo trong he nhi phan tuong duong cua {0} la : {1}.\n\n", dn_20, binno_20);
        }

        static void bai4()
        {
            Console.WriteLine("Ho va ten: Le Hoang Anh Tuan \nLop sinh hoat: 20T3 \nMSV: 2050531200320 ");

        }

   
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------Bai 1---------------------------- ");
            bai1();
            Console.WriteLine("--------------------------Bai 2---------------------------- ");
            bai2();
            Console.WriteLine("--------------------------Bai 3---------------------------- ");
            bai3();
            Console.WriteLine("--------------------------Bai 4---------------------------- ");
            bai4();
            Console.ReadKey();
        }
    }
}
