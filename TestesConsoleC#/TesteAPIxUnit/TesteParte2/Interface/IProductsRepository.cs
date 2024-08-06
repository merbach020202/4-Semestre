using TesteParte2.Domains;

namespace ProuctsApi.Interfaces
{
    public interface IProductsRepository
    {
        List<Products> Get();

        void Post(Products products);

        void Delete(Guid id);

        Products GetById(Guid id);

        void Put(Guid id, Products product);
    }
}