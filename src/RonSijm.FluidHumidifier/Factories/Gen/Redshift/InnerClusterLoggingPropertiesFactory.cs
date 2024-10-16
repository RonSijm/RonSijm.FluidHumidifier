// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class InnerClusterLoggingPropertiesFactory(Action<Humidifier.Redshift.ClusterTypes.LoggingProperties> factoryAction = null) : SubResourceFactory<Humidifier.Redshift.ClusterTypes.LoggingProperties>
{

    protected override Humidifier.Redshift.ClusterTypes.LoggingProperties Create()
    {
        var loggingPropertiesResult = CreateLoggingProperties();
        factoryAction?.Invoke(loggingPropertiesResult);

        return loggingPropertiesResult;
    }

    private Humidifier.Redshift.ClusterTypes.LoggingProperties CreateLoggingProperties()
    {
        var loggingPropertiesResult = new Humidifier.Redshift.ClusterTypes.LoggingProperties();

        return loggingPropertiesResult;
    }

} // End Of Class

public static class InnerClusterLoggingPropertiesFactoryExtensions
{
}
