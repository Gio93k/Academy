using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public static class InputHelper 
    {
        public static Dictionary<string, string> ToDictionary(Destinatario destinatario, Dictionary<string, string> input = null)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (input != null)
            {
                result = new Dictionary<string, string>(input);
            }
            result.Add("ID", destinatario.Id.ToString());
            result.Add("USERNAME", destinatario.Username);
            result.Add("BIRTHDATE", destinatario.Birthday.ToString());
            result.Add("EMAIL", destinatario.Email);
            result.Add("ISADMIN", destinatario.IsAdmin.ToString());
            result.Add("ISDELETED", destinatario.IsDeleted.ToString());
            return result;
        }

        public static Dictionary<string, string> ToDictionary(string error, Dictionary<string, string> input = null)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (input != null)
            {
                result = new Dictionary<string, string>(input);
            }
            result.Add("ERROR", error);
            return result;
        }
    }
}
