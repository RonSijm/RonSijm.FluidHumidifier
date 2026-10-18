// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerSubscriptionDefinitionSubscriptionFactory(Action<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription>
{

    protected override Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription Create()
    {
        var subscriptionResult = CreateSubscription();
        factoryAction?.Invoke(subscriptionResult);

        return subscriptionResult;
    }

    private Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription CreateSubscription()
    {
        var subscriptionResult = new Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription();

        return subscriptionResult;
    }

} // End Of Class

public static class InnerSubscriptionDefinitionSubscriptionFactoryExtensions
{
}
