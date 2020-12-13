using System;

namespace SOLID.OCP.Solucao
{
    public class DebitoContaInvestimento : IDebitoEmConta
    {
        public void Debitar(decimal valor, string conta)
        {
            // lógica para debitar da conta investimento aqui
            Console.WriteLine("Efetuando Débito em conta investimento!!");
            Console.WriteLine("Débito em conta investimento efetuado com sucesso!!");
        }
    }
}