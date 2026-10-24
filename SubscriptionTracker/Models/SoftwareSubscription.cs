namespace SubscriptionTracker.Models;

public class SoftwareSubscription : Subscription
{
    public bool IsAnnualBilling { get; set; }

    public override string GetDetails()
    {
        string billing = IsAnnualBilling ? "Річна" : "Місячна";
        return $"[ПЗ] {Name} | Оплата: {billing} | Ціна: {Price} грн | Днів: {DaysLeft}";
    }
}