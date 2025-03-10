namespace Pitte.Pitte.SOLID.SRP.Solucao;
public record Email
{
    public string Endereco { get; set; }

    public bool Validar() => Endereco.Contains("@");

}
