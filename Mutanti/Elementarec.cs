using System;
using System.Runtime.Remoting.Messaging;

namespace Mutanti
{
    internal class Elementarec : Mutant
    {
       private  int področje;
        public int Področje { get => področje; set => področje = value; }

        public override int KvocientNevarnosti()
        {
            return področje * stopnja;
        }
    }
}

