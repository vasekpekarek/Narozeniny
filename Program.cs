using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumNarozeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Narozeniny(new DateTime(1984, 02, 09));
            Console.ReadKey();
        }
        static void Narozeniny(DateTime datumNarozeni)
        {
            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - datumNarozeni.Year;
            if (dnes < datumNarozeni.AddYears(vek))
            {
                vek--;
                Console.WriteLine(vek);
            }
            else
            {
                Console.WriteLine(vek);
            }
            DateTime dalsiNarozeniny = datumNarozeni.AddYears(vek + 1);
            TimeSpan rozdil = dalsiNarozeniny - dnes;
            
            Console.WriteLine(Convert.ToInt32(rozdil.TotalDays));
        }
    }
}
