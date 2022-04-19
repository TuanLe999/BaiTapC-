using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCoBan_2050531200320_LeHoangAnhTuan
{
    class Program
    {
        public static void Bai1()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int a_320;
            Console.Write("Nhập số nguyên: ");
            a_320 = int.Parse(Console.ReadLine());
            if (a_320 > 0)
            {
                Console.WriteLine("Đây là số nguyên dương!");
            }
            else
                Console.WriteLine("Đây là số nguyên âm!");
        }

        public static void Bai2()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int a_320;
            Console.Write("Nhập số nguyên: ");
            a_320 = int.Parse(Console.ReadLine());
            switch (a_320)
            {
                case 1: Console.WriteLine("Một."); break;
                case 2: Console.WriteLine("Hai."); break;
                case 3: Console.WriteLine("Ba."); break;
                case 4: Console.WriteLine("Bốn."); break;
                case 5: Console.WriteLine("Năm."); break;
                case 6: Console.WriteLine("Sáu."); break;
                case 7: Console.WriteLine("Bảy."); break;
                case 8: Console.WriteLine("Tám."); break;
                case 9: Console.WriteLine("Chín."); break;
                case 0: Console.WriteLine("Không."); break;

                default:
                    Console.WriteLine("Nhập số từ 0-9");
                    break;
            }
        }
        public static void Bai3()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập số thực a: ");
            double a_320 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực b: ");
            double b_320 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực c: ");
            double c_320 = double.Parse(Console.ReadLine());

            if ((a_320 + b_320 > c_320) && (a_320 + c_320 > b_320) && (b_320 + c_320 > a_320))
            {
                Console.WriteLine("a,b,c là 3 cạnh của tam giác!");
            }
            else
                Console.WriteLine("a,b,c không phải 3 cạnh của tam giác!");

        }
        public static void Bai4()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập số thực a: ");
            double a_320 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực b: ");
            double b_320 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực c: ");
            double c_320 = double.Parse(Console.ReadLine());

            if (((a_320 * a_320 + b_320 * b_320 == c_320 * c_320) || (a_320 * a_320 + c_320 * c_320 == b_320 * b_320) || (b_320 * b_320 + c_320 * c_320 == a_320 * a_320)) && ((a_320 + b_320 > c_320) && (a_320 + c_320 > b_320) && (b_320 + c_320 > a_320)))
            {
                Console.WriteLine("a,b,c là 3 cạnh của tam giác vuông!");
            }
            else
                Console.WriteLine("a,b,c không phải 3 cạnh của tam giác vuông!");

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("1.Bài 1: Kiểm tra số âm, dương. ");
            Console.WriteLine("2.Bài 2: In ra cách đọc một số nguyên từ 0-9. ");
            Console.WriteLine("3.Bài 3: Kiểm tra 3 số có phải cạnh của tam giác. ");
            Console.WriteLine("4.Bài 4: Kiểm tra 3 số có phải cạnh của tam giác vuông. ");
            Console.WriteLine("0.Thoát chương trình. ");
            int choose=1;
            while (choose != 0)
            {
                Console.Write("\nNhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("\nBài 1: Kiểm tra số âm, dương. ");
                        Bai1(); break;
                    case 2:
                        Console.WriteLine("\nBài 2: In ra cách đọc một số nguyên từ 0-9. ");
                        Bai2(); break;
                    case 3:
                        Console.WriteLine("\nBài 3: Kiểm tra 3 số có phải cạnh của tam giác. ");
                        Bai3(); break;
                    case 4:
                        Console.WriteLine("\nBài 4: Kiểm tra 3 số có phải cạnh của tam giác vuông. ");
                        Bai4(); break;
                    case 0: break;
                    default: Console.WriteLine("Nhập từ 0-4"); break;
                }

            }
            Console.ReadKey();
        }

    }
}
