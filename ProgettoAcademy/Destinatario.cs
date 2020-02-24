using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAcademy
{
    public class Destinatario
    {
        
            private int _id;
            private string _username;
                 private DateTime? _birthday;
        private string _data;
            private string _email;
            private bool _isAdmin;
            private bool _isDeleted;

        public Destinatario(int id, string username, DateTime? birth, string email, bool isAdmin, bool isDeleted)
        {
            Id = id;
            Username = username;
            Birthday = birth;
           
            Email = email;
            IsAdmin = isAdmin;
            IsDeleted = isDeleted;
        }

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Data { get => _data; set => _data = value; }
        public string Email { get => _email; set => _email = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }
        public DateTime? Birthday{ get => _birthday; set => _birthday = value; }

        public override string ToString()   //Converte a stringa le informazioni dell'oggetto e lo stampa
        {
            return String.Format("{0}: {1}, {2}, {3}", Id, Username, Data, Email);
        }
    }
}

