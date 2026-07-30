namespace Exercicios;

public class NotificadorEmail : INotificador
{
    public void EnviarMensagem(string destinatario, string mensagem)
    {
        Console.WriteLine($"[EMAIL] Enviando para {destinatario}: {mensagem}");
    }
}
