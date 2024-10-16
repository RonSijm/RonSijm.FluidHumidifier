// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBClusterScalingConfigurationFactory(Action<Humidifier.RDS.DBClusterTypes.ScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBClusterTypes.ScalingConfiguration>
{

    protected override Humidifier.RDS.DBClusterTypes.ScalingConfiguration Create()
    {
        var scalingConfigurationResult = CreateScalingConfiguration();
        factoryAction?.Invoke(scalingConfigurationResult);

        return scalingConfigurationResult;
    }

    private Humidifier.RDS.DBClusterTypes.ScalingConfiguration CreateScalingConfiguration()
    {
        var scalingConfigurationResult = new Humidifier.RDS.DBClusterTypes.ScalingConfiguration();

        return scalingConfigurationResult;
    }

} // End Of Class

public static class InnerDBClusterScalingConfigurationFactoryExtensions
{
}
