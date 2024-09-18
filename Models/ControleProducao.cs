using System.ComponentModel.DataAnnotations;

namespace Pim2024_FazendaUrbana.Models
{
    public class ControleProducao
    {
        [Key]  
        public int ControleProdu_ID { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusao { get; set; }
        public string Status { get; set; }

        public void IniciarProducao() { }
        public void FinalizarProducao() { }
    }
}
