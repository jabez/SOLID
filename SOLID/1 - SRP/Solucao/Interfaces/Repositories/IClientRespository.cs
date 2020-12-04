using SOLID.SRP.Solucao.Dominio.Clients;

namespace SOLID.SRP.Solucao.Interfaces.Repositories
{
    public interface IClientRepository
    {
        void SaveClient(Client client);
    }
}