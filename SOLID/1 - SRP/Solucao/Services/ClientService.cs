using SOLID.SRP.Solucao.Dominio.Clients;
using SOLID.SRP.Solucao.Interfaces.Repositories;
using SOLID.SRP.Solucao.Interfaces.Services;
using SOLID.SRP.Solucao.Repositories;

namespace SOLID.SRP.Solucao.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailService _emailService;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
            _emailService = new EmailSerivce();
        }

        public string addClient(Client client)
        {
            if(!client.isValid())
                return "Dados inválidos.";

            _clientRepository.SaveClient(client);
            _emailService.Send("email@email.com.br",client.Email.Address,"Bem vindo!!","Parabéns está Cadastrado.");

            return "Cliente cadastrado com sucesso";
        }
    }
}