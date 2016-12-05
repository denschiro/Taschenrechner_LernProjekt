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
            //Abfrage des ersten Wert

            Console.WriteLine("Bitte ersten Summanden eingeben: ");
            string ersterSummand = Console.ReadLine();


            //Abfrage des zweiten Wert
            Console.WriteLine("Bitte zweiten Summanden eingeben: ");
            string zweiterSummand = Console.ReadLine();
            
                
            //Convertierung und addieren beiden Werte
            double ergebnis = Convert.ToDouble(ersterSummand) + Convert.ToDouble(zweiterSummand);

            //Ausgabe des Ergebnis
            Console.WriteLine("Ergebnis: {0} ", ergebnis);
            
            //Aufrufen der Methode Ausgabe
            Ausgabe();


        }

        //Methode Ausgabe
        static void Ausgabe()
        {
            Console.WriteLine("Bitte zum beenden Return drücken");
            Console.Read();
        }

        
    }
}
