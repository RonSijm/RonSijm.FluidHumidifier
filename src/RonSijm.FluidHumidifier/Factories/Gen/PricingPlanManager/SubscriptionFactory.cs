// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PricingPlanManager;

public class SubscriptionFactory(string resourceName = null, Action<Humidifier.PricingPlanManager.Subscription> factoryAction = null) : ResourceFactory<Humidifier.PricingPlanManager.Subscription>(resourceName)
{

    protected override Humidifier.PricingPlanManager.Subscription Create()
    {
        var subscriptionResult = CreateSubscription();
        factoryAction?.Invoke(subscriptionResult);

        return subscriptionResult;
    }

    private Humidifier.PricingPlanManager.Subscription CreateSubscription()
    {
        var subscriptionResult = new Humidifier.PricingPlanManager.Subscription
        {
            GivenName = InputResourceName,
        };

        return subscriptionResult;
    }

} // End Of Class

public static class SubscriptionFactoryExtensions
{
}
