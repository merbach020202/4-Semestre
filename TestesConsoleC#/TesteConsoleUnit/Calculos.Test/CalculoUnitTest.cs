using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //AAA : Act, Arrange, Assert
        //AAA : Agir, Organizar e Assertir
        [Fact]
        public void TestarMetodoSomar()
        {
            // Arrange
            var x1 = 4.1;
            var x2 = 5.9;
            var valorEsperado = 10;

            // Act
            var soma = Calculo.Somar(x1, x2);

            // Assert
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void TestarMetodoSubtrair()
        {
            // Arrange
            var x1 = 10;
            var x2 = 5.5;
            var valorEsperado = 4.5;

            // Act
            var resultado = Calculo.Subtrair(x1, x2);

            // Assert
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void TestarMetodoMultiplicar()
        {
            var x1 = 4;
            var x2 = 2.5;
            var valorEsperado = 10;

            var resultado = Calculo.Multiplicar(x1, x2);

            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void TestarMetodoDividir()
        {
            var x1 = 10;
            var x2 = 2;
            var valorEsperado = 5;

            var resultado = Calculo.Dividir(x1, x2);

            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void TestarMetodoDividirPorZero()
        {
            // Arrange
            var x1 = 10;
            var x2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calculo.Dividir(x1, x2));
        }
    }
}
