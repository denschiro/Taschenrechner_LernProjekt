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
            ////Abfrage des ersten Wert
            //Console.WriteLine("Bitte ersten Summanden eingeben: ");
            //string ersterSummand = Console.ReadLine();


            ////Abfrage des zweiten Wert
            //Console.WriteLine("Bitte zweiten Summanden eingeben: ");
            //string zweiterSummand = Console.ReadLine();


            //Verwendung der Methode HoleSummanden mit Text und Rückgabe
            string ersterSummand = HoleSummanden("Bitte ersten Summanden eingeben: ");

            //Verwendung der Methode HoleSummanden mit Text und Rückgabe
            string zweiterSummand = HoleSummanden("Bitte zweiten Summanden eingeben: ");

            //Werte von String zu Double konvertierten
            double ersterSummandalsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            //addieren beiden Werte mit der Methode Addieren
            double summe = Addiere(ersterSummandalsZahl, zweiterSummandalsZahl);

            //Ausgabe des Ergebnis
            Console.WriteLine("Ergebnis: {0} ", summe);

            //Aufrufen der Methode WarteAufBenutzereingabe
            WarteAufBenutzereingabe();


        }

        //Methode HoleSummanden

            static string HoleSummanden(string auforderungSummanden)
        {
            Console.WriteLine(auforderungSummanden);
            string summand = Console.ReadLine();

            return summand;

        }

        //Methode WarteAufBenutzereingabe
        static void  WarteAufBenutzereingabe()
        {
            Console.WriteLine("Bitte zum beenden Return drücken");
            Console.Read();
        }

        //Methode Addiere mit Rückgabewert
        static double Addiere (double ersterSummandalsZahl, double zweiterSummandalsZahl)
        {
            double summe = ersterSummandalsZahl + zweiterSummandalsZahl;
            return summe;
        }
        
    }
}
