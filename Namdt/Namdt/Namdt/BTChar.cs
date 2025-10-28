using System;

namespace Namdt
{
    class BTChar
    {
        static void Main(string[] args)
        {
            char a;

            Console.Write("Nhap ky tu bac ky: ");
            a = char.Parse(Console.ReadLine());

            if (char.IsDigit(a))
                Console.WriteLine("Day la mot so!");
            else if (char.IsLetter(a))
                if (char.IsLower(a))
                    Console.WriteLine("Ket qua: "+ char.ToUpper(a));
                else
                    Console.WriteLine("Ket qua: "+ char.ToLower(a));
            else
            {
                Console.WriteLine("Day khong phai chu cai hoac so!");
            }

            Console.ReadLine();
        }
    }
}
