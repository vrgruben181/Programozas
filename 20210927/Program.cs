using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210927
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            // feladat3();
            //feladat6();
            //feladat4();
            //feladat5();
            //feladat7();
            //feladat8();
            feladat9();
            Console.WriteLine("Nyomd le az entert");
            Console.ReadLine();
        }
        static void feladat1()
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 20; i ++);
            {
                Console.WriteLine("");
            }
           
        }
        static void feladat2()
        {
            for (int i = 15; i < 93; i++)
            {
                Console.WriteLine( ("0 "),i);
            }
        }
        static void feladat3()
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("{0}",i);
                }
            }
        }
       static void feladat4()
        {
            Console.WriteLine("Kérek egy számot");
            int a = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0}");
            }
        }
        static void feladat5()
        {
            Console.WriteLine("Kérek egy számot");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0}");
            }
    }
        static void feladat6()
        {
            int cv = 1;
            while (cv<16)
            {
                Console.WriteLine("{0}",cv*cv);
                cv++;
            }
            Console.WriteLine();
            cv = 1;
            do
            {
                Console.WriteLine("{0}", cv * cv);
                cv++;

            } while (cv<16);
            Console.ReadLine();
        }
        static void feladat7()
        
        {
            int szam = 100;
            while (szam<401)
            {
                if (szam % 4 == 0)
                {
                    Console.Write("{0}", szam);
                }
                szam++;
            }
            
           
        }
        static void feladat8()
        {
            for (int i = 30; i < 100; i=i+9)
            { 
                Console.WriteLine("{0}",i);

            }
          
        }
        static void feladat9()
        {
            for (int i = 150; i-12 > 40; i=i-12)
            {
                Console.WriteLine("{0}",i);
            }
        }
    }
}
