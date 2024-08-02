using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ValidacaoDeEmail.Test
{
    public class ValidadorEmailUnitTest
    {
        [Theory]
        [InlineData("teste@example.com", true)]
        [InlineData("invalido.com", false)]
        [InlineData("teste@com", false)]
        [InlineData("teste@.com", false)]
        [InlineData("teste@exemplo.com", true)]
        public void TestarMetodoValidarEmail(string email, bool resultadoEsperado)
        {
            // Act
            var resultado = ValidadorEmail.ValidarEmail(email);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
