using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vika_lthdt
{
    class BTCHAR
    {
        static void Main(string[] args)
        {
            Char a;
            Console.Write("Nhap mot ky tu bat ki : ");
            a = Char.Parse(Console.ReadLine());
            Console.WriteLine("ki tu ban ban vua nhap la : " +a);

            if (Char.IsDigit(a))
                Console.WriteLine("day la SO");


            else if (Char.IsLetter(a)) { 
}
            {
                if (Char.IsLower(a))
                     a = Char.ToUpper(a);
                else a = Char.ToLower(a);
            }
            Console.WriteLine(" ky tu tuong ung la : " + a);

            Console.ReadLine();
         }
        }
}
