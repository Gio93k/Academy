using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    class BuilderNatale : AbstractBuilder
    {
        private static BuilderNatale _instance = null;

        private static readonly object padlock = new object();


        public static BuilderNatale Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BuilderNatale();
                        }
                    }
                }
                return _instance;
            }
        }

        public override void Build()
        {
            //costruisce l'oggetto
            BuilderSelector bn;
        //  bn.GetBuilder(BuilderType.NATALE);
        }
    }
}
