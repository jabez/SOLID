using SOLID.ISP.Solucao.Interfaces;

namespace SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }

        public void SalvarBanco()
        {
            //salvar os dados do cliente na base de dados
        }

        public void ValidarDados()
        {
            // Validar os dados do cliente
        }
    }
}