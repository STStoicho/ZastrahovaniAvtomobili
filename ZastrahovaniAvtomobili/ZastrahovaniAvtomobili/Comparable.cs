using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastrahovaniAvtomobili
{
    internal class Comparable : IComparer<Avtomobil>
    {
        public int Compare(Avtomobil x, Avtomobil y)
        {
            int result = x.DataKraiNaZastrahovka.CompareTo(y.DataKraiNaZastrahovka);
            if (result == 0)
            {
                result = y.DataKraiNaZastrahovka.CompareTo(x.DataKraiNaZastrahovka);
            }

            return result;
        }
    }
}
