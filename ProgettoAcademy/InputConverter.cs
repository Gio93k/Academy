using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    class InputConverter : IInputConverter
    {

        public static Dictionary<string, BuilderType> _templates = new Dictionary<string, BuilderType>()
        {
            {"Natale",BuilderType.NATALE },
            {"Compleanno",BuilderType.COMPLEANNO},
        };


        public BuilderType GetTemplateFromInput(string key)
        {

            //logica dell'inpout
            if (_templates.ContainsKey(key))
                return _templates[key];
            else
                return _templates["DEFAULT"];
        }
    }
}
