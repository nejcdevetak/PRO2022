using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal abstract class Mutant : IPrikazovalnik
    {

        protected string ime;
        protected int stopnja;

        public string Ime { get => ime; set => ime = value; }
        public int Stopnja { get => stopnja; set => stopnja = value; }

        public void PrikažiInformacije()
        {
            Console.WriteLine("Mutant"+Ime+"ima kvocient nevarnosti");

        }
        public abstract int KvocientNevarnosti();




    }
}
