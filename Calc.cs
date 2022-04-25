namespace Calculadora
{
    public abstract class Calc
    {
        public abstract double Resultado { get; } //Só vai receber o valor, então nao poderá ser alterado pelo usuário. então usaremos apenas Get;
    }
}