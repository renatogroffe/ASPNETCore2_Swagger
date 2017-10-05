using System;
using Microsoft.AspNetCore.Mvc;

namespace APITemperatura.Controllers
{
    [Route("api/[controller]")]
    public class ConversorTemperaturasController : Controller
    {
        /// <summary>
        /// Transforma uma temperatura em Fahrenheit para o equivalente
        /// nas escalas Celsius e Kelvin.
        /// </summary>
        /// <param name="temperatura">Temperatura em Fahrenheit</param>
        /// <returns>Objeto contendo valores para uma temperatura
        /// nas escalas Fahrenheit, Celsius e Kelvin.</returns>
        [HttpGet("Fahrenheit/{temperatura}")]
        public object GetConversaoFahrenheit(double temperatura)
        {
            Temperatura dados = new Temperatura();
            dados.ValorFahrenheit = temperatura;
            dados.ValorCelsius =
                Math.Round((temperatura - 32.0) / 1.8, 2);
            dados.ValorKelvin = dados.ValorCelsius + 273.15;

            return dados;
        }
    }
}