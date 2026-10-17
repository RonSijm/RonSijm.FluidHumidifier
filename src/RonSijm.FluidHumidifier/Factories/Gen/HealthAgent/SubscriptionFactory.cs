// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthAgent;

public class SubscriptionFactory(string resourceName = null, Action<Humidifier.HealthAgent.Subscription> factoryAction = null) : ResourceFactory<Humidifier.HealthAgent.Subscription>(resourceName)
{

    protected override Humidifier.HealthAgent.Subscription Create()
    {
        var subscriptionResult = CreateSubscription();
        factoryAction?.Invoke(subscriptionResult);

        return subscriptionResult;
    }

    private Humidifier.HealthAgent.Subscription CreateSubscription()
    {
        var subscriptionResult = new Humidifier.HealthAgent.Subscription
        {
            GivenName = InputResourceName,
        };

        return subscriptionResult;
    }

} // End Of Class

public static class SubscriptionFactoryExtensions
{
}
