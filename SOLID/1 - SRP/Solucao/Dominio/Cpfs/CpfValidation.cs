namespace SOLID.SRP.Solucao.Dominio.Cpfs
{
    public partial class Cpf
    {
        public bool isValid()
        {
            return Number.Length == 11;
        }
    }
}