namespace Ipsen5_groep01_frontend.Services
{
public class NotificatieService
{
    public event Action<string, NotificationType> OnNotify;

    public void Notify(string message, NotificationType type = NotificationType.Info)

    {
        OnNotify?.Invoke(message, type);
    }
}

public enum NotificationType
{
    Info,
    Success,
    Warning,
    Error
}
}