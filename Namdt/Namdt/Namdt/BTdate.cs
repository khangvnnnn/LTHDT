using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namdt
{
    class BTdate
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Shot Day " + today.ToShortDateString());
            Console.WriteLine("Long Day " + today.ToLongDateString());
            Console.WriteLine("Hom nay la ngay " + today.Day + "Thang" + today.Month + "Nam" + (today.Year));

            Console.ReadLine();
        }

    }
}
