using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class BuilderSelector : IBuilderSelector
    {
        public Dictionary<BuilderType, IEmailBuilder> _builderSelector = new Dictionary<BuilderType, IEmailBuilder>()
        {
            { BuilderType.DEFAULT, BuilderDefault.Instance },
            { BuilderType.COMPLEANNO, BuilderCompleanno.Instance },
            { BuilderType.NATALE, BuilderNatale.Instance}
        };
        public IEmailBuilder GetBuilder(BuilderType key)
        {

            if (this._builderSelector.ContainsKey(key))
                return _builderSelector[key];
            else
                return _builderSelector[BuilderType.DEFAULT];
        }
    }
}
