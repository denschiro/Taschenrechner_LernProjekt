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

        //////Hole Benutzereingabe
        ////public string HoleBenutzerEingabe(string auforderungSummanden)
        ////{
        ////    Console.WriteLine(auforderungSummanden);
        ////    string summand = Console.ReadLine();

        ////    return summand;

        ////}


        // Methode HoleZahlVomBenutzerEingabe 
        public double HoleZahlVomBenutzer()
        {

            string zahl;
            Console.Write("Bitte Zahl eingeben: ");
            zahl = Console.ReadLine();
           return Convert.ToDouble(zahl);
        }

        // Methode HoleZahlVomBenutzerEingabe 
        public string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte Operator  ( + - / *  ) angeben: ");
            return Console.ReadLine();
        }


        // Methode HoleZahlVomBenutzerEingabe 
        public string WarteAufEndeDurchBenutzer()
        {
            Console.Write("Zum beenden bitte Return drücken! ");
            return Console.ReadLine();
        }



        //Ausgabe von Resultaten


        public double Ausgabe()
        {

            switch (model.Operation)
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
