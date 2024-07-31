using Microsoft.AspNetCore.Mvc;
using minimalAPIMongo.Domains;
using minimalAPIMongo.Services;
using MongoDB.Driver;

namespace minimalAPIMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class OrderController : Controller
    {
        private readonly IMongoCollection<Order> _order;
        private readonly IMongoCollection<Client> _client;
        private readonly IMongoCollection<Product> _product;

        public OrderController(MongoDbService mongoDbService)
        {
            _order = mongoDbService.GetDatabase?.GetCollection<Order>("order");
            _client = mongoDbService.GetDatabase?.GetCollection<Client>("client");
            _product = mongoDbService.GetDatabase?.GetCollection<Product>("product");
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> Get()
        {
            try
            {
                // Lista todos os pedidos da collection Order
                var orders = await _order.Find(FilterDefinition<Order>.Empty).ToListAsync();

                // Percorre todos os itens da lista
                foreach (var order in orders)
                {
                    //Verifica se existe uma lista de produtos para cada pedido
                    if (order.ProductId != null) 
                    {
                        //dentro da collection "Product" faz um filtro("separa" os produtos que estão dentro do pedido)
                        //selecione os ids dos produtos dentro da collection cujo id est[a presente na lista "order.ProductId"
                        var filter = Builders<Product>.Filter.In(p => p.Id, order.ProductId);

                        //busca os produtos correspondentes ao pedido e adiciona
                        //Tras as informações dos produtos
                        order.Products = await _product.Find(filter).ToListAsync();
                    }

                    if (order.ClientId != null)
                    {
                        order.Client = await _client.Find(x => x.Id == order.ClientId).FirstOrDefaultAsync();
                    }
                }

                return Ok(orders);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create(OrderViewModel orderViewModel)
        {
            try
            {
                Order order = new Order();
                order.Id = orderViewModel.Id;
                order.Date = orderViewModel.Date;
                order.Status = orderViewModel.Status;
                order.ProductId = (List<string>?)orderViewModel.ProductId;
                order.ClientId = (string?)orderViewModel.ClientId;

                //var client = await _client.Find(x => x.Id == order.ClientId).FirstOrDefaultAsync();

                //if (client == null)
                //{
                //    return NotFound();
                //}

                //order.Client = client;

                await _order.InsertOneAsync(order);

                return StatusCode(201,order);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
