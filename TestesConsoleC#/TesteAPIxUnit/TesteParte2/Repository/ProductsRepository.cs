using ProuctsApi.Interfaces;
using TesteParte2.Contexts;
using TesteParte2.Domains;


namespace TesteParte2.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly Context ctx;

        public ProductsRepository()
        {
            ctx = new Context();
        }

        public void Delete(Guid id)
        {
            var produ = ctx.Products.Find(id);

            ctx.Products.Remove(produ);

            ctx.SaveChanges();
        }

        public List<Products> Get()
        {
            return ctx.Products.ToList();
        }

        public Products GetById(Guid id)
        {
            var p = ctx.Products.Find(id);

            return p;
        }

        public void Post(Products products)
        {
            ctx.Products.Add(products);
            ctx.SaveChanges();
        }

        public void Put(Guid id, Products product)
        {
            var p = ctx.Products.Find(id);

            if (product.Name != null)
                p.Name = product.Name;
            if (product.Price != null)
                p.Price = product.Price;

            ctx.Products.Update(p);
            ctx.SaveChanges();
        }
    }
}
