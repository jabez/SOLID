using System;

namespace SOLID.OCP.Solucao
{
    public class DebitoContaCorrente : IDebitoEmConta
    {
        public void Debitar(decimal valor, string conta)
        {
            // lógica para debitar da conta corrente aqui
            Console.WriteLine("Efetuando Débito em conta corrente!!");
            Console.WriteLine("Débito em conta corrente efetuado com sucesso!!");
        }
    }
}