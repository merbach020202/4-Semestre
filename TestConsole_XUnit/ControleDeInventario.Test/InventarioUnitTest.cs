using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ControleDeInventario.Test
{
    public class InventarioUnitTest
    {
        [Fact]
        public void TestarMetodoAdicionarProduto()
        {
            // Arrange
            var produto = "Produto Teste";
            var quantidade = 5;

            // Act
            Inventario.AdicionarProduto(produto, quantidade);

            // Assert
            Assert.Equal(quantidade, Inventario.ObterQuantidadeProduto(produto));
        }

        [Fact]
        public void TestarMetodoAdicionarProdutoExistente()
        {
            // Arrange
            var produto = "Produto Teste";
            var quantidadeInicial = 5;
            var quantidadeAdicional = 3;

            // Act
            Inventario.AdicionarProduto(produto, quantidadeInicial);
            Inventario.AdicionarProduto(produto, quantidadeAdicional);

            // Assert
            Assert.Equal(quantidadeInicial + quantidadeAdicional, Inventario.ObterQuantidadeProduto(produto));
        }

        [Fact]
        public void TestarMetodoObterQuantidadeProdutoInexistente()
        {
            // Arrange
            var produto = "Produto Inexistente";

            // Act
            var quantidade = Inventario.ObterQuantidadeProduto(produto);

            // Assert
            Assert.Equal(0, quantidade);
        }
    }
}
