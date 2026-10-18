// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberSqsParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.SqsParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.SqsParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.SqsParameters Create()
    {
        var sqsParametersResult = CreateSqsParameters();
        factoryAction?.Invoke(sqsParametersResult);

        return sqsParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.SqsParameters CreateSqsParameters()
    {
        var sqsParametersResult = new Humidifier.EventsV2.SubscriberTypes.SqsParameters();

        return sqsParametersResult;
    }

} // End Of Class

public static class InnerSubscriberSqsParametersFactoryExtensions
{
}
