namespace SubscriptionTracker.Session;

/// <summary>Підсумок: загальна кількість і сумарні витрати за місяць.</summary>
public record SubscriptionSummary(int TotalCount, decimal TotalMonthlyCost)
{
    public static SubscriptionSummary operator +(SubscriptionSummary s, decimal monthlyCost) =>
        new(s.TotalCount + 1, s.TotalMonthlyCost + monthlyCost);
}