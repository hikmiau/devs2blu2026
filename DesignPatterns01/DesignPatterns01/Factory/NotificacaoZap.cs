namespace DesignPatterns01.Factory;

public class NotificacaoZap : INotificacao
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando Zap: {mensagem}");
    }
}