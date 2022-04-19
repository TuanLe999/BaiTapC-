using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMang
{
    class Program
    {
        static void print_array(int[] a_320, int n_320)
        {
            Console.Write("arr[] = ");
            for (int i_320 = 0; i_320 < n_320; i_320++)
            {
                Console.Write("{0} ", a_320[i_320]);

            }
        }

        static int[] create_array(int n_320)
        {

            Random random = new Random();
            int[] arr_320 = new int[n_320];
            for (int i_320 = 0; i_320 < n_320; i_320++)
            {
                arr_320[i_320] = (random.Next(100 - (-100 - 1)) - 100);
            }
            return arr_320;
        }

        static void Bai_61()
        {
            Console.WriteLine("\n------------Bai 61--------------\n");
            int s_320 = 0;
            Console.Write("Nhập số phần tử của mảng: ");
            int n_320 = int.Parse(Console.ReadLine());
            int[] arr_320 = create_array(n_320);
            print_array(arr_320, n_320);
            foreach (int a_320 in arr_320)
            {
                if (a_320 >= 0)
                    s_320 = s_320 + a_320;
            }

            Console.WriteLine("\nTổng các số nguyên dương trong mảng: " + s_320);
            Console.Write("Nhập vị trí phần tử muốn xóa: ");
            int c_320 = 0;
            int pos_320 = int.Parse(Console.ReadLine());
            while (c_320 != pos_320 - 1)
                c_320++;
            while (c_320 < n_320 - 1)
            {
                arr_320[c_320] = arr_320[c_320 + 1];
                c_320++;
            }
            n_320--;
            print_array(arr_320, n_320);
        }

        static void Bai_63()
        {
            Console.WriteLine("\n------------Bai 63--------------\n");
            Console.Write("Nhập số phần tử của mảng: ");
            int n_320 = int.Parse(Console.ReadLine());
            int[] arr_320 = create_array(n_320);
            print_array(arr_320, n_320);
            int count_320 = 0;
            foreach (int i_320 in arr_320)
            {
                if (i_320 % 4 == 0 && i_320 % 10 == 6)
                    count_320++;
            }
            Console.WriteLine("\nCó {0} phần tử chia hết cho 4 và có tận cùng là 6!", count_320);
            for (int i_320 = 0; i_320 < arr_320.Length; i_320++)
            {
                if (arr_320[i_320] % 2 != 0)
                    arr_320[i_320] = arr_320[i_320] * 2;
            }
            Console.WriteLine("Nhân đôi phần tử lẻ: ");
            print_array(arr_320, n_320);
            Console.WriteLine("\n--------------------------------\n");
        }
        static void Bai59()
        {
            Console.WriteLine("\n------------Bai 59--------------\n");
            int n_320;
            String[] can_320 = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            String[] chi_320 = { "Thân", "Dậu", "Tuất", "Hợi", "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            Console.Write("Nhập năm: ");
            n_320 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} {2}\n", n_320, can_320[n_320 % 10], chi_320[n_320 % 12]);
            Console.WriteLine("{0} - {1} {2}\n", n_320 + 60, can_320[n_320 % 10], chi_320[n_320 % 12]);
            Console.WriteLine("\n--------------------------------\n");
        }



        static float average(int[] a_320)
        {
            int s_320 = 0;
            int d_320 = 0;
            for (int i = 0; i < a_320.Length; i++)
            {
                if (a_320[i] < 0 && a_320[i] % 2 != 0)
                {
                    s_320 = s_320 + a_320[i];
                    d_320 = d_320 + 1;
                }
            }

            float t = (float)(s_320 / (d_320 * 1.0));
            return t;
        }


        static void remove_duplicates(int[] a_320, ref int n_320)
        {
            int i_320, j_320, k_320;
            for (i_320 = 0; i_320 < n_320 - 1; i_320++)
            {
                j_320 = i_320 + 1;
                while (j_320 < n_320)
                    if (a_320[i_320] == a_320[j_320])
                    {
                        for (k_320 = j_320; k_320 < n_320 - 1; k_320++)
                        {
                            a_320[k_320] = a_320[k_320 + 1];
                        }
                        n_320 = n_320 - 1;
                    }
                    else j_320 = j_320 + 1;
            }
        }
        static void Bai_65()
        {
            Console.WriteLine("\n------------Bai 65--------------\n");

            Console.Write("Nhập số phần tử của mảng: ");
            int n_320 = int.Parse(Console.ReadLine());
            int[] arr_320 = new int[n_320];
            for (int i = 0; i < n_320; i++)
            {
                arr_320[i] = int.Parse(Console.ReadLine());

            }
            print_array(arr_320, n_320);
            Console.WriteLine("TBC số nguyên âm lẻ : {0}", average(arr_320));
            Console.Write("\n\n");
            Console.WriteLine("Mảng sau khi xóa là:");
            remove_duplicates(arr_320, ref n_320);
            print_array(arr_320, n_320);
        }


        static void sort_arrray(int[] a_320)
        {
            int i_320, j_320, t_320;
            for (i_320 = 0; i_320 < a_320.Length - 1; ++i_320)
            {
                for (j_320 = i_320 + 1; j_320 < a_320.Length; ++j_320)
                {
                    if (((a_320[i_320] % 2 == 0) && (a_320[j_320] % 2 == 0) && (a_320[i_320] > a_320[j_320])) || (((a_320[i_320] % 2 != 0) && (a_320[j_320] % 2 != 0) && (a_320[i_320] < a_320[j_320]))))
                    {
                        t_320 = a_320[i_320];
                        a_320[i_320] = a_320[j_320];
                        a_320[j_320] = t_320;
                    }

                }
            }

            print_array(a_320, a_320.Length);
        }

        static void Bai_67()
        {
            Console.WriteLine("\n------------Bai 67--------------\n");
            Console.Write("Nhập số phần tử của mảng: ");
            int n_320 = int.Parse(Console.ReadLine());
            int[] arr_320 = create_array(n_320);
            print_array(arr_320, n_320);
            Console.WriteLine("\nMảng sau khi sắp xếp: ");
            sort_arrray(arr_320);

        }
        static void showMenu()
        {
            Console.WriteLine("\n------MENU------");
            Console.WriteLine("1. Bài 59");
            Console.WriteLine("2. Bài 61");
            Console.WriteLine("3. Bài 63");
            Console.WriteLine("4. Bài 65");
            Console.WriteLine("5. Bài 67");
            Console.WriteLine("6. Thoát");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose=0;
            while (choose!=6)
            {
                showMenu();
                Console.Write("Nhập lựa chọn: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Bai59();
                        break;
                    case 2:
                        Bai_61();
                        break;
                    case 3:
                        Bai_63();
                        break;
                    case 4:
                        Bai_65();
                        break;
                    case 5:
                        Bai_67();
                        break;
                    case 6: break;
                }
            }
            Console.ReadKey();
        }
    }
}
