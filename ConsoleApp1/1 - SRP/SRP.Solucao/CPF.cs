namespace Pitte.Pitte.SOLID.SRP.Solucao
{
    public record Cpf
    {
        public string Numero { get; set; }

        public bool Validar() => Numero.Length == 11;

    }
}