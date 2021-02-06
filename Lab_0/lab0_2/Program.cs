using System;

namespace lab0_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string DefangIPaddr = Console.ReadLine();
            DefangIPaddr = DefangIPaddr.Replace(".", "[.]");
            Console.WriteLine(DefangIPaddr);

        }
    }
}
