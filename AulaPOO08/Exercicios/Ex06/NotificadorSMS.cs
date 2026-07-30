namespace Exercicios;

public class NotificadorSMS : INotificador
{
    public void EnviarMensagem(string destinatario, string mensagem)
    {
        Console.WriteLine($"[SMS] Enviando para {destinatario}: {mensagem}");
    }
}
