using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GerenciamentoDeLivros.Test
{
    // Define uma classe de teste para a biblioteca
    public class BibliotecaUnitTest
    {
        // Atributo Fact indica que este é um método de teste unitário
        [Fact]
        public void TestarMetodoAdicionarLivro()
        {
            // Arrange - Configuração do cenário de teste
            var livro = "Livro Teste";

            // Act - Executa o método que está sendo testado
            Biblioteca.AdicionarLivro(livro);
            var livros = Biblioteca.ObterLivros();

            // Assert - Verifica se o resultado é o esperado
            Assert.Contains(livro, livros);
        }
    }
}

