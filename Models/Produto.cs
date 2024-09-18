namespace Pim2024_FazendaUrbana.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; } 
        public Funcionario? Fornecedor { get; set; } 

        public void AtualizarEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void DefinirPreco(decimal novoPreco)
        {
            Preco = novoPreco;
        }
    }
}
