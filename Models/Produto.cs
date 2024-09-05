namespace Pim2024_FazendaUrbana.Models
{
    public class Produto
    {
        public int Id { get; set; } // Identificador único
        public string? Nome { get; set; } // Nome do produto, agora anulável
        public string? Descricao { get; set; } // Descrição do produto, agora anulável
        public decimal Preco { get; set; } // Preço do produto
        public int Quantidade { get; set; } // Quantidade em estoque
    }
}
