using SubscriptionTracker.Models;
using SubscriptionTracker.Session;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Облік підписок (ЛР 3) ===");

var subscriptions = new List<Subscription>
{
    new StreamingSubscription(1, "Netflix", 299.00m, 6) { Category = "Стрімінг" },
    new MusicSubscription(2, "Spotify", 149.00m, true) { Category = "Музика" },
    new SoftwareSubscription(3, "GitHub Copilot", 380.00m, "Місячна ліцензія", "Автопоновлення") { Category = "ПЗ" }
};

Console.WriteLine($"Всього об'єктів у наборі: {subscriptions.Count}.\n");

var summary = new SubscriptionSummary(0, 0m);

foreach (var sub in subscriptions)
{
    Console.WriteLine(sub.ToString());

    if (sub is SoftwareSubscription soft && soft.Milestones.Count > 0)
    {
        Console.WriteLine($"  -> Деталі (індексатор [1]): {soft[1]}");
    }

    decimal monthlyCost = sub.CalculateMonthlyCost();
    summary += monthlyCost;

    Console.WriteLine($"  -> Витрати за місяць: {monthlyCost:F2} грн");
    Console.WriteLine();
}

Console.WriteLine("=== ПІДСУМОК ===");
Console.WriteLine($"Загальна кількість: {summary.TotalCount}");
Console.WriteLine($"Сумарні витрати за місяць: {summary.TotalMonthlyCost:F2} грн");