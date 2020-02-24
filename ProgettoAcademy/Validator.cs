namespace ProgettoAcademy
{
    public class Validator : IValidator
    {

        public ValidatorResult ValidateDest(Destinatario d)
        {
            ValidatorResult result = new ValidatorResult();

            bool bresult = true;

            if (d.Email == null)
            {
                bresult = false;
                result.Error = "Email nulla!";
            }
            result.Result = bresult;
            result.Destinatario = d;

            return result;
        }



    }
}