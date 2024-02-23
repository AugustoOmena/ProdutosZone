namespace ProdutosZone.Models
{
    public class Produto
    {

        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Cover { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category Category { get; set; } = default!;

        public ICollection<ProdutoDevice> Devices { get; set; } = new List<ProdutoDevice>();
    }
}
