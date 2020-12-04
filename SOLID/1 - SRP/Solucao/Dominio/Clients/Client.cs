using SOLID.SRP.Solucao.Dominio.Cpfs;
using SOLID.SRP.Solucao.Dominio.Emails;

namespace SOLID.SRP.Solucao.Dominio.Clients
{
    public partial class Client
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        public Email Email {get; set;}
        public Cpf Cpf {get;set;}
    }
}