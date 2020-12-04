namespace SOLID.SRP.Solucao.Dominio.Emails
{
    public partial class Email
    {
        public bool isValid()
        {
            return Address.Contains("@");
        }
    }
}