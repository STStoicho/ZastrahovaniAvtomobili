using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZastrahovaniAvtomobili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Avtomobil> zastrahovaniAvtomobili = new List<Avtomobil>();
            Console.WriteLine("Vavedete kolko zastrahovani avtomobila iskate da ima?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] danni = Console.ReadLine().Split();
                Avtomobil avtomobil = new Avtomobil(danni[0], int.Parse(danni[1]), int.Parse(danni[2]), int.Parse(danni[3]), danni[4], danni[5], double.Parse(danni[6]), int.Parse(danni[7]), double.Parse(danni[8]), danni[9]);
                zastrahovaniAvtomobili.Add(avtomobil);
            }

            Comparable comparable = new Comparable();
            zastrahovaniAvtomobili.Sort(comparable);
            zastrahovaniAvtomobili.ForEach(x => x.Print());


            Console.WriteLine("");
            Console.WriteLine("Kola chiqto zastrahovka izticha nai-skoro:");
            zastrahovaniAvtomobili.Min(x => x.DataKraiNaZastrahovka);
        }
    }
}
