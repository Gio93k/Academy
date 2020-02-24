namespace ProgettoAcademy
{
    public interface IEmailBuilder { 
        void Setup(object input); //l'oggetto è l'informazione dell'utente per costruire una mail (utrnte) dictionary  GetResult
        void Build(); // costruisce l'oggetto

    string ToString(); // è il ToResult della mail, non credo che sia una stringa
    }
}