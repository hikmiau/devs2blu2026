namespace DesignPatterns01.Factory;

public class NotificacaoFactory
{
    public static INotificacao CriarNotificacao(string tipo)
    {
        return tipo switch
        {
            "email" => new NotificacaoEmail(),
            "sms" => new NotificacaoSms(),
            "zap" => new NotificacaoZap(),
            _ => throw new ArgumentException("Tipo de notificação não suportado.")
        };
    }
}