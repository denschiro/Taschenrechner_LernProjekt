using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_LernProjekt
{
    class ConsoleView
    {
        private RechnerModel model;  //Attriut

        public ConsoleView(RechnerModel model)  //Konstruktor
        {
            this.model = model;             //Attribut (li) wie auch Parameter (re) heißt model  
        }

        //Hole Benutzereingabe
        public string HoleBenutzerEingabe(string auforderungSummanden)
        {
            Console.WriteLine(auforderungSummanden);
            string summand = Console.ReadLine();

            return summand;

        }

        //Ausgabe von Resultaten


       public double Ausgabe( string operatoren)
        {

            switch (operatoren)
            {

                case "+": //addieren beiden Werte mit der Methode Addieren


                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis der Addition: {0} ", model.Resultat );
                    break;

                case "-":

                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis der Subtraktion: {0} ", model.Resultat);
                    break;

                case "*":

                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis der Multiplikation: {0} ", model.Resultat);
                    break;

                case "/":

                    //Ausgabe des Ergebnis
                    Console.WriteLine("Ergebnis der Division: {0} ", model.Resultat);

                    break;


                default:
                    Console.WriteLine("Ungültige Operation, Abbruch");

                    break;
            }
            return model.Resultat;
               
                
          }



    }
}
