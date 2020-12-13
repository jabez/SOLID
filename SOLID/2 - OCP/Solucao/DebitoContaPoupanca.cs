using System;

namespace SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : IDebitoEmConta
    {
        public void Debitar(decimal valor, string conta)
        {
            // lógica para debitar da conta poupança aqui
            Console.WriteLine("Efetuando Débito em conta poupança!!");
            Console.WriteLine("Débito em conta poupança efetuado com sucesso!!");
        }
    }
}