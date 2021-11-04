using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPhoneNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<string> List1 = new List<string>();
            List<string> List2 = new List<string>();
            List<string> List3 = new List<string>();
            string format1 = "053";
            string format2 = "054";
            string format3 = "055";

            for (int j = 0; j <= 100; j++)
            {
                for (int i = 1; i <= 8; i++)
                {
                    format1 = format1 + r.Next(0, 9).ToString();
                    format2 = format2 + r.Next(0, 9).ToString();
                    format3 = format3 + r.Next(0, 9).ToString();
                }
                List1.Add(format1);
                List2.Add(format2);
                List3.Add(format3);
                format1 = "053";
                format2 = "054";
                format3 = "055";
            }

            foreach (var item in List1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");

            foreach (var item in List2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");

            foreach (var item in List3)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}
