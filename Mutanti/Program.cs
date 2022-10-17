using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Program
    {

        protected string Mutant;

        static void Main(string[] args)
        {
            Mutant[] m = new Mutant[6];
            Psiho ps1 = new Psiho();
            ps1.Ime = "Višji um";
            ps1.IQ = 150;
            ps1.Stopnja = 3;
            ps1.ŠteviloUporabeMoči = 2;
            m[0] = ps1;
            Psiho ps2 = new Psiho();
            ps2.Ime = "Povprečnež";
            ps2.IQ = 100;
            ps2.Stopnja = 3;
            ps2.ŠteviloUporabeMoči = 2;
            m[1] = ps2;
            Fizikalec ps3 = new Fizikalec();
            ps3.Ime = "Močen mož";
            ps3.IQ = 80;
            ps3.Stopnja = 3;
            ps3.Moč = 30;
            m[2] = ps3;
            Fizikalec ps4 = new Fizikalec();
            ps4.Ime = "Veliki";
            ps4.IQ = 100;
            ps4.Stopnja = 3;
            ps4.Moč = 20;
            m[3] = ps4;
            Elementarec ps5 = new Elementarec();
            ps5.Ime = "Metalec ognja";
            ps5.Stopnja = 4;
            ps5.Področje = 7;
            m[4] = ps5;
            Elementarec ps6 = new Elementarec();
            ps6.Ime = "Deževno dekle";
            ps6.Stopnja = 5;
            ps6.Področje = 6;
            m[5] = ps6;
            foreach (Mutant m1 in m)
            m1.PrikažiInformacije();
            Console.ReadLine();
        }
    }
}
