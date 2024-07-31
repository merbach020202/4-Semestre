using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace minimalAPIMongo.Domains
{
    public class Client
    {
        //id, userId, cpf, phone, adress, atributos adicionais
        [BsonId]

        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]

        public string? Id { get; set; }

        //[BsonId]

        [BsonElement("userId"), BsonRepresentation(BsonType.ObjectId)]

        public string? UserId { get; set; }

        [BsonElement("cpf")]

        public string? Cpf { get; set; }

        [BsonElement("phone")]

        public string? Phone { get; set; }

        [BsonElement("adress")]

        public string? Adress { get; set; }

        //[BsonElement("atributosAdicionais")]

        //public string AtributosAdicionais { get; set; }

        public Dictionary<string, string> AdditionalAttributtes { get; set; }

        /// <summary>
        /// Ao ser instanciado um objeto da classe Client, o atributo AdditionalAttributes já virá com um novo dicionário e, portanto, habilitado para adicionar mais atributos
        /// </summary>

        public Client() 
        { 
            AdditionalAttributtes = new Dictionary<string, string>();
        }

        public static implicit operator Client(List<Client> v)
        {
            throw new NotImplementedException();
        }
    }
}
