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


            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string ersteZahlAlsString = HoleBenutzerEingabe("Bitte ersten Wert eingeben: ");

            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string zweiteZahlAslsString = HoleBenutzerEingabe("Bitte zweiten Wert eingeben: ");

            //Werte von String zu Double konvertierten
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAslsString);

            //addieren beiden Werte mit der Methode Addieren
            double summe = Addiere(ersteZahl, zweiteZahl);

            //Ausgabe des Ergebnis
            Console.WriteLine("Ergebnis: {0} ", summe);

            //Aufrufen der Methode WarteAufBenutzereingabe
            //  Abglöst durch Methode HoleBenutzerEingabe ohne Rückgabewert vorher //WarteAufBenutzereingabe();
            HoleBenutzerEingabe("Bitte zum beenden Return drücken");

        }

        //Methode HoleBenutzerEingabe

        static string HoleBenutzerEingabe(string auforderungSummanden)
        {
            Console.WriteLine(auforderungSummanden);
            string summand = Console.ReadLine();

            return summand;

        }

        //////Methode WarteAufBenutzereingabe
        ////static void  WarteAufBenutzereingabe()
        ////{
        ////    Console.WriteLine("Bitte zum beenden Return drücken");
        ////    Console.Read();
        ////}

        //Methode Addiere mit Rückgabewert
        static double Addiere (double ersterSummandalsZahl, double zweiterSummandalsZahl)
        {
            double summe = ersterSummandalsZahl + zweiterSummandalsZahl;
            return summe;
        }

        //Methode Subtrahiere mit Rückgabewert
        static double Subtrahiere (double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;
            return differenz;
        }
    }
}
