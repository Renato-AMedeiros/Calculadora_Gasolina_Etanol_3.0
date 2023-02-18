using Calculadora_Gasolina_Etanol_3._0;
using Microsoft.AspNetCore.Mvc;

namespace CGE.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController: ControllerBase
    {
        [HttpGet("CalcularVantagem")]
        public string CalcularVantagem(double precoGasolina, double precoEtanol)
        {
            var calculadora = new CalcularRazao();

            calculadora.CombustivelA = precoGasolina;
            calculadora.CombustivelB = precoEtanol;

            var vantagem = calculadora.CalcularVantagem();

            // Validação de erro
            if (precoGasolina == 0 || precoEtanol == 0)
            {
                return "Os valores de preço não podem ser 0";
            }

            // Mostrar mensagem
            if (vantagem == "G")
            {
                return "O combustível mais vantajoso é a gasolina.";
            }
            else
            {
                return "O combustível mais vantajoso é o Etanol.";
            }
        }

        // ATIVIDADES
        /*  1 - Criar um novo endpoint mais completo chamado CalcularEconomia
            2 - Retornar a mensagem "A economia é de $$,$$"
         */
    }
}
