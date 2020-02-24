using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class DBMock : IDB
    {
        public List<Destinatario> Destinatari { get; set; }

        public DBMock()
        {
            Destinatari = new List<Destinatario>();
        //Lista di destinatari
        Destinatario u1 = new Destinatario(1, "Luca Stornaiuolo", new DateTime(1985, 4, 20), "luca.stornaiuolo@avanade.com", true, false);
        Destinatario u2 = new Destinatario(2, "Gaetano Ferraro", null, "gaetano.ferraro@avanade.com", false, false);
        Destinatario u3 = new Destinatario(3, "Rosalia Abate", new DateTime(1984,6,2), null, false, false);

        Destinatari.Add(u1);
        Destinatari.Add(u2);
        Destinatari.Add(u3);
        }

        public List<Destinatario> GetDestinatari()
        {
            return Destinatari;
        }
    }
}
