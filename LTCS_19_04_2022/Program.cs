using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCS_19_04_2022
{
    class Program
    {
        
         public static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Hình tam giác: ");
            Console.WriteLine("2. Hình tứ giác: ");
            Console.WriteLine("3. Hình chữ nhật: ");
            Console.WriteLine("4. Hình vuông: ");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; Console.InputEncoding = Encoding.Unicode;


            Method method = new Method();

            int choose = -1;
            while (choose != 0)
            {
                Menu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    
                    case 1:
                        Console.WriteLine("Nhập 3 cạnh tam giác: ");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        method.Xuat(a, b, c);
                        break;

                    case 2:
                        Console.WriteLine("Nhập 4 cạnh tứ giác: ");
                        double a2 = double.Parse(Console.ReadLine());
                        double b2 = double.Parse(Console.ReadLine());
                        double c2 = double.Parse(Console.ReadLine());
                        double d2 = double.Parse(Console.ReadLine());
                        method.Xuat(a2, b2, c2, d2);
                        break;

                    case 3:
                        Console.WriteLine("Nhập 2 cạnh hình chữ nhật: ");
                        double a3 = double.Parse(Console.ReadLine());
                        double b3 = double.Parse(Console.ReadLine());
                        method.Xuat(a3, b3);
                        break;

                    case 4:
                        Console.WriteLine("Nhập cạnh hình vuông: ");
                        double a4 = double.Parse(Console.ReadLine());
                        method.Xuat(a4);
                        break;

                }
                
                   
            }
            Console.ReadKey();
        }
    }
}
