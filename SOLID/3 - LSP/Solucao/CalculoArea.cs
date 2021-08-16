using System;

namespace SOLID.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quadrado = new Quadrado(5,5);
            var retangulo = new Retangulo(10,5);

            ObterAreaParalelogramo(quadrado);
            ObterAreaParalelogramo(retangulo);
        }
    }
}