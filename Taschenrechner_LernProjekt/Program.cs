using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_LernProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte ersten Summanden eingeben: ");
            string ersterSummand = Console.ReadLine();

            Console.WriteLine("Bitte zweiten Summanden eingeben: ");
            string zweiterSummand = Console.ReadLine();
            
                

            double ergebnis = Convert.ToDouble(ersterSummand) + Convert.ToDouble(zweiterSummand);

            Console.WriteLine("Ergebnis: {0} " ,ergebnis);

            Console.Read();


        }
    }
}
