using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{

    internal class Kupec
    {
        protected string ime;
        protected decimal stanje;
        public string Ime { get => ime; set => ime = value; }

        public decimal Stanje { get => stanje; }
        //ne mores spreminjati izven kupec
        public void BeleziPlačilo(decimal plačilo)
        {
            stanje -= plačilo;
        }

        public void BeleziKlic(int min, tipklica tip)
        {
            switch (tip)
            {
                // stacionarno
                case tipklica.Stacionarno:
                    stanje += min * 0.2m;
                    break;

                //mobilno
                case tipklica.Mobilno:
                    stanje += min * 0.03m;
                    break;

                default:
                    break;

            }

        }
        public override string ToString()
        {
            return ime + " dolguje " + stanje + " evrov ";
        }
    }
}