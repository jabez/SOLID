namespace SOLID.OCP.Solucao
{
    public interface IDebitoEmConta
    {
        void Debitar(decimal valor, string conta);
    }
}