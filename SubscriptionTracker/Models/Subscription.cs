namespace SubscriptionTracker.Models;

/// <summary>Спільна основа всіх підписок.</summary>
public abstract class Subscription
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = "Загальна";

    protected Subscription() { }

    protected Subscription(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    /// <summary>Спільна дія: обчислює витрати за місяць.</summary>
    public abstract decimal CalculateMonthlyCost();

    /// <summary>Правильна відповідь / опис для користувача.</summary>
    public abstract string CorrectDetails { get; }

    /// <summary>Підказка для введення.</summary>
    public virtual string Prompt => "Введіть дані";

    public override string ToString() => $"#{Id} [{Category}] {Name} — Ціна: {Price} грн";
}