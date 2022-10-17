using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Kupec60:Kupec
    {
        private int visjaTarifaPorabljeno;
        public new void BeležiKlic(int min, tipklica tip)
        {

            switch (tip)
            {
                // stacionarno
                case tipklica.Stacionarno:
                    stanje += min * 0.2m;
                    break;

                //mobilno
                case tipklica.Mobilno:
                    int vMinute, nMinute;
                    int šeVMinute = (visjaTarifaPorabljeno < 60) ?
                        60 - visjaTarifaPorabljeno : 0;
                    if(min>šeVMinute) //en klic 2 tarifi
                    {
                        vMinute = šeVMinute;
                        nMinute = min -vMinute;

                    }
                    else
                    {
                        vMinute = min;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.035m + nMinute * 0.01m;
                    visjaTarifaPorabljeno += vMinute;
                    break;

                default:
                    break;

            }
        }
    }
}
