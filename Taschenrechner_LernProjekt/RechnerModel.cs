using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_LernProjekt
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;  // Konstruktor der Resultat erstmal mit 0 definiert.
        }


        public void Berechne(double ersteZahl, double zweiteZahl, string operatoren)
        {
                    switch (operatoren)
            {

                case "+": //addieren beiden Werte mit der Methode Addieren
                    Resultat = Addiere(ersteZahl, zweiteZahl);

                    //Ausgabe des Ergebnis
                    //Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    // Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    // Console.WriteLine("Ergebnis: {0} ", ergebnis);
                    break;

                case "/":
                    Resultat = Dividiere(ersteZahl, zweiteZahl);
                    //Ausgabe des Ergebnis
                    // Console.WriteLine("Ergebnis: {0} ", ergebnis);

                    break;


                //default:
                //    Resultat = 0;

                    //break;
            }
           
        }


        
        //Methode Addiere mit Rückgabewert
        private double Addiere(double ersterSummandalsZahl, double zweiterSummandalsZahl)
        {
            double summe = ersterSummandalsZahl + zweiterSummandalsZahl;
            return summe;
        }

        //Methode Subtrahiere mit Rückgabewert
        private double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;
            return differenz;
        }

        private double Dividiere(double basis, double divident)
        {
            double resultat = basis / divident;
            return resultat;
        }

        private double Multipliziere(double multiplient, double basis)
        {
            double multiplikat = multiplient * basis;
            return multiplikat;

        }



    }
}
