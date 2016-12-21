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


            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string ersteZahlAlsString = HoleBenutzerEingabe("Bitte ersten Wert eingeben: ");

            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string zweiteZahlAslsString = HoleBenutzerEingabe("Bitte zweiten Wert eingeben: ");

            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string operatoren = HoleBenutzerEingabe("Bitte Operation auswählen angeben ( + - / *): ");


            //Werte von String zu Double konvertierten
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAslsString);


            switch (operatoren)
            {
                case "+" : //addieren beiden Werte mit der Methode Addieren
                    double resultat = Addiere(ersteZahl, zweiteZahl);

                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", resultat);
                    break;

                case "-":
                    double differenz = Subtrahiere(ersteZahl, zweiteZahl);
                        //Ausgabe des Ergebnis
                     Console.WriteLine("Ergebnis: {0} ", differenz);
                    break;

                case "*":
                    double multiplikat = Multipliziere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", multiplikat);
                    break;

                case "/":
                    double divident = Dividiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", divident);

                    break;


                default:
                    Console.WriteLine("Ungültige Operation, Abbruch");

                    break;
            }

            ////if (operatoren == "+")
            ////{
            ////    //addieren beiden Werte mit der Methode Addieren
            ////    double summe = Addiere(ersteZahl, zweiteZahl);

            ////    //Ausgabe des Ergebnis
            ////    Console.WriteLine("Ergebnis: {0} ", summe);
            ////}

            ////else if (operatoren == "-")
            ////{
            ////    double summe = Subtrahiere(ersteZahl, zweiteZahl);
            ////    //Ausgabe des Ergebnis
            ////    Console.WriteLine("Ergebnis: {0} ", summe);
            ////}

            ////else
            ////{
            ////    Console.WriteLine("Falsche Eingabe");
            ////}

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

        static double Dividiere (double basis, double divident)
        {
            double resultat =  basis / divident;
            return resultat;
        }

        static double Multipliziere(double multiplient, double basis)
        {
            double multiplikat = multiplient * basis;
            return multiplikat;

        }
        
        
        ////Methode WarteAufBenutzereingabe
        //static void  WarteAufBenutzereingabe()
        //{
        //    Console.WriteLine("Bitte zum beenden Return drücken");
        //    Console.Read();
        //}

    }
}
