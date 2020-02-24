namespace ProgettoAcademy
{
    public interface IBuilderSelector
    {
         IEmailBuilder GetBuilder(BuilderType key);
    }
}