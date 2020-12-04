using SOLID.SRP.Solucao.Dominio.Clients;
using SOLID.SRP.Solucao.Interfaces.Repositories;
using Microsoft.Data.SqlClient;

namespace SOLID.SRP.Solucao.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public void SaveClient(Client client)
        {
            using var connection = new SqlConnection("BaseCliente");
            using var command = connection.CreateCommand();

            command.CommandText = "INSERT INTO CLIENTE (Name, EMAIL CPF) VALUES (@name, @email, @cpf))";

            command.Parameters.AddWithValue("name", client.Name);
            command.Parameters.AddWithValue("email", client.Email);
            command.Parameters.AddWithValue("cpf", client.Cpf);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}