using System;

namespace SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                // lógica para debitar da conta corrente aqui
                Console.WriteLine("Efetuando Débito em conta corrente!!");
                Console.WriteLine("Débito em conta corrente efetuado com sucesso!!");
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                // lógica para debitar da conta poupança aqui
                Console.WriteLine("Efetuando Débito em conta poupança!!");
                Console.WriteLine("Débito em conta poupança efetuado com sucesso!!");
            }
        }
    }
}