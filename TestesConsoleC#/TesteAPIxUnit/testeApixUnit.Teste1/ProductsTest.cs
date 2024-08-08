using Moq;
using ProuctsApi.Interfaces;
using TesteParte2.Domains;

namespace testeApixUnit.Teste1
{
    public class ProductsTest
    {
        //Indica que é o método de teste de unidade
        [Fact]
        public void Get()
        {
            //Arrange - Organizar (Cenário)

            var products = new List<Products>
            {
                new() {IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 10},
                new() {IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 20},
                new() {IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 30}
            };


            //Cria um objeto de simulação do tipo ProductsRepository
            var mockRepository = new Mock<IProductsRepository>();

            //Configura o método GetProducts para retornar a lista de produtos "mock"
             mockRepository.Setup(x => x.Get()).Returns(products);
            

            //Act - Agir

            //Chama o método GetProducts e armazena o resultado em result
            var result = mockRepository.Object.Get();

            //Assert - Provar

            //Prova se o resultado esperado é igual ao resultado obtido
            Assert.Equal(3, result.Count);

        }


        [Fact]
        public void GetById()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var product = new Products { IdProduct = productId, Name = "Produto 5", Price = 90 };
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.GetById(productId)).Returns(product);
            // Act
            var result = mockRepository.Object.GetById(productId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Produto 5", result.Name);
            Assert.Equal(90, result.Price);
        }

        [Fact]
        public void Delete()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Delete(productId));

            // Act
            mockRepository.Object.Delete(productId);

            // Assert
            mockRepository.Verify(x => x.Delete(productId), Times.Once);
        }

        [Fact]
        public void Update()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var product = new Products { IdProduct = productId, Name = "Produto Atualizado", Price = 100 };
            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Put(productId, It.IsAny<Products>()));

            // Act
            mockRepository.Object.Put(productId, product);

            // Assert
            mockRepository.Verify(x => x.Put(productId, It.Is<Products>(p => p.Name == "Produto Atualizado" && p.Price == 100)), Times.Once);
        }
    }
}

