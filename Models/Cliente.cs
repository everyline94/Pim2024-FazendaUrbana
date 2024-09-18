using Pim2024_FazendaUrbana.Models;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? RG { get; set; }
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public Usuario? Usuario { get; set; }
}
