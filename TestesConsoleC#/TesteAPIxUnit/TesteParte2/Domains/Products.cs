using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteParte2.Domains
{
    [Table("Product")]
    public class Products
    {
        [Key]
        public Guid IdProduct { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do produto obrigatório")]
        public string? Name { get; set; }

        [Column(TypeName = "DECIMAL")]
        [Required(ErrorMessage = "Preço do produto obrigatório")]
        public decimal? Price { get; set; }
    }
}
