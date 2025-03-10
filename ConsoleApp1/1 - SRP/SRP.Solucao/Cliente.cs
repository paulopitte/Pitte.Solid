namespace Pitte.Pitte.SOLID.SRP.Solucao;
public record Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public Email Email { get; set; }
    public Cpf Cpf { get; set; }
    public DateTime DataCadastro { get; set; }

    public bool Validar() => Email.Validar() && Cpf.Validar();

}
