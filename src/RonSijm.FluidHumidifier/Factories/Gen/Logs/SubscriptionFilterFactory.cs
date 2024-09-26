// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class SubscriptionFilterFactory(string resourceName = null, Action<Humidifier.Logs.SubscriptionFilter> factoryAction = null) : ResourceFactory<Humidifier.Logs.SubscriptionFilter>(resourceName)
{

    protected override Humidifier.Logs.SubscriptionFilter Create()
    {
        var subscriptionFilterResult = CreateSubscriptionFilter();
        factoryAction?.Invoke(subscriptionFilterResult);

        return subscriptionFilterResult;
    }

    private Humidifier.Logs.SubscriptionFilter CreateSubscriptionFilter()
    {
        var subscriptionFilterResult = new Humidifier.Logs.SubscriptionFilter
        {
            GivenName = InputResourceName,
        };

        return subscriptionFilterResult;
    }

} // End Of Class

public static class SubscriptionFilterFactoryExtensions
{
}
