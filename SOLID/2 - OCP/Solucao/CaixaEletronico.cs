namespace SOLID.OCP.Solucao
{
    public class CaixaEletronico
    {
        public static void Main(string[] args)
        {
            IDebitoEmConta contaCorrente = new DebitoContaCorrente();
            IDebitoEmConta contaPoupanca = new DebitoContaPoupanca();
            IDebitoEmConta contaInvestimento = new DebitoContaInvestimento();

            contaCorrente.Debitar(100.00M, "1234");
            contaPoupanca.Debitar(100.00M, "1234");
            contaInvestimento.Debitar(100.00M,"1234");
        }
    }
}