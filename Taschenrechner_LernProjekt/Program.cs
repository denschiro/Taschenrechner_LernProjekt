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
            AnwendungsController controller = new AnwendungsController(view, model);



            controller.Ausführen();


        }


     

    
        

    }
}
