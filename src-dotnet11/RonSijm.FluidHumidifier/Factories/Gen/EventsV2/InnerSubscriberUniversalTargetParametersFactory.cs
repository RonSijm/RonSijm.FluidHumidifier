// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberUniversalTargetParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters Create()
    {
        var universalTargetParametersResult = CreateUniversalTargetParameters();
        factoryAction?.Invoke(universalTargetParametersResult);

        return universalTargetParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters CreateUniversalTargetParameters()
    {
        var universalTargetParametersResult = new Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters();

        return universalTargetParametersResult;
    }

} // End Of Class

public static class InnerSubscriberUniversalTargetParametersFactoryExtensions
{
}
