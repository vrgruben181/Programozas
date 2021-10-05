using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat21();
            //feladat22();
            feladat23();
            Console.WriteLine("Nyommd le az entert");
            Console.ReadLine();
        }
        static void feladat21()
        {
            for (int i = 1; i < 5; i++)
            {

            }

           
            
        }
        static void feladat22()
        {
            int a = 2;
            int b = 3;
            int c = 5;
            Console.WriteLine("a="+a+"cm");
            Console.WriteLine("b=" + b + "cm");
            Console.WriteLine("c=" + c + "cm");
            Console.WriteLine("Térfogat=" + a * b * c +"cm^2") ;
             a = a+1;
             b = b+2;
             c = c+3;
            Console.WriteLine("a=" + a + "cm");
            Console.WriteLine("b=" + b + "cm");
            Console.WriteLine("c=" + c + "cm");
            Console.WriteLine("Térfogat=" + a * b * c + "cm^2");
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine("a=" + a + "cm");
            Console.WriteLine("b=" + b + "cm");
            Console.WriteLine("c=" + c + "cm");
            Console.WriteLine("Térfogat=" + a * b * c + "cm^2");
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine("a=" + a + "cm");
            Console.WriteLine("b=" + b + "cm");
            Console.WriteLine("c=" + c + "cm");
            Console.WriteLine("Térfogat=" + a * b * c + "cm^2");
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine("a=" + a + "cm");
            Console.WriteLine("b=" + b + "cm");
            Console.WriteLine("c=" + c + "cm");
            Console.WriteLine("Térfogat=" + a * b * c + "cm^2");
        }
        static void feladat23()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Felszin {0}",i*i);
            }
        }
    }
}
