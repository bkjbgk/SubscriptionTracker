using System.Runtime.InteropServices;
using SubscriptionTracker.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Облік підписок (ЛР 2) ===");

// Створюємо список підписок (поліморфізм)
List<Subscription> subscriptions = new List<Subscription>
{
    new StreamingSubscription { Name = "Netflix", Price = 299.00m, DaysLeft = 12, Quality = "4K" },
    new MusicSubscription { Name = "Spotify", Price = 149.00m, DaysLeft = 5, IsFamilyPlan = true },
    new SoftwareSubscription { Name = "GitHub Copilot", Price = 380.00m, DaysLeft = 20, IsAnnualBilling = false }
};

// Виводимо інформацію про кожну підписку
foreach (var sub in subscriptions)
{
    Console.WriteLine(sub.GetDetails());
}