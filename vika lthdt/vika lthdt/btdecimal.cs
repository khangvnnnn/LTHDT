using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vika_lthdt
{
    class btdecimal
    {
        static void Main(string[] args)
        {
            decimal a;
            decimal b;
            Console.Write("Nhap so thap phan : ");
            a = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap so thap phan thu hai : ");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("so ban vua nhap la : " + a + " va " + b);
            Console.WriteLine("Tong = " + decimal.Add(a, b).ToString());
            Console.WriteLine("Hieu = " + decimal.Subtract(a, b).ToString());
            Console.WriteLine("Tich = " + decimal.Multiply(a, b).ToString());
            Console.WriteLine("Thuong = " + decimal.Divide(a, b).ToString());

            Console.WriteLine("Lam tron nguyen: " + decimal.Round(a));
            Console.WriteLine("Lam tron nguyen: " + decimal.Round(b));

            Console.WriteLine("Lam can tren: " + decimal.Ceiling(a));
            Console.WriteLine("Lam can tren: " + decimal.Ceiling(b));

            Console.WriteLine("Lam can duoi: " + decimal.Floor(a));
            Console.WriteLine("Lam can duoi: " + decimal.Floor(b));

            Console.ReadLine();

        }
    }
}
