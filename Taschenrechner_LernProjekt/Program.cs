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

            string ersteZahlAlsString = view.HoleZahlVomBenutzer();
            string operatoren = view.HoleOperatorVomBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVomBenutzer();
            

            //Werte von String zu Double konvertierten
            double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);

            //Berechnung
             model.Berechne (ersteZahl, zweiteZahl, operatoren);

            //Ausgabe der Ergbnisse
            view.Ausgabe( operatoren);

            view.WarteAufEndeDurchBenutzer();

        }


     

    
        

    }
}
