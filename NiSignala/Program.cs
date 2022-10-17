using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Program
    {


        static void Main(String[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeleziKlic(10, tipklica.Stacionarno);
            Console.WriteLine(janez.Ime + "dolguje" + janez.Stanje);
            Console.WriteLine("get type"+janez.GetType());
            Console.WriteLine("to string" + janez.ToString());

            Kupec60 alenka = new Kupec60();
            alenka.Ime = "Janez Novak";
            alenka.BeleziKlic(10, tipklica.Mobilno);
            Console.WriteLine(alenka.Ime + "dolguje" + alenka.Stanje);
            Console.WriteLine("get type" + alenka.GetType());
            Console.WriteLine(" to string" + alenka.ToString());
            Console.ReadLine();
        }

    }
}
        
    

