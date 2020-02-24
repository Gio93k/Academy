using System.Collections.Generic;

namespace ProgettoAcademy
{
    public interface IInputHelper
    {
         Dictionary<string, string> ToDictionary(Destinatario destinatario, Dictionary<string, string> input = null);

        Dictionary<string, string> ToDictionary(string error, Dictionary<string, string> input = null);
    }
}