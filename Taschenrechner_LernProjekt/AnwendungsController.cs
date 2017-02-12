using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_LernProjekt
{
    class AnwendungsController
    {
        private ConsoleView view;      //Attribute zugewiesen
        private RechnerModel model;     //Attribute zugewiesen


        public AnwendungsController(ConsoleView view, RechnerModel model )
        {
            this.view = view;
            this.model = model;

        }

        public void Ausführen()
        {

            double ersteZahl = view.HoleZahlVomBenutzer();
            string operatoren = view.HoleOperatorVomBenutzer();
            double zweiteZahl = view.HoleZahlVomBenutzer();



            ////Werte von String zu Double konvertierten
            //double ersteZahl = Convert.ToDouble(ersteZahlAlsString);
            //double zweiteZahl = Convert.ToDouble(zweiteZahlAlsString);


            //Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operatoren);


            //Ausgabe der Ergbnisse
            view.Ausgabe(operatoren);

            view.WarteAufEndeDurchBenutzer();


        }

    }
}
