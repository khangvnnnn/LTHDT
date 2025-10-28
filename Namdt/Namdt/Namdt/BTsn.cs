using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namdt
{
    class BTsn
    {
        static void Main(string[] args)
        {
            DateTime sn;
            DateTime today = DateTime.Now;

            Console.WriteLine("Nhap ngay thang nam sinh: ");
            sn = DateTime.Parse(Console.ReadLine());

            if (sn.Day == today.Day && sn.Month == sn.Month)
            {
                int tuoi = today.Year - sn.Year;
                Console.WriteLine("Hom nay la sinh nhat thu " + tuoi + "cua may! ");
            }
            else Console.WriteLine("Hom nay khong phai sinh nhat ban! ");

            Console.ReadLine();
        }

    }
}
