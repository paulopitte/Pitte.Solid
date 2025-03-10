namespace Pitte.SOLID.DIP.Violacao;
public record Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public DateTime DataCadastro { get; set; }

    public bool IsValid() =>
          EmailServices.IsValid(Email)
            && CPFServices.IsValid(CPF);

}
