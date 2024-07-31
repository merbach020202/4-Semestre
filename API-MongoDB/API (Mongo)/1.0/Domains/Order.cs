using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace minimalAPIMongo.Domains
{
    public class Order
    {
        // Define que esta propriedade é o Id do objeto
        [BsonId]
        // Define o nome do campo no MongoDb como "_id" e o tipo como "ObjectId"
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        public string? Status { get; set; }

        // Referência aos produtos do pedido
        [BsonElement("products")]
        public List<string>? ProductIds { get; set; }

        //Referência para que eu consiga cadastrar um pedido com os produtos
        [BsonElement("productId")]
        [JsonIgnore]
        public List<string>? ProductId { get; set; }

        //Referência para que quando eu liste os pedidos, venham os dados de cada produto(lista)

        public List<Product> Product { get; set; }

        // Referência ao cliente que está fazendo o pedido


        //Referência para que eu consiga cadastrar um pedido com o cliente

        [BsonElement("clientId")]
        [JsonIgnore]
        public string? ClientId { get; set; }

        //Referência para que quando eu liste os pedidos, venham os dados do cliente

        public Client? Client { get; set; }



        /// <summary>
        /// Ao ser instanciado um objeto da classe Order, o atributo ProductIds já virá com uma nova lista e, portanto, habilitado para adicionar mais produtos
        /// </summary>
        public Order()
        {
            ProductIds = new List<string>();
        }
    }
}

