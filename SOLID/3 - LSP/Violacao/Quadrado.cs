namespace SOLID.LSP.Violacao
{
    public class Quadrado : Retangulo
    {
        public override double Altura { set {base.Largura = base.Altura = value; }  }
        public override double Largura { set { base.Largura = base.Altura = value; } }
    }
}