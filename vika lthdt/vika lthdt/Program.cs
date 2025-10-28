using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vika_lthdt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("nhap so thu nhat : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("nhap so thu hai : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "tong la : " + (a + b).ToString());
            Console.WriteLine(
                "hieu la : " + (a - b).ToString());
            Console.WriteLine(
                "tich la : " + (a * b).ToString());
            Console.WriteLine(
                "thuong la : " + (a / b).ToString());
            Console.ReadLine();
        }
    }
}
