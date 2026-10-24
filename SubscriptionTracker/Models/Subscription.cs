namespace SubscriptionTracker.Models;

public abstract class Subscription
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int DaysLeft { get; set; }

    public virtual string GetDetails()
    {
        return $"Назва: {Name}, Ціна: {Price} грн, Залишилось днів: {DaysLeft}";
    }
}