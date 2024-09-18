namespace Pim2024_FazendaUrbana.Models
{
    public class ItemVenda
    {
        public int ItemVenda_ID { get; set; }
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public float PrecoVenda { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }

        public void CalcularSubtotal() { }
    }
}
