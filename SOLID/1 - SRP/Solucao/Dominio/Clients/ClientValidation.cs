namespace SOLID.SRP.Solucao.Dominio.Clients
{
    public partial class Client
    {
        public bool isValid()
        {
            return Email.isValid() && Cpf.isValid();
        }
    }
}