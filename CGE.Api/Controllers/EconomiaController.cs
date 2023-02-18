using Calculadora_Gasolina_Etanol_3._0;
using Microsoft.AspNetCore.Mvc;

namespace CGE.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EconomiaController : ControllerBase
    {
        [HttpGet("CalcularEconomia")]
        public string CalcularEconomia(double EconomiaGasolina, double EconomiaEtanol)
        {
            var CombustivelMaisEconomico = new CalcularRazao();
           
            CombustivelMaisEconomico.EconomiaG = EconomiaGasolina;

            CombustivelMaisEconomico.EconomiaE = EconomiaEtanol;
           
           

            if (EconomiaGasolina >= EconomiaEtanol)
            {
                return " Economia de: " + EconomiaGasolina;

            }
           else 
            {
                return "Economia de: " + EconomiaEtanol;
            }



    }





    }
}
