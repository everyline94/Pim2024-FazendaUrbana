using System.ComponentModel.DataAnnotations;

namespace Pim2024_FazendaUrbana.Models
{
    public class Usuario
    {
        [Key]  
        public int Usuario_ID { get; set; }

        [Required]  
        public string Login { get; set; }

        [Required] 
        public string Senha { get; set; }

        public void Autenticar() { }
        public void AtualizarSenha(string novaSenha) { }
    }
}
