///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//A aplicação foi feita por Ruan Ferreira e Fábio Higor.
//
//
//Utilizamos como base e orientação o site do José Carlos Macoratti.
//https://www.macoratti.net/18/12/c_ooprat1.htm
//
//
//O objetivo da nossa aplicação é uma calculadora utilizando os conceitos de pogramação orientada a objetos.
//Calculando Soma, Divisão, Subtração e Multiplicação em classes com tela de selecão.
//Conhecimentos adquiridos: Principalmente eu(Ruan) aprendi melhor sobre classes, heranças, polimorfismo e enum.
//Mesmo com a base do projeto do Macoratti, os conhecimentos obtidos foram positivos.
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace Calculadora
{
    class MainHall
    {
        //Uma das maiores contribuições que Macoratti transmitiu para mim foi sobre enumeração

        public enum Menu
        {
            Soma = 1,
            Subtração = 2,
            Divisão = 3,
            Multiplicação = 4,
            Sair = 0
        }
        static void Main(string[] args)
        {
            Menu escolha = Menu.Soma;

            while ((escolha = GetEscolha()) != Menu.Sair)
            {   
                Calc calculo = null;

                switch (escolha)
                {
                    case Menu.Soma:
                        calculo = CriaSoma();
                        break;
                        
                    case Menu.Subtração:
                        calculo = CriaSubt();
                        break;

                    case Menu.Divisão:
                        calculo = CriaDivi();
                        break;

                    case Menu.Multiplicação:
                        calculo = CriaMult();
                        break;

                    default:
                        break;
                }
                Console.WriteLine($"A área do {escolha} é {calculo.Resultado}");
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        public static Menu GetEscolha()
        {
            Console.WriteLine("Escolha uma das opções de cálculo:");
            Console.WriteLine("\t{0} - Soma", (int)Menu.Soma);
            Console.WriteLine("\t{0} - Subtração", (int)Menu.Subtração);
            Console.WriteLine("\t{0} - Divisão", (int)Menu.Divisão);
            Console.WriteLine("\t{0} - Multiplicação", (int)Menu.Multiplicação);
            Console.WriteLine("\t{0} - Sair", (int)Menu.Sair);
            Console.Write("Escolha : ");

            string valor = Console.ReadLine();
            Menu escolha;

            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(Menu), escolha))
            {
                Console.WriteLine("opção inválida, Escolha uma opção válida.");
                return GetEscolha();
            }
            return escolha;
        }

        //O método GetDouble() irá receber a entrada do usuário e irá converte para double verificando se é um valor válido.
        private static double GetDouble(string prompt)
        {
            bool isValido = false;
            double valor = 0;
            while (!isValido)
            {
                Console.Write(prompt);
                isValido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }

        private static Soma CriaSoma()
        {
            double valor1 = GetDouble("Primeiro valor: ");
            double valor2 = GetDouble("Segundo valor: ");
            return new Soma()
            {
                ValorPrimario = valor1,
                ValorSecundario = valor2
            };
        }

        private static Subtracao CriaSubt()
        {
            double valor1 = GetDouble("Primeiro valor: ");
            double valor2 = GetDouble("Segundo valor: ");
            return new Subtracao()
            {
                ValorPrimario = valor1,
                ValorSecundario = valor2
            };
        }

        private static Divisao CriaDivi()
        {
            double valor1 = GetDouble("Primeiro valor: ");
            double valor2 = GetDouble("Segundo valor: ");
            return new Divisao()
            {
                ValorPrimario = valor1,
                ValorSecundario = valor2
            };
        }

        private static Multiplicacao CriaMult()
        {
            double valor1 = GetDouble("Primeiro valor: ");
            double valor2 = GetDouble("Segundo valor: ");
            return new Multiplicacao()
            {
                ValorPrimario = valor1,
                ValorSecundario = valor2
            };
        }

    }
}