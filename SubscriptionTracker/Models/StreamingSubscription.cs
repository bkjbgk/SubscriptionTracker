namespace SubscriptionTracker.Models;

public class StreamingSubscription : Subscription
{
    public int MonthsActive { get; set; } = 1;

    public StreamingSubscription() { }

    public StreamingSubscription(int id, string name, decimal price, int monthsActive) 
        : base(id, name, price)
    {
        MonthsActive = monthsActive;
    }

    public override decimal CalculateMonthlyCost() => Price;

    public override string CorrectDetails => $"Стрімінг {Name}: {Price} грн/міс";
}