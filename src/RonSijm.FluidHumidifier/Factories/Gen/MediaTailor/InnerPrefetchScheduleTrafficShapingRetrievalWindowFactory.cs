// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPrefetchScheduleTrafficShapingRetrievalWindowFactory(Action<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow>
{

    protected override Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow Create()
    {
        var trafficShapingRetrievalWindowResult = CreateTrafficShapingRetrievalWindow();
        factoryAction?.Invoke(trafficShapingRetrievalWindowResult);

        return trafficShapingRetrievalWindowResult;
    }

    private Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow CreateTrafficShapingRetrievalWindow()
    {
        var trafficShapingRetrievalWindowResult = new Humidifier.MediaTailor.PrefetchScheduleTypes.TrafficShapingRetrievalWindow();

        return trafficShapingRetrievalWindowResult;
    }

} // End Of Class

public static class InnerPrefetchScheduleTrafficShapingRetrievalWindowFactoryExtensions
{
}
