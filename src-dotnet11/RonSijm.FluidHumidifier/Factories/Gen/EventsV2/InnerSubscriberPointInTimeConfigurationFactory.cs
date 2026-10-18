// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberPointInTimeConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration Create()
    {
        var pointInTimeConfigurationResult = CreatePointInTimeConfiguration();
        factoryAction?.Invoke(pointInTimeConfigurationResult);

        return pointInTimeConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration CreatePointInTimeConfiguration()
    {
        var pointInTimeConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration();

        return pointInTimeConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberPointInTimeConfigurationFactoryExtensions
{
}
