using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal  class Psiho : Mutant
    {
        int iq;
        int številouporabemoči;

        public int IQ { get =>iq; set => iq = value; }
        public int ŠteviloUporabeMoči { get => številouporabemoči; set => številouporabemoči = value; }

       
        public override int KvocientNevarnosti()
         {
        return Stopnja*IQ*ŠteviloUporabeMoči;
    }
}
}
