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
        public string Operation { get; set; }

        public double ErsteZahl { get; set; }

        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            Resultat = 0;  // Konstruktor der Resultat erstmal mit 0 definiert.
            Operation = "unbekannt";
        }


        public void Berechne()
        {
           

                    switch (Operation)
            {

                case "+": //addieren beiden Werte mit der Methode Addieren
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);

                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
            
                    break;

                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    
                    break;

                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    
                    break;



                   
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
