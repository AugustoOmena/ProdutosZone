namespace ProdutosZone.Models
{
    public class Category : BaseEntity
    {
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
