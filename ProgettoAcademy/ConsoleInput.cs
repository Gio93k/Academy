using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class ConsoleInput : IInput
    {
        public string GetInput()
        {
            Console.WriteLine("Inserisci template");
            string input = Console.ReadLine();
            return input;
        }
    }
}
