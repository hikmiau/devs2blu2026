namespace DesignPatterns01.Factory;

public class NotificacaoFactory
{
    public static INotificacao CriarNotificacao(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "email":
                return new NotificacaoEmail();
            case "sms":
                return new NotificacaoSms();
            case "zap":
                return new NotificacaoZap();
            default:
                throw new ArgumentException("Tipo de notificação inválido");
        }
    }
}