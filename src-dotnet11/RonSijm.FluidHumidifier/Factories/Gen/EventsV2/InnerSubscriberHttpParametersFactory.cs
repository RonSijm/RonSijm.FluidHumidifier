// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberHttpParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.HttpParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.HttpParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.HttpParameters Create()
    {
        var httpParametersResult = CreateHttpParameters();
        factoryAction?.Invoke(httpParametersResult);

        return httpParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.HttpParameters CreateHttpParameters()
    {
        var httpParametersResult = new Humidifier.EventsV2.SubscriberTypes.HttpParameters();

        return httpParametersResult;
    }

} // End Of Class

public static class InnerSubscriberHttpParametersFactoryExtensions
{
}
