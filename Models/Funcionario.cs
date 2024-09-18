using System.ComponentModel.DataAnnotations;

namespace Pim2024_FazendaUrbana.Models
{
    public class Funcionario
    {
        [Key] 
        public int Fun_ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public bool Genero { get; set; }
        public Usuario Usuario { get; set; }
        public List<Produto>? Produtos { get; set; }
        public List<Venda>? Pedidos { get; set; }
        public void GerenciarFuncionario() { }
        public void RegistrarVenda(Venda venda) { }
    }
}
