using minimalAPIMongo.Domains;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace minimalAPIMongo.ViewModels
{
    public class OrderViewModel
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        public string? Status { get; set; }

        [BsonElement("products")]
        public List<string>? ProductIds { get; set; }

        [BsonElement("productId")]
        public List<string>? ProductId { get; set; }

        [BsonIgnore]
        [JsonIgnore]
        public List<Product> Product { get; set; }


        [BsonElement("clientId")]
        public string? ClientId { get; set; }

        [BsonIgnore]
        [JsonIgnore]
        public Client? Client { get; set; }



        /// <summary>
        /// Ao ser instanciado um objeto da classe Order, o atributo ProductIds já virá com uma nova lista e, portanto, habilitado para adicionar mais produtos
        /// </summary>
        public OrderViewModel()
        {
            ProductIds = new List<string>();
        }
    }
}
