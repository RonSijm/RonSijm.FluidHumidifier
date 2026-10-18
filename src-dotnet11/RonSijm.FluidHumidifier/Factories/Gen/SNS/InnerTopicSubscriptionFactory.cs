// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SNS;

public class InnerTopicSubscriptionFactory(Action<Humidifier.SNS.TopicTypes.Subscription> factoryAction = null) : SubResourceFactory<Humidifier.SNS.TopicTypes.Subscription>
{

    protected override Humidifier.SNS.TopicTypes.Subscription Create()
    {
        var subscriptionResult = CreateSubscription();
        factoryAction?.Invoke(subscriptionResult);

        return subscriptionResult;
    }

    private Humidifier.SNS.TopicTypes.Subscription CreateSubscription()
    {
        var subscriptionResult = new Humidifier.SNS.TopicTypes.Subscription();

        return subscriptionResult;
    }

} // End Of Class

public static class InnerTopicSubscriptionFactoryExtensions
{
}
