using System;
using System.Collections.Generic;
using System.IO;
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

            try
            {
                List<Avtomobil> zastrahovaniAvtomobili = new List<Avtomobil>();
                StreamWriter avtomobiliInfo = new StreamWriter("avtomobiliInfo.txt");
                Console.WriteLine("Vavedete kolko zastrahovani avtomobila iskate da ima?");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Vavedete informaciq za zastrahovaniq avtomobil");
                    Console.WriteLine("(Ime na sobstvenik, nomer na avtomobil, nomer na dvigatel, nomer na kupe, marka na avtomobil,");
                    Console.WriteLine("cvqt na avtomobil, cena na avtomobil, godina na proizvodstvo, krai na zastrahovka, vid na zastrahovka)");
                    Console.WriteLine("");
                    var danni = Console.ReadLine().Split();
                    Avtomobil avtomobil = new Avtomobil(danni[0], int.Parse(danni[1]), int.Parse(danni[2]), int.Parse(danni[3]), danni[4], danni[5], double.Parse(danni[6]), int.Parse(danni[7]), double.Parse(danni[8]), danni[9]);
                    zastrahovaniAvtomobili.Add(avtomobil);
                }

                Comparable comparable = new Comparable();
                zastrahovaniAvtomobili.Sort(comparable);
                zastrahovaniAvtomobili.ForEach(x => x.Print());


                Console.WriteLine("");
                Console.WriteLine("Kola chiqto zastrahovka izticha nai-skoro:");
                double min = zastrahovaniAvtomobili.Select(x => x.DataKraiNaZastrahovka).Min();
                Console.WriteLine(min);

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("");
            }
        }
    }
}
