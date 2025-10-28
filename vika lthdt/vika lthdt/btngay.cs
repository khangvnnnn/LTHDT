using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vika_lthdt
{
    class btngay
    {
        static void Main(string[] args)
        {
            DateTime homnay = DateTime.Now;

            Console.WriteLine("Short Day : " + homnay.ToShortDateString());

            Console.WriteLine("Long Day : " + homnay.ToLongDateString());

            Console.WriteLine("Hom nay la ngay " + homnay.Day +" thang " + homnay.Month + " nam " + homnay.Year);

            Console.ReadLine();
            }
        }
}
