using System;

namespace Kiegészítés
{
    class Program
    {
        static void Main(string[] args)
        {
            Szemely szemely = new Szemely("Nagyon", "Ügyes");
            Ügyfél Ü = new Ügyfél(szemely);
            Ü.Kiir();
            Console.ReadLine();


        }

        public partial class Szemely
        {
            public string Vezetéknév { get; set; }
            public string Utónév { get; set; }

            public Szemely(string V, string U)
            {
                Vezetéknév = V;
                Utónév = U;
            }
        }

        public partial class Szemely : INév
        {
            public string Teljesnév
            {
                get { return Vezetéknév + " " + Utónév; }
            }
        }

        interface INév
        {
            string Vezetéknév { get; set; }
            string Utónév { get; set; }
            string Teljesnév { get; }
        }

        class Ügyfél
        {
            private INév n;

            public Ügyfél(INév újNév)
            {
                n = újNév;
            }

            public void Kiir()
            {
                Console.WriteLine(n.Vezetéknév + "\t" + n.Utónév + "\t" + n.Teljesnév);
            }
        }

    }
}
