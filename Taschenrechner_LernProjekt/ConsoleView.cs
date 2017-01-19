using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_LernProjekt
{
    class ConsoleView
    {

        //Hole Benutzereingabe
        public string HoleBenutzerEingabe(string auforderungSummanden)
        {
            Console.WriteLine(auforderungSummanden);
            string summand = Console.ReadLine();

            return summand;

        }

        //Ausgabe von Resultaten


       public double Ausgabe(double ergebnis, string operatoren)
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
