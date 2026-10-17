// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberKinesisParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.KinesisParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.KinesisParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.KinesisParameters Create()
    {
        var kinesisParametersResult = CreateKinesisParameters();
        factoryAction?.Invoke(kinesisParametersResult);

        return kinesisParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.KinesisParameters CreateKinesisParameters()
    {
        var kinesisParametersResult = new Humidifier.EventsV2.SubscriberTypes.KinesisParameters();

        return kinesisParametersResult;
    }

} // End Of Class

public static class InnerSubscriberKinesisParametersFactoryExtensions
{
}
