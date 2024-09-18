using System.ComponentModel.DataAnnotations;

namespace Pim2024_FazendaUrbana.Models
{
    public class Venda
    {
        [Key] 
        public int Venda_ID { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public float ValorTotal { get; set; }
        
        public List<ItemVenda> ItensVenda { get; set; }

        public void RegistrarVenda() { }
        public void CalcularTotal() { }
    }
}
