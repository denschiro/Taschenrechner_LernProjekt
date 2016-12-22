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
            string operatoren = HoleBenutzerEingabe("Bitte Operation auswählen angeben ( + , - , / , *): ");


            //Werte von String zu Double konvertierten
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAslsString);

            double ergebnis = Berechnung(ersteZahl, zweiteZahl, operatoren);

            //double ergebnis = 0;

            //switch (operatoren)
            //{
                            
            //    case "+" : //addieren beiden Werte mit der Methode Addieren
            //        ergebnis = Addiere(ersteZahl, zweiteZahl);
                   
            //        //Ausgabe des Ergebnis
            //        Console.WriteLine("Ergebnis: {0} ", ergebnis);
            //        break;

            //    case "-":
            //        ergebnis = Subtrahiere(ersteZahl, zweiteZahl);
            //            //Ausgabe des Ergebnis
            //         Console.WriteLine("Ergebnis: {0} ", ergebnis);
            //        break;

            //    case "*":
            //        ergebnis = Multipliziere(ersteZahl, zweiteZahl);
            //        //Ausgabe des Ergebnis
            //        Console.WriteLine("Ergebnis: {0} ", ergebnis);
            //        break;

            //    case "/":
            //        ergebnis = Dividiere(ersteZahl, zweiteZahl);
            //        //Ausgabe des Ergebnis
            //        Console.WriteLine("Ergebnis: {0} ", ergebnis);

            //        break;


            //    default:
            //        Console.WriteLine("Ungültige Operation, Abbruch");

            //        break;
            //}

         HoleBenutzerEingabe("Bitte zum beenden Return drücken");

        }

        //Methode HoleBenutzerEingabe

        static string HoleBenutzerEingabe(string auforderungSummanden)
        {
            Console.WriteLine(auforderungSummanden);
            string summand = Console.ReadLine();

            return summand;

        }

        static double Berechnung(double ersteZahl, double zweiteZahl, string operatoren)
        {
            double ergebnis = 0;

            switch (operatoren)
            {

                case "+": //addieren beiden Werte mit der Methode Addieren
                    ergebnis = Addiere(ersteZahl, zweiteZahl);

                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "-":
                    ergebnis = Subtrahiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "*":
                    ergebnis = Multipliziere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "/":
                    ergebnis = Dividiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis: {0} ", ergebnis);

                    break;


                default:
                    Console.WriteLine("Ungültige Operation, Abbruch");

                    break;
            }
            return ergebnis;
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
        
        

    }
}
