using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdSoyadRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ad ad = new Ad();
            string a;
            ad.Sahis(out a);
            Console.WriteLine("İsim: {0}",a);

            string b;
            ad.Sahiss(out b);
            Console.WriteLine("Soyisim: {0}", b);

            int c;
            ad.Sahisy(out  c);
            Console.WriteLine("Yaş: {0}", c);
        }
    }
    class Ad
    {
        public void Sahis(out string x) 
        {

            x = "Abdulmuttalip";
        }
        public void Sahiss(out string y)
        {
            y = "Karaokur";
        }
        public void Sahisy(out int z)
        {
            z = 16;
        }
    }
}
