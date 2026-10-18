// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class InnerAnomalySubscriptionSubscriberFactory(Action<Humidifier.CE.AnomalySubscriptionTypes.Subscriber> factoryAction = null) : SubResourceFactory<Humidifier.CE.AnomalySubscriptionTypes.Subscriber>
{

    protected override Humidifier.CE.AnomalySubscriptionTypes.Subscriber Create()
    {
        var subscriberResult = CreateSubscriber();
        factoryAction?.Invoke(subscriberResult);

        return subscriberResult;
    }

    private Humidifier.CE.AnomalySubscriptionTypes.Subscriber CreateSubscriber()
    {
        var subscriberResult = new Humidifier.CE.AnomalySubscriptionTypes.Subscriber();

        return subscriberResult;
    }

} // End Of Class

public static class InnerAnomalySubscriptionSubscriberFactoryExtensions
{
}
