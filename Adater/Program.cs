using System;


namespace Adater
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter a = new Adapter("Nagyon", "Ügyes");
            
            Ügyfél ü = new Ügyfél(a);
            ü.Kiir();
            Console.ReadLine();
        }
    }

    public class Szemely
    {
        public string Vezetéknév { get; set; }
        public string Utónév { get; set; }

       
        public Szemely(string V, string U)
        {
            Vezetéknév = V;
            Utónév = U;
            
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

    class Adapter : Szemely, INév
    {
        public Adapter(string V, string U) : base(V, U) { }

        public string Teljesnév
        {
            get
            {
                return Vezetéknév + " " + Utónév;
            }
        }
    }
}
