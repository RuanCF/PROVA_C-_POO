namespace Calculadora
{
    public class Divisao : Calc
    {
        public double ValorPrimario { get; set; }
        public double ValorSecundario { get; set; }
        public override double Resultado => this.ValorPrimario / this.ValorSecundario;
    }
}