// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionSparkGlueArgsFactory(Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs>
{

    protected override Humidifier.DataZone.ConnectionTypes.SparkGlueArgs Create()
    {
        var sparkGlueArgsResult = CreateSparkGlueArgs();
        factoryAction?.Invoke(sparkGlueArgsResult);

        return sparkGlueArgsResult;
    }

    private Humidifier.DataZone.ConnectionTypes.SparkGlueArgs CreateSparkGlueArgs()
    {
        var sparkGlueArgsResult = new Humidifier.DataZone.ConnectionTypes.SparkGlueArgs();

        return sparkGlueArgsResult;
    }

} // End Of Class

public static class InnerConnectionSparkGlueArgsFactoryExtensions
{
}
