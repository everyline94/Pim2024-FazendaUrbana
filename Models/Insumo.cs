using System.ComponentModel.DataAnnotations;

namespace Pim2024_FazendaUrbana.Models
{
    public class Insumo
    {
        [Key] 
        public int Insumo_ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }

        public void AdicionarInsumo() { }
        public void AtualizarEstoque(int quantidade) { }
    }
}
