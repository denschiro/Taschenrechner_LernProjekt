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

            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string ersteZahlAlsString = view.HoleBenutzerEingabe("Bitte ersten Wert eingeben: ");

            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string zweiteZahlAslsString = view.HoleBenutzerEingabe("Bitte zweiten Wert eingeben: ");

            //Verwendung der Methode HoleBenutzerEingabe mit Text und Rückgabe
            string operatoren = view.HoleBenutzerEingabe("Bitte Operation auswählen angeben ( + , - , / , *): ");


            //Werte von String zu Double konvertierten
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAslsString);

            //Berechnung
             model.Berechne (ersteZahl, zweiteZahl, operatoren);

            //Ausgabe der Ergbnisse
            view.Ausgabe( operatoren);

         view.HoleBenutzerEingabe("Bitte zum beenden Return drücken");

        }


     

    
        

    }
}
