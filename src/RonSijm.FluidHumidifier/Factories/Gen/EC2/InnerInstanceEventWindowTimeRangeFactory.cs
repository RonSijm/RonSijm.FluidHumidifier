// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceEventWindowTimeRangeFactory(Action<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceEventWindowTypes.TimeRange>
{

    protected override Humidifier.EC2.InstanceEventWindowTypes.TimeRange Create()
    {
        var timeRangeResult = CreateTimeRange();
        factoryAction?.Invoke(timeRangeResult);

        return timeRangeResult;
    }

    private Humidifier.EC2.InstanceEventWindowTypes.TimeRange CreateTimeRange()
    {
        var timeRangeResult = new Humidifier.EC2.InstanceEventWindowTypes.TimeRange();

        return timeRangeResult;
    }

} // End Of Class

public static class InnerInstanceEventWindowTimeRangeFactoryExtensions
{
}
