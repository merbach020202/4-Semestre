using Microsoft.AspNetCore.Mvc;
using ProuctsApi.Interfaces;
using TesteParte2.Domains;
using TesteParte2.Repository;

namespace TesteParte2.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]

    public class ProductsController : ControllerBase
    {
        private IProductsRepository _productsRepository { get; set; }
        public ProductsController()
        {
            _productsRepository = new ProductsRepository();    
        }

        [HttpPost]
        public IActionResult Post(Products p)
        {
            _productsRepository.Post(p);
            return NoContent();
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_productsRepository.Get());
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _productsRepository.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Products p, Guid id)
        {
            _productsRepository.Put(id, p);

            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_productsRepository.GetById(id));
        }
    }
}
