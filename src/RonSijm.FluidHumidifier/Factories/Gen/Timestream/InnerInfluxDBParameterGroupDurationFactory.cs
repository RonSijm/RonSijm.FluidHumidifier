// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBParameterGroupDurationFactory(Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration>
{

    protected override Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration Create()
    {
        var durationResult = CreateDuration();
        factoryAction?.Invoke(durationResult);

        return durationResult;
    }

    private Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration CreateDuration()
    {
        var durationResult = new Humidifier.Timestream.InfluxDBParameterGroupTypes.Duration();

        return durationResult;
    }

} // End Of Class

public static class InnerInfluxDBParameterGroupDurationFactoryExtensions
{
}
