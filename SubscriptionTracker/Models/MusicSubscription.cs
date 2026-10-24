namespace SubscriptionTracker.Models;

public class MusicSubscription : Subscription
{
    public bool AutoRenew { get; set; } = true;

    public MusicSubscription() { }

    public MusicSubscription(int id, string name, decimal price, bool autoRenew) 
        : base(id, name, price)
    {
        AutoRenew = autoRenew;
    }

    public override decimal CalculateMonthlyCost() => Price / 12;

    public override string CorrectDetails => $"Музика {Name}: {Price} грн/рік (Автопродовження: {AutoRenew})";
    public override string Prompt => "Введіть рік";
}