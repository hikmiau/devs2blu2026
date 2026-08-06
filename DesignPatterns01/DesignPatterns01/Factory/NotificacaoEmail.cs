namespace DesignPatterns01.Factory;

public class NotificacaoEmail :  INotificacao
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando Email: {mensagem}");
    }
}