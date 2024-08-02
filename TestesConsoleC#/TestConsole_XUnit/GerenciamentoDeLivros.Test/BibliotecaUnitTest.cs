using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GerenciamentoDeLivros.Test
{
    public class BibliotecaUnitTest
    {
        [Fact]
        public void TestarMetodoAdicionarLivro()
        {
            // Arrange
            var livro = "Livro Teste";

            // Act
            Biblioteca.AdicionarLivro(livro);
            var livros = Biblioteca.ObterLivros();

            // Assert
            Assert.Contains(livro, livros);
        }
    }
}
