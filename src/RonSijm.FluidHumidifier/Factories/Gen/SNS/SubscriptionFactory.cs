// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SNS;

public class SubscriptionFactory(string resourceName = null, Action<Humidifier.SNS.Subscription> factoryAction = null) : ResourceFactory<Humidifier.SNS.Subscription>(resourceName)
{

    protected override Humidifier.SNS.Subscription Create()
    {
        var subscriptionResult = CreateSubscription();
        factoryAction?.Invoke(subscriptionResult);

        return subscriptionResult;
    }

    private Humidifier.SNS.Subscription CreateSubscription()
    {
        var subscriptionResult = new Humidifier.SNS.Subscription
        {
            GivenName = InputResourceName,
        };

        return subscriptionResult;
    }

} // End Of Class

public static class SubscriptionFactoryExtensions
{
}
