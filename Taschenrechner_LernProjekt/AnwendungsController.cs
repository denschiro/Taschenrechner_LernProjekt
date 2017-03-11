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

            //Abfrage der EIngabe 
            view.HoleEingabenFuerErsteBerechnungVomBenutzer(); //view.HoleEingabeVomBenutzer();


            //Berechnung
            model.Berechne();


            //Ausgabe der Ergbnisse
            view.GibResultatAus();

            //Abbruch / beenden mit Enter
            //view.WarteAufEndeDurchBenutzer();
            view.HoleEingabenFuerFortlaufendeBerechnung();
            
            while (!view.BenutzerWillBeenden)
             {
                model.Berechne();
                view.GibResultatAus();
                view.HoleEingabenFuerFortlaufendeBerechnung();
            }


        }

    }
}
