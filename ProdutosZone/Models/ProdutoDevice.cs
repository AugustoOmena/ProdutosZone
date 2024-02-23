namespace ProdutosZone.Models
{
    public class ProdutoDevice
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = default!;

        public int DeviceId { get; set; }
        public Device Device { get; set; } = default!;
    }
}
