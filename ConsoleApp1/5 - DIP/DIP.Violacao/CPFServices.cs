namespace Pitte.SOLID.DIP.Violacao;
    public static class CPFServices
    {
        public static bool IsValid(string cpf) =>        
             cpf.Length == 11;
        
    }
