using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseMetodeKonstruktori
{
    

    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Upišite postotak za proc:");
            string s = Console.ReadLine();
            Proceduralni x = new Proceduralni();
            x.Postotak = Convert.ToDouble(s);
            sum += x.Postotak;
            Console.WriteLine("Upišite postotak za obj:");
            s = Console.ReadLine();
            Objektni y = new Objektni();
            y.Postotak = Convert.ToDouble(s);
            sum += y.Postotak;
            Console.WriteLine("Upišite postotak za funkc:");
            s = Console.ReadLine();
            Funkcionalni z = new Funkcionalni();
            z.Postotak = Convert.ToDouble(s);
            sum += z.Postotak;
            if (sum != 100)
                Console.WriteLine("Podaci nisu dobro unešeni");
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                    Console.WriteLine("Najzastupljeni su proceduralni programski jezici");
                else if (y.Postotak > z.Postotak)
                    Console.WriteLine("Najzastupljeni su objektni programski jezici");
                else
                    Console.WriteLine("Najzastupljeni su funkcionalni programski jezici");
            }
            Console.ReadKey();
        }
    }
}

