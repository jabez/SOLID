using Microsoft.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violacao
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public string AddClient(){

            if(string.IsNullOrEmpty(Email))
                return "E-mail inválido!!";

            if(Cpf.Length != 11)
                return "Cpf inválido!!";

            using var connection = new SqlConnection("BaseCliente");
            using var command = connection.CreateCommand();

            command.CommandText = "INSERT INTO CLIENTE (Name, EMAIL CPF) VALUES (@name, @email, @cpf))";

            command.Parameters.AddWithValue("name",Name);
            command.Parameters.AddWithValue("email", Email);
            command.Parameters.AddWithValue("cpf", Cpf);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


            var mailMessage = new MailMessage("empresa@empresa.com",Email);
            var smtpClient = new SmtpClient(){
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = "Bem vindo!";
            mailMessage.Body = "Parabéns! Você está cadastrado.";
            smtpClient.Send(mailMessage);

            return "E-mail enviado com sucesso";
        }
    }
}