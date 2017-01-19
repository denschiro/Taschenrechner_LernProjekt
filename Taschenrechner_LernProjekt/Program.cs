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

            //Berechnung
            RechnerModel model = new RechnerModel();
            double ergebnis = model.Berechne (ersteZahl, zweiteZahl, operatoren);

            Ausgabe(ergebnis, operatoren);

         HoleBenutzerEingabe("Bitte zum beenden Return drücken");

        }


        static string HoleBenutzerEingabe(string auforderungSummanden)
        {
            Console.WriteLine(auforderungSummanden);
            string summand = Console.ReadLine();

            return summand;

        }

        

        static double Ausgabe (double ergebnis, string operatoren)
        { 

            switch (operatoren)
            {

                case "+": //addieren beiden Werte mit der Methode Addieren
                    

        //Ausgabe des Ergebnis
        Console.WriteLine("Ergebnis der Addition: {0} ", ergebnis);
                    break;

                case "-":
                
        //Ausgabe des Ergebnis
        Console.WriteLine("Ergebnis der Subtraktion: {0} ", ergebnis);
                    break;

                case "*":
             
        //Ausgabe des Ergebnis
        Console.WriteLine("Ergebnis der Multiplikation: {0} ", ergebnis);
                    break;

                case "/":
                  
        //Ausgabe des Ergebnis
        Console.WriteLine("Ergebnis der Division: {0} ", ergebnis);

                    break;


                default:
                    Console.WriteLine("Ungültige Operation, Abbruch");

                    break;
            }
            return ergebnis;
        }


        

    }
}
