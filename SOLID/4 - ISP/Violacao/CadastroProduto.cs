namespace SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Violação!!! Produto não envia email
            throw new System.NotImplementedException();
        }

        public void SalvarBanco()
        {
            // Grava os dados do produto na base de dados
        }

        public void ValidarDados()
        {
            // Faz a validação dos dados do produto
        }
    }
}