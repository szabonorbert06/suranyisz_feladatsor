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

        static void F3()
        {
            int szam1 = 0;
            Console.ReadLine();
            Console.WriteLine(szam1 * 2);

        }
        static void F4()
        {
            int sz1 = 0;
            Console.ReadLine();
            int sz2 = 0;
            Console.ReadLine();
            Console.WriteLine("Összeg: ", sz1 + sz2);
            Console.WriteLine("Különbség: ", sz1 - sz2);
            Console.WriteLine("Szorzat: ", sz1 * sz2);
            Console.WriteLine("Hányados: ", sz1 / sz2);
        }

        static void F5()
        {
            int sza1 = 0;
            Console.ReadLine();
            int sza2 = 0;
            Console.ReadLine();
            if (sza1 < sza2)
                Console.WriteLine(sza2);
            else
                Console.WriteLine(sza2);
        }

        static void F6()
        {
            int s1 = 0;
            Console.ReadLine();
            int s2 = 0;
            Console.ReadLine();
            int s3 = 0;
            Console.ReadLine();
            int[] i = { s1, s2, s3 };
            int n = i.Length;
            int min;

            min = i[0];
            for (int i1 = 1; i1 < n; i1++)
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
            int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;
        }

        static void F10()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Van megoldás");
                    else
                        Console.WriteLine("Nincs megoldás");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine(x);
                }
            }
        }
        static void F11() 
        {
            Console.WriteLine("A két oldal hossza: ");

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Az átfogó hossza: ", c);
        }
        static void F12()
        {
            Console.WriteLine("Add meg az élek hosszát:");

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;

            Console.WriteLine("A téglatest felszíne: ", felszin);
            Console.WriteLine("A téglatest térfogata: ", terfogat);
        }
        static void F13() 
        {
            Console.WriteLine("Add meg a kör átmérőjét:");

            Console.Write("Átmérő = ");
            double atmero = double.Parse(Console.ReadLine());

            double sugar = atmero / 2.0;
            double kerulet = Math.PI * atmero;
            double terulet = Math.PI * sugar * sugar;

            Console.WriteLine("A kör kerülete: ", kerulet);
            Console.WriteLine("A kör területe: ", terulet);
        }
        static void F14()
        {
            Console.WriteLine("Add meg a körív sugarát:");
            Console.Write("Sugár = ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a középponti szöget fokban:");
            Console.Write("Szög = ");
            int szog = int.Parse(Console.ReadLine());

            double ivHossz = 2 * Math.PI * r * (szog / 360.0);
            double szektorTerulet = Math.PI * r * r * (szog / 360.0);

            Console.WriteLine("A határoló ív hossza: ", ivHossz);
            Console.WriteLine("A körívhez tartozó szektor területe: ", szektorTerulet);
        }
        //Ciklusok********************************
        static void F15()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void F16()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void F17()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Az osztók:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void F18()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int n = int.Parse(Console.ReadLine());

            int osszeg = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    osszeg += i;
                }
            }

            Console.WriteLine("Az osztók összege:", osszeg);
        }
        static void F19() 
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            int n = int.Parse(Console.ReadLine());

            int osztokOsszege = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    osztokOsszege += i;
                }
            }

            if (osztokOsszege == 2 * n)
            {
                Console.WriteLine(" tökéletes szám.", n);
            }
            else
            {
                Console.WriteLine(" nem tökéletes szám.", n);
            }
        }
        static void F20() 
        {
            Console.WriteLine("Add meg a hatvány alapját:");
            double alap = double.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a kitevőt:");
            double kitevo = double.Parse(Console.ReadLine());

            double eredmeny = Math.Pow(alap, kitevo);

            Console.WriteLine("A hatvány értéke:", eredmeny);
        }
        static void F21()
        {
            
        }
        static void F22()
        {
            int osszeg = 0;
            int szam;

            Console.WriteLine("Addig adj meg számokat, amíg azok kisebbek, mint tíz!");

            do
            {
                Console.Write("Szám: ");
                szam = int.Parse(Console.ReadLine());
                if (szam < 10)
                {
                    osszeg += szam;
                }
            } while (szam < 10);

            Console.WriteLine("A beolvasott, tíznél kisebb számok összege: ", osszeg);
        }
        static void F23()
        {
            
        }
        static void F24()
        {
            string input;
            do
            {
                Console.WriteLine("Írd be: alma");
                input = Console.ReadLine();
            } while (input != "alma");

            Console.WriteLine("Az alma gyümölcs!");
        }
        static void F25()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int n = int.Parse(Console.ReadLine());

            int eredeti = n;

            while (n >= 3)
            {
                n -= 3;
            }

            Console.WriteLine("A szám hárommal való osztásának maradéka: ", eredeti, n);
        }
        static void F26() 
        {

            Console.WriteLine("Adj meg egy egész számot:");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("{0} nem prímszám.", n);
                return;
            }

            bool prim = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prim = false;
                    break;
                }
            }

            if (prim)
            {
                Console.WriteLine(" prímszám.", n);
            }
            else
            {
                Console.WriteLine(" nem prímszám.", n);
            }
        }
        static void F27() 
        {
            
        }
        static void F28()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("A(z) prímosztói:", n);
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && PrimE(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static bool PrimE(int i)
        {
            throw new NotImplementedException();
        }

        static void F29()
        {

        }
        static void F30()
        {
            Console.WriteLine("Adj meg két egész számot!");

            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine());

            int lnko = LegnagyobbKozosOszto(a, b);

            Console.WriteLine("A két szám legnagyobb közös osztója:", lnko);
        }

        static int LegnagyobbKozosOszto(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return Math.Abs(x);
        }
        static void F31()
        {
            Console.WriteLine("Adj meg két egész számot!");

            Console.Write("Első szám: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Második szám: ");
            int b = int.Parse(Console.ReadLine());

            int lnko = LegnagyobbKozosOszt(a, b);
            int lkkt = Math.Abs(a * b) / lnko;

            Console.WriteLine("A két szám legkisebb közös többszöröse: ", lkkt);
        }

        private static int LegnagyobbKozosOszt(int a, int b)
        {
            throw new NotImplementedException();
        }
        static void F32()
        {
            Console.WriteLine("Adj meg egy számot:");
            int alap = int.Parse(Console.ReadLine());

            Console.WriteLine(" szorzótábla:", alap);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", alap, i, alap * i);
            }
        }
        static void F33()
        {
            Console.WriteLine("Adj meg egy számot az összegtáblához:");
            int alap = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} alapú összegtábla:", alap);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} + {1} = {2}", alap, i, alap + i);
            }
        }
        static void F34()
        {

        }

            static void F35() {   
            int oszlopok = 3; 
            int sorok = 10;   
            int kezd = (int)'a';
            int veg = (int)'z';
            int db = veg - kezd + 1;
            int maxSor = Math.Min(sorok, (int)Math.Ceiling(db / (double)oszlopok));

            Console.WriteLine("Kisbetűk és ASCII kódjaik több oszlopban:");
            for (int sor = 0; sor < maxSor; sor++)
            {
                for (int oszlop = 0; oszlop < oszlopok; oszlop++)
                {
                    int idx = sor + oszlop * maxSor;
                    if (idx < db)
                    {
                        char ch = (char)(kezd + idx);
                        int kod = kezd + idx;
                        Console.Write("{0} ({1})\t", ch, kod);
                    }
                }
                Console.WriteLine();
            }
        }
        static void F36()
        {
            int sorok = 6;
            int oszlopok = 6;

            for (int sor = 0; sor < sorok; sor++)
            {
                for (int oszlop = 0; oszlop < oszlopok; oszlop++)
                {
                    if ((sor + oszlop) % 2 == 0)
                        Console.Write("X");
                    else
                        Console.Write("O");
                }
                Console.WriteLine();
            }
        }
        static void F37()
        {
            Console.WriteLine("Adj meg egy természetes számot (a):");
            int a = int.Parse(Console.ReadLine());

            for (int sor = 1; sor <= a; sor++)
            {
                int csillagok = 2 * sor - 1;
                for (int i = 0; i < csillagok; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void F38()
        {
            Console.WriteLine("Adj meg egy természetes számot (a):");
            int a = int.Parse(Console.ReadLine());

            for (int sor = 1; sor <= a; sor++)
            {
                int csillagok = 2 * sor - 1;
                int szokozok = a - sor;
                for (int i = 0; i < szokozok; i++)
                    Console.Write(" ");
                for (int i = 0; i < csillagok; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void F39()
        {
            Console.WriteLine("Add meg a téglalap sorainak számát (M):");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a téglalap oszlopainak számát (N):");
            int N = int.Parse(Console.ReadLine());

            for (int sor = 1; sor <= M; sor++)
            {
                for (int oszlop = 1; oszlop <= N; oszlop++)
                {
                    if (sor == 1 || sor == M || oszlop == 1 || oszlop == N)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void F40()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("A tökéletes számok 1 és {0} között:", n);
            for (int szam = 2; szam <= n; szam++)
            {
                int osztokOsszege = 0;
                for (int i = 1; i <= szam; i++)
                {
                    if (szam % i == 0)
                        osztokOsszege += i;
                }
                if (osztokOsszege == 2 * szam)
                    Console.Write(szam + " ");
            }
            Console.WriteLine();
        }
        static void F41()
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int hossz = abc.Length;

            for (int sor = 0; sor < hossz; sor++)
            {
                for (int i = 0; i < hossz; i++)
                {
                    Console.Write(abc[(i + sor) % hossz]);
                }
                Console.WriteLine();
            }
        }
        static void F42()
        {
            Console.WriteLine("Add meg, hány számot szeretnél beolvasni:");
            int db = int.Parse(Console.ReadLine());
            int paratlanDb = 0;
            for (int i = 0; i < db; i++)
            {
                Console.Write("Szám {0}: ", i + 1);
                int szam = int.Parse(Console.ReadLine());
                if (szam % 2 != 0)
                    paratlanDb++;
            }
            Console.WriteLine("A páratlan számok darabszáma: {0}", paratlanDb);
        }

        static void F43()
        {
            Console.WriteLine("Add meg, hány számot szeretnél beolvasni:");
            int db = int.Parse(Console.ReadLine());
            int parosOsszeg = 0;
            for (int i = 0; i < db; i++)
            {
                Console.Write("Szám {0}: ", i + 1);
                int szam = int.Parse(Console.ReadLine());
                if (szam % 2 == 0)
                    parosOsszeg += szam;
            }
            Console.WriteLine("A páros számok összege: {0}", parosOsszeg);
        }

        static void F44()
        {
            Console.WriteLine("Add meg, hány számot szeretnél beolvasni:");
            int db = int.Parse(Console.ReadLine());
            for (int i = 0; i < db; i++)
            {
                Console.Write("Szám {0}: ", i + 1);
                int szam = int.Parse(Console.ReadLine());
                if (szam % 2 == 0)
                    Console.WriteLine("{0}. páros szám: {1}", i + 1, szam);
            }
        }

        static void F45()
        {
            Console.WriteLine("Add meg, hány számot szeretnél beolvasni:");
            int db = int.Parse(Console.ReadLine());
            int[] tomb = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write("Szám {0}: ", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Add meg a keresett számot: ");
            int keresett = int.Parse(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < db; i++)
            {
                if (tomb[i] == keresett)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
                Console.WriteLine("A keresett szám első előfordulásának indexe: {0}", index);
            else
                Console.WriteLine("A beolvasott szám nincs a tömbben.");
        }

        static void F46()
        {
            Console.WriteLine("Add meg, hány számot szeretnél beolvasni:");
            int db = int.Parse(Console.ReadLine());
            int[] tomb = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write("Szám {0}: ", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Add meg a keresett számot: ");
            int keresett = int.Parse(Console.ReadLine());
            int darab = 0;
            for (int i = 0; i < db; i++)
            {
                if (tomb[i] == keresett)
                    darab++;
            }
            Console.WriteLine("A keresett szám {0}-szor szerepel a tömbben.", darab);
        }

        static void F47()
        {
            Console.WriteLine("Add meg, hány tanuló nevét szeretnéd beolvasni:");
            int db = int.Parse(Console.ReadLine());
            string[] nevek = new string[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write("Tanuló {0} keresztneve: ", i + 1);
                nevek[i] = Console.ReadLine();
            }
            Console.Write("Add meg a keresett keresztnevet: ");
            string keresett = Console.ReadLine();
            int darab = 0;
            for (int i = 0; i < db; i++)
            {
                if (nevek[i] == keresett)
                    darab++;
            }
            Console.WriteLine("A(z) {0} nevű tanulóból {1} jár az osztályba.", keresett, darab);
        }

        static void F48()
        {
            Console.WriteLine("Add meg, hány számot szeretnél beolvasni:");
            int db = int.Parse(Console.ReadLine());
            int[] tomb = new int[db];
            for (int i = 0; i < db; i++)
            {
                Console.Write("Szám {0}: ", i + 1);
                tomb[i] = int.Parse(Console.ReadLine());
            }
            int min = tomb[0];
            int max = tomb[0];
            for (int i = 1; i < db; i++)
            {
                if (tomb[i] < min) min = tomb[i];
                if (tomb[i] > max) max = tomb[i];
            }
            Console.WriteLine("A legkisebb és legnagyobb szám különbsége: {0}", max - min);
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
            F11();
            F12();
            F13();
            F14();
            F15();
            F16();
            F17();
            F18();
            F19();
            F20();
            F21();
            F22();
            F23();
            F24();
            F25();
            F26();
            F27();
            F28();
            F29();
            F30();
            F31();
            F32();
            F33();
            F34();
            F35();
            F36();
            F37();
            F38();
            F39();
            F40();
            F41();
            F42();
            F43();
            F44();
            F45();
            F46();
            F47();
            F48();

        }
    }
}
