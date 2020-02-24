using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{

    
    class Program
    {   public static Dictionary<string, BuilderType> _templates = new Dictionary<string,BuilderType>()
        {
            {"Natale",BuilderType.NATALE },
            {"Compleanno",BuilderType.COMPLEANNO}, //Fatto
        };
          
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci template");
            string input = Console.ReadLine();
            BuilderType template = BuilderType.DEFAULT;   //fatto

            if (_templates.ContainsKey(input))
            {
                template = _templates[input];
            }
            
          //  Destinatario u1 = new Destinatario(1, "Luca Stornaiuolo", "20/04/1985", "luca.stornaiuolo@avanade.com", true, false); 
           // Destinatario u2 = new Destinatario(2, "Gaetano Ferraro", null, "gaetano.ferraro@avanade.com", false, false);
          //  Destinatario u3 = new Destinatario(3, "Luca Stornaiuolo", "01/06/1987", null, false, false);
            
            List<Destinatario> destinatari = new List<Destinatario>();   //Fatto
         //   destinatari.Add(u1);
         //   destinatari.Add(u2);
         //   destinatari.Add(u3);
            Console.WriteLine("Seleziona destinatario ");
            
            foreach(Destinatario d in destinatari)
            {
                Console.WriteLine(d); //Stampa grazie al ToString di cui ho fatto l'override in Dizionario
            }
            string inputD = Console.ReadLine(); //salva la scelta del destinatario inserita da tastiera
            try
            {
                int result = Int32.Parse(inputD); //converto la scelta a intero e poi lo uso come esatto destinatario appunto scelto della mail

                BuilderCompleanno bc = new BuilderCompleanno();   
                bc.Setup(destinatari[result - 1]);   //passo al Setup del mio concreto builder, il mio destinatario scelto, così posso usare quei dati per riempire i parametri del corpo della mail
                bc.Build();
                Console.WriteLine (bc); //STAMPA LA MAIL CON TUTTI I PARAMETRI
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse '{inputD}'");
            }

            Console.ReadLine();
        }
        
        
        
        
    }

        
}
    


