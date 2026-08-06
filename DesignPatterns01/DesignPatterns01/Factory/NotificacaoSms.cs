namespace DesignPatterns01.Factory;

public class NotificacaoSms : INotificacao
{
    public void Enviar(string mensagem) => 
        Console.WriteLine("Enviando notificação por SMS.");
}