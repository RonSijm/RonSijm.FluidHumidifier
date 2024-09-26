// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerSubscriptionDefinitionVersionSubscriptionFactory(Action<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription>
{

    protected override Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription Create()
    {
        var subscriptionResult = CreateSubscription();
        factoryAction?.Invoke(subscriptionResult);

        return subscriptionResult;
    }

    private Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription CreateSubscription()
    {
        var subscriptionResult = new Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription();

        return subscriptionResult;
    }

} // End Of Class

public static class InnerSubscriptionDefinitionVersionSubscriptionFactoryExtensions
{
}
