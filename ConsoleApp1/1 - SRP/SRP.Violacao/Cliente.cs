using System.Net.Mail;
namespace Pitte.Pitte.SOLID.SRP.Violacao;
public record class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public DateTime DataCadastro { get; set; }

    public string AdicionarCliente()
    {
        if (!Email.Contains("@"))
            return "Cliente com e-mail inválido";

        if (CPF.Length != 11)
            return "Cliente com CPF inválido";


        /// PERSISTENCIA EM ALGUM TIPO DE REPOSITORIO

        var mail = new MailMessage("empresa@empresa.com", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Bem Vindo.";
        mail.Body = "Parabéns! Você está cadastrado.";
        client.Send(mail);

        return "Cliente cadastrado com sucesso!";
    }
}
