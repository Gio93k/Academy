using System.Collections.Generic;

namespace ProgettoAcademy
{

    public class ValidatorResult
    {
        public bool Result { get; set; }
        public Destinatario Destinatario { get; set; }
        public string Error { get; set; }
    }
}