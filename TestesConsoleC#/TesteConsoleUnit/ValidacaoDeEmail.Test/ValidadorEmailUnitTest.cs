using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ValidacaoDeEmail.Test
{
    // Define uma classe de teste para o validador de email
    public class ValidadorEmailUnitTest
    {
        // Atributo Theory permite passar múltiplos valores de entrada para o método de teste
        [Theory]
        // InlineData fornece os valores de entrada e os resultados esperados para o teste
        [InlineData("teste@example.com", true)]
        [InlineData("invalido.com", false)]
        [InlineData("teste@com", false)]
        [InlineData("teste@.com", false)]
        [InlineData("teste@exemplo.com", true)]
        // Método de teste que verifica a validação de emails
        public void TestarMetodoValidarEmail(string email, bool resultadoEsperado)
        {
            // Act - executa o método que está sendo testado
            var resultado = ValidadorEmail.ValidarEmail(email);

            // Assert - verifica se o resultado é igual ao esperado
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}

