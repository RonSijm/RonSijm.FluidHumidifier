// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQueryMultiMeasureMappingsFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings>
{

    protected override Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings Create()
    {
        var multiMeasureMappingsResult = CreateMultiMeasureMappings();
        factoryAction?.Invoke(multiMeasureMappingsResult);

        return multiMeasureMappingsResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings CreateMultiMeasureMappings()
    {
        var multiMeasureMappingsResult = new Humidifier.Timestream.ScheduledQueryTypes.MultiMeasureMappings();

        return multiMeasureMappingsResult;
    }

} // End Of Class

public static class InnerScheduledQueryMultiMeasureMappingsFactoryExtensions
{
}
