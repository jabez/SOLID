namespace SOLID.OCP.Violacao
{
    public class CaixaEletronico
    {
        public static void Main2(string [] args){

            var debitoConta = new DebitoConta();

            debitoConta.Debitar(100.00M,"1234", TipoConta.Corrente);
            debitoConta.Debitar(100.00M, "123456", TipoConta.Poupanca);
        }
    }
}