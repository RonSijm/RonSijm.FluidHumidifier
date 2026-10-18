// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPrefetchScheduleTrafficShapingTpsConfigurationFactory(Action<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration>
{

    protected override Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration Create()
    {
        var trafficShapingTpsConfigurationResult = CreateTrafficShapingTpsConfiguration();
        factoryAction?.Invoke(trafficShapingTpsConfigurationResult);

        return trafficShapingTpsConfigurationResult;
    }

    private Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration CreateTrafficShapingTpsConfiguration()
    {
        var trafficShapingTpsConfigurationResult = new Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingTpsConfiguration();

        return trafficShapingTpsConfigurationResult;
    }

} // End Of Class

public static class InnerPrefetchScheduleTrafficShapingTpsConfigurationFactoryExtensions
{
}
