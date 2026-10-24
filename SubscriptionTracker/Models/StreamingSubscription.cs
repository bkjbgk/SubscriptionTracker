namespace SubscriptionTracker.Models;

public class StreamingSubscription : Subscription
{
    public string Quality { get; set; } = "HD";

    public override string GetDetails()
    {
        return $"[Стрімінг] {Name} | Якість: {Quality} | Ціна: {Price} грн | Днів: {DaysLeft}";
    }
}