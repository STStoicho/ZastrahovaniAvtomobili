using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ZastrahovaniAvtomobili
{
    public class Avtomobil : ZastrahovaniAvtomobili
    {
        private string cvqtNaAvtomobil;
        private double cenaNaAvtomobil;
        private int godinaNaProizvodstvo;

        public string CvqtNaAvtomobil
        {
            get { return this.cvqtNaAvtomobil; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Greshka!");
                }
                this.cvqtNaAvtomobil = value;
            }
        }

        public double CenaNaAvtomobil
        {
            get { return this.cenaNaAvtomobil; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka!");
                }
                this.cenaNaAvtomobil = value;
            }
        }

        public int GodinaNaProizvodstvo
        {
            get { return this.godinaNaProizvodstvo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka!");
                }
                this.godinaNaProizvodstvo = value;
            }
        }

        public Avtomobil(string imeNaSobstvenik, int nomerNaAvtomobil, int nomerNaDvigatel, int nomerNaKupe, string markaNaAvtomobil, string cvqtNaAvtomobil, double cenaNaAvtomobil, int godinaNaProizvodstvo, double dataKraiNaZastrahovka, string vidNaZastrahovka) : base(imeNaSobstvenik, nomerNaAvtomobil, nomerNaDvigatel, nomerNaKupe, markaNaAvtomobil, dataKraiNaZastrahovka, vidNaZastrahovka)
        {
            this.cvqtNaAvtomobil = cvqtNaAvtomobil;
            this.cenaNaAvtomobil = cenaNaAvtomobil;
            this.godinaNaProizvodstvo = godinaNaProizvodstvo;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Ime na sobstenik: {this.ImeNaSobstvenik}, nomer na avtomobil: {this.NomerNaAvtomobil}, nomer na dvigatel: {this.NomerNaDvigatel}, nomer na kupe: {this.NomerNaKupe}, marka na avtomobil: {this.MarkaNaAvtomobil}, cvqt na avtomobil: {this.cvqtNaAvtomobil}, cena na avtomobil: {this.cenaNaAvtomobil}, godina na proizvodstvo: {this.godinaNaProizvodstvo}, krai na zastrahovka: {this.DataKraiNaZastrahovka}, vid na zastrahovka: {this.VidNaZastrahovka}.");
        }

        public override void SrednataDataZaKraiNaZastrahovka()
        {

        }
    }
}
