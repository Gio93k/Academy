using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class EmailManager : IEmailManager
    {


        public void Execute()
        {
            IInput input = new ConsoleInput();
            string inputstring = input.GetInput(); // ottengo la stringa digitata da tastiera es Compleanno

            IInputConverter inputC = new InputConverter();  // la converto a template 
            BuilderType inputDaconvertire = inputC.GetTemplateFromInput(inputstring); // in inputDaConvertire ho la conversione a BuilderType ossia a template del mio input scritto

            // fare il validatorresult che mi chiama torna il destinatario da  dare al validator per validarlo
            IDB db = new DBMock();
            List<Destinatario> destinatari = db.GetDestinatari();

            foreach(Destinatario destinatario in destinatari)
            {
                IValidator validator = new Validator();
                ValidatorResult vr = validator.ValidateDest(destinatario);

                // continua... 
            }
            // 

        }
    }
}
