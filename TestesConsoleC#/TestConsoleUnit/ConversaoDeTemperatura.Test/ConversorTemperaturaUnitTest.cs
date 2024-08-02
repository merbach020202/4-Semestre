using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConversaoDeTemperatura.Test
{
    // Define uma classe de teste para o conversor de temperatura
    public class ConversorTemperaturaUnitTest
    {
        // Atributo Theory permite passar múltiplos valores de entrada para o método de teste
        [Theory]
        // InlineData fornece os valores de entrada e os resultados esperados para o teste
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(-40, -40)]
        [InlineData(37, 98.6)]
        // Método de teste que verifica a conversão de Celsius para Fahrenheit
        public void TestarMetodoConverterCelsiusParaFahrenheit(double celsius, double resultadoEsperado)
        {
            // Act - executa o método que está sendo testado
            var resultado = ConversorTemperatura.ConverterCelsiusParaFahrenheit(celsius);

            // Assert - verifica se o resultado é igual ao esperado, com uma tolerância de 1 decimal
            Assert.Equal(resultadoEsperado, resultado, 1);
        }
    }
}

