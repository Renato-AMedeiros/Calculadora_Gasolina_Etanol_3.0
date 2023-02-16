using System;

namespace Calculadora_Gasolina_Etanol_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularRazao c1 = new CalcularRazao();

            double ValorGasolina, ValorEtanol, ValorAbastecimento, Economia;

            Console.WriteLine("Calculadora Gasolina x Etanol.");

            Console.Write("\nInsira o preço atual da gasolina: R$");
            c1.CombustivelA = ValorGasolina = double.Parse(Console.ReadLine());
            while (ValorGasolina < 0)
            {
                Console.Write("ERRO! \nVocê digitou um número negativo. Insira o preço atual da gasolina válido: ");
                ValorGasolina = double.Parse(Console.ReadLine());


            }

            Console.Write("\nInsira o preço atual do etanol: R$");
            c1.CombustivelB = ValorEtanol = double.Parse(Console.ReadLine());
            while (ValorEtanol < 0)
            {
                Console.Write("ERRO! \nVocê digitou um número negativo. Insira o preço atual do etanol válido: ");
                ValorEtanol = double.Parse(Console.ReadLine());

            }

            Console.Write("\nInsira o valor a abastecer: R$");
           c1.VA = ValorAbastecimento = double.Parse(Console.ReadLine());
            while (ValorAbastecimento < 0)
            {
                Console.Write("ERRO! \nVocê digitou um número negativo. Insira um valor a abastecer válido: ");
                ValorAbastecimento = double.Parse(Console.ReadLine());

            }

            c1.exibirDados();

            Console.Write("\nAperte a tecla ENTER para sair.");
            Console.ReadKey();

            //ALTERAÇÃO DE DADOS CRIADOS PARA TESTE DE BRANCH
        }
    }
}
