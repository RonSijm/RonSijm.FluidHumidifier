// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerInfluxDBParameterGroupPercentOrAbsoluteLongFactory(Action<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong>
{

    protected override Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong Create()
    {
        var percentOrAbsoluteLongResult = CreatePercentOrAbsoluteLong();
        factoryAction?.Invoke(percentOrAbsoluteLongResult);

        return percentOrAbsoluteLongResult;
    }

    private Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong CreatePercentOrAbsoluteLong()
    {
        var percentOrAbsoluteLongResult = new Humidifier.Timestream.InfluxDBParameterGroupTypes.PercentOrAbsoluteLong();

        return percentOrAbsoluteLongResult;
    }

} // End Of Class

public static class InnerInfluxDBParameterGroupPercentOrAbsoluteLongFactoryExtensions
{
}
