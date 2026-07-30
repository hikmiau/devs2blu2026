namespace Exercicios;

public class NotificadorWhatsApp : INotificador
{
    public void EnviarMensagem(string destinatario, string mensagem)
    {
        Console.WriteLine($"[WHATSAPP] Enviando para {destinatario}: {mensagem}");
    }
}
