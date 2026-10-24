namespace SubscriptionTracker.Models;

public class MusicSubscription : Subscription
{
    public bool IsFamilyPlan { get; set; }

    public override string GetDetails()
    {
        string plan = IsFamilyPlan ? "Сімейний" : "Індивідуальний";
        return $"[Музика] {Name} | Тариф: {plan} | Ціна: {Price} грн | Днів: {DaysLeft}";
    }
}