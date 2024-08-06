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
        public void Post()
        {
            var products = new List<Products>
            {
                new products { IdProduct = Guid.NewGuid(), Name = "Produto", Price = 10 }
            };
        }

        [Fact]
        public void GetById() 
        {
            
        }


        [Fact]
        public void Delete() 
        {
            
        }


        [Fact]
        public void Update()
        {

        }
    }
}