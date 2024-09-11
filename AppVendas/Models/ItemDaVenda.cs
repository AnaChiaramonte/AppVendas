namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }
        public Guid VendaId { get; set; }
        public Guid? Venda { get; set; }

        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public double QuantidadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }
    }
}
