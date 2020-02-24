using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public abstract class AbstractBuilder : IEmailBuilder
    {
        protected object _input;
        protected string _result;

        public abstract void Build();

        public void Setup(object input) // prende l'input , salva l'input a seconda di quello che gli serve, nei bilder concreti con as definirò il destinatario
        {
            _input = input;
        }

        public override string ToString()  // anche se non è toString ma ToMail
        {
            return _result;
        }
    }
}
