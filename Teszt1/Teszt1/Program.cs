using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");

            String[] szovegek = new string[5];
            String[] szovegek2 = szovegek;
            String[] szovegek3 = {"Egy","Ketto","Három" };

            szovegek[0] = "TT";
            Console.WriteLine(szovegek[0]);
            Console.WriteLine(szovegek2[0]);

            Console.ReadLine();

        }
    }
}
