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

       // BenutzerWillBeenden = false;
        

        public ConsoleView(RechnerModel model)  //Konstruktor
        {
            this.model = model;             //Attribut (li) wie auch Parameter (re) heißt model  
        }

      // public void HoleEingabeVomBenutzer()
            public bool BenutzerWillBeenden { get; private set; }

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();

        }

        ///
        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNaechsteAktionVomBenutzer();

            if (eingabe == "Fertig")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (Fertig zum Beenden): ");
            return Console.ReadLine();
        }
        ///
            
            // Methode HoleZahlVomBenutzerEingabe 
       private double HoleZahlVomBenutzer()
        {

            string zahl;
            Console.Write("Bitte Zahl eingeben: ");
            zahl = Console.ReadLine();
           return Convert.ToDouble(zahl);
        }

        // Methode HoleOperatorVomBenutzerEingabe 
        private string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte Operator  ( + - / *  ) angeben: ");
            return Console.ReadLine();
        }


        //// Methode WarteAufEndeDurcgBenutzer  
        //public string WarteAufEndeDurchBenutzer()
        //{
        //    Console.Write("Zum beenden bitte Return drücken! ");
        //    return Console.ReadLine();
        //}



        //Ausgabe von Resultaten


        public double GibResultatAus()
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
