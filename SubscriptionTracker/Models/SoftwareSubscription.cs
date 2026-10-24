namespace SubscriptionTracker.Models;

public class SoftwareSubscription : Subscription
{
    public List<string> Milestones { get; set; } = new();

    // Індексатор за вимогами лабораторної
    public string this[int number] => Milestones[number - 1];

    public SoftwareSubscription() { }

    public SoftwareSubscription(int id, string name, decimal price, params string[] milestones) 
        : base(id, name, price)
    {
        Milestones.AddRange(milestones);
    }

    public override decimal CalculateMonthlyCost() => Price;

    public override string CorrectDetails => "ПЗ / Разова покупка";
    public override string Prompt => "Сума витрати";
}