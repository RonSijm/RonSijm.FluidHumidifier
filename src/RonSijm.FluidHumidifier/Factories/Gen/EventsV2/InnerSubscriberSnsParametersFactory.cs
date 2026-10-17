// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberSnsParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.SnsParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.SnsParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.SnsParameters Create()
    {
        var snsParametersResult = CreateSnsParameters();
        factoryAction?.Invoke(snsParametersResult);

        return snsParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.SnsParameters CreateSnsParameters()
    {
        var snsParametersResult = new Humidifier.EventsV2.SubscriberTypes.SnsParameters();

        return snsParametersResult;
    }

} // End Of Class

public static class InnerSubscriberSnsParametersFactoryExtensions
{
}
