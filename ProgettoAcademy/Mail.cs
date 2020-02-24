using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    class Mail
    {

        private string _mittente;
        private string _destinatario;
        private string _subject;
        private string _body;
        
        public Mail(string mitt, string dest, string oggetto , string body) {

            _mittente = mitt;
            _destinatario = dest;
            _subject = oggetto;
            _body = body;
        }
       
        


    }

   
}
