using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastrahovaniAvtomobili
{
    public abstract class ZastrahovaniAvtomobili : IPrint
    {
        private string imeNaSobstvenik;
        private int nomerNaAvtomobil;
        private int nomerNaDvigatel;
        private int nomerNaKupe;
        private string markaNaAvtomobil;
        private double dataKraiNaZastrahovka;
        private string vidNaZastrahovka;

        public string ImeNaSobstvenik
        {
            get { return this.imeNaSobstvenik;  }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Greshka!");
                }
                this.imeNaSobstvenik = value;
            }
        }

        public int NomerNaAvtomobil
        {
            get { return this.nomerNaAvtomobil; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka!");
                }
                this.nomerNaAvtomobil = value;
            }
        }

        public int NomerNaDvigatel
        {
            get { return this.nomerNaDvigatel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka!");
                }
                this.nomerNaDvigatel = value;
            }
        }

        public int NomerNaKupe
        {
            get { return this.nomerNaKupe; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka!");
                }
                this.nomerNaKupe = value;
            }
        }

        public string MarkaNaAvtomobil
        {
            get { return this.markaNaAvtomobil; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Greshka!");
                }
                this.markaNaAvtomobil = value;
            }
        }

        public double DataKraiNaZastrahovka
        {
            get { return this.dataKraiNaZastrahovka; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greshka!");
                }
                this.dataKraiNaZastrahovka = value;
            }
        }

        public string VidNaZastrahovka
        {
            get { return this.vidNaZastrahovka; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Greshka!");
                }
                this.vidNaZastrahovka = value;
            }
        }

        public ZastrahovaniAvtomobili(string imeNaSobstvenik, int nomerNaAvtomobil, int nomerNaDvigatel, int nomerNaKupe, string markaNaAvtomobil,double dataKraiNaZastrahovka, string vidNaZastrahovka)
        {
            this.imeNaSobstvenik = imeNaSobstvenik;
            this.nomerNaAvtomobil = nomerNaAvtomobil;
            this.nomerNaDvigatel = nomerNaDvigatel;
            this.nomerNaKupe = nomerNaKupe;
            this.markaNaAvtomobil = markaNaAvtomobil;
            this.dataKraiNaZastrahovka = dataKraiNaZastrahovka;
            this.vidNaZastrahovka = vidNaZastrahovka;
        }

        public virtual void Print()
        {
            Console.WriteLine();
        }

        public abstract void SrednataDataZaKraiNaZastrahovka();
    }
}
