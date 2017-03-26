using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter2
{
    public class Converter
    {
        double usd_uah;//= 24.98
        double eur_uah;//= 27.85
        double plz_uah;//= 5.65
        double uah_uah;

        public double USD
        {
            set { usd_uah = value; }
            get { return usd_uah; }
        }

        public double EUR
        {
            set { eur_uah = value; }
            get { return eur_uah; }
        }

        public double PLZ
        {
            set { plz_uah = value; }
            get { return plz_uah; }
        }

        public double UAH
        {
            set { uah_uah = value; }
            get { return uah_uah; }
        }
        public void ConvertToUAH()
        {
            if (USD != 0)
            {
                uah_uah = usd_uah * 24.98;
                Console.WriteLine("{0} USD = {1} UAH", usd_uah, uah_uah);
            }
            else
                Console.WriteLine("err");

            if (EUR != 0)
            {
                double uah_uah = eur_uah * 27.95;
                Console.WriteLine("{0} EUR = {1} UAH", eur_uah, uah_uah);
            }
            else
                Console.WriteLine("err");

            if (PLZ != 0)
            {
                uah_uah = plz_uah * 5.65;
                Console.WriteLine("{0} PLZ = {1} UAH", plz_uah, uah_uah);
            }
            else
                Console.WriteLine("err");

            Console.WriteLine(new string('*', 40));
        }

        public void ConvertToUSD(double uah_uah)
        {
            if (UAH != 0)
            {
                usd_uah = uah_uah / 24.98;
                Console.WriteLine("{0} UAH = {1} USD", uah_uah, usd_uah);
            }
            else
                Console.WriteLine("uah must be > 0");
        }

        public void ConvertToEUR()
        {
            if (UAH != 0)
            {
                eur_uah = uah_uah / 27.85;
                Console.WriteLine("{0} UAH = {1} EUR", uah_uah, eur_uah);
            }
            else
                Console.WriteLine("uah must be > 0");
        }

        public void ConvertToPLZ()
        {
            if (UAH != 0)
            {
                plz_uah = uah_uah / 5.65;
                Console.WriteLine("{0} UAH = {1} PLZ", uah_uah, plz_uah);
                Console.WriteLine(new string('*', 40));
            }
            else
                Console.WriteLine("uah must be > 0");
        }

        public Converter()
        {

        }

        public Converter(double usd, double eur, double plz)
        {
            this.usd_uah = usd;
            this.eur_uah = eur;
            this.plz_uah = plz;
        }
    }
}
