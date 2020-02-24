using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class BuilderDefault : AbstractBuilder
    {

        // attributi...(?)
        private static BuilderDefault _instance = null;

        private static readonly object padlock = new object(); 

  
        public static BuilderDefault Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BuilderDefault();
                        }
                    }
                }
                return _instance;
            }
        }

        public override void Build()
        {
            //costruisce l'oggetto
            _instance.ToString(); // in realtà il toString fa la mail
        }

    }
}
