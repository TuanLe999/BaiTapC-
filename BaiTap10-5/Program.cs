
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();
            int []a = new int[11];
            a = method.createArray(a, 10);
            Console.Write("Aray: ");
            method.display(a, 10);
            Console.WriteLine("The max number is: " + method.max(a,10));
            Console.WriteLine("The min number is: " + method.min(a,10));
            Console.WriteLine("The number with the highest frequency is: " + method.maxCount(a,10));
            Console.WriteLine("The array when sorted in ascending order is: ");
            method.softMinMax(ref a, 10);
            method.display(a, 10);
            Console.WriteLine("The array when sorted in descending order is: ");
            method.softMaxMin(ref a, 10);
            method.display(a, 10);

            Console.ReadKey();

        }
    }
}
