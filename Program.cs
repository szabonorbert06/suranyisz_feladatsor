using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace orai2
{
    internal class Program
    {
       

        static void F1()
        {
            Console.WriteLine("Hello Wordd");
        }

        static void F2()
        {
            string v = Console.ReadLine();
            Console.WriteLine("HI");
        }
        
        static void F3() {
            int szam1 = 0;
            Console.ReadLine();
            Console.WriteLine(szam1 * 2);

        }
        static void F4() { 
            int sz1= 0;
            Console.ReadLine();
            int sz2= 0;
            Console.ReadLine();
            Console.WriteLine("Összeg: ", sz1 + sz2);
            Console.WriteLine("Különbség: ", sz1 - sz2);
            Console.WriteLine("Szorzat: ", sz1 * sz2);
            Console.WriteLine("Hányados: ", sz1 / sz2);
             }

        static void F5()
        {
            int sza1= 0;
            Console.ReadLine();
            int sza2= 0;
            Console.ReadLine();
            if (sza1 < sza2) 
            Console.WriteLine(sza2);
            else
            Console.WriteLine(sza2);
        }

        static void F6()
        {
            int s1= 0;
            Console.ReadLine();
            int s2= 0;
            Console.ReadLine();
            int s3 = 0;
            Console.ReadLine();
            int[] i = {s1, s2, s3};
            int n = i.Length;
            int min;

            min = i[0];
            for(int i1 = 1; i1 < n; i1++)
                if (i[n] < min)
                    min = i[n];
            Console.WriteLine("A legkisebb szám: ", min);
        }

        static void F7() 
        {
            Console.Write("Háromszög első oldala: ");
            float a1 = float.Parse(Console.ReadLine());
            Console.Write("Háromszög második oldala: ");
            float a2 = float.Parse(Console.ReadLine());
            Console.Write("Háromszög harmadik oldala: ");
            float a3 = float.Parse(Console.ReadLine());

            if (a1 > 0 && a2 > 0 && a3 > 0)
            {
                Console.WriteLine("Készíthető háromszög");
            }
            else
            {
                Console.WriteLine("Nem lehet háromszöget szerkeszteni!");
            }
        }

        static void F8()
        {
            Console.Write("Elso szam: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Masodik szam: ");
            int b2 = int.Parse(Console.ReadLine());

            int szt = (b1 + b2) / 2;
            double mt = Math.Sqrt(b1 * b2);
            Console.WriteLine("$ Számtani közép: ", (szt));
            Console.WriteLine("$ Mértani közép: ", mt);

        }

        static void F9()
        {
            Console.Write("A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int C = int.Parse(Console.ReadLine());

            double D = Math.Sqrt(B * B) - 4 * (A * C);
        }

        static void F10()
        {

        }

        static void Main(string[] args)
        {
            F1();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
            F8();
            F9();
            F10();

        }
    }
}

    

