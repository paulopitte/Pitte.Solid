namespace Pitte.SOLID.DIP.Solucao;
public class CPFServices : ICPFServices
{
    public bool IsValid(string cpf) => cpf.Length == 11;

}
