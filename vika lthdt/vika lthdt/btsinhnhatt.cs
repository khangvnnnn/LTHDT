using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vika_lthdt
{
    class bt13
    {
        static void Main(string[] args)
        {
            DateTime ns;
            DateTime homnay = DateTime.Now;

            Console.Write("Nhap ngay thang nam sinh cua ban : ");
            ns = DateTime.Parse(Console.ReadLine());

            if (ns.Day == homnay.Day && ns.Month == homnay.Month)
            {
                int tuoi = homnay.Year - ns.Year;
                Console.WriteLine("Hom nay la sinh nhat thu " + tuoi + " cua ban :3 ");
            }
            else
                Console.WriteLine("Hom nay khong phai sinh nhat cua ban !");


            Console.ReadLine();
        }
    }
}
