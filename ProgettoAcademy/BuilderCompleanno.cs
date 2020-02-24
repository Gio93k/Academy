using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class BuilderCompleanno : AbstractBuilder
    {
        // data compleanno , nome utente (?)

        private static BuilderCompleanno _instance = null;
        private static readonly object padlock = new object();

        public static BuilderCompleanno Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BuilderCompleanno();
                        }
                    }
                }
                return _instance;
            }
        }

        public override void Build()
        { 
            //costruisce l'oggetto
            Destinatario d = _input as Destinatario;
          //  _result = new Mail(d.Username,"Buon Compleanno "+d.Username, "nato il "+ d.Data ).ToString();
           
        }

    }
}

