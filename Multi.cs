namespace Calculadora
{
    public class Multiplicacao : Calc
    {
        public double ValorPrimario { get; set; }
        public double ValorSecundario { get; set; }
        public override double Resultado => this.ValorPrimario * this.ValorSecundario;
    }
}