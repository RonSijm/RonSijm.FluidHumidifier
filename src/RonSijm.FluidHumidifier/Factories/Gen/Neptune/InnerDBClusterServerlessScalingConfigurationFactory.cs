// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class InnerDBClusterServerlessScalingConfigurationFactory(Action<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration>
{

    protected override Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration Create()
    {
        var serverlessScalingConfigurationResult = CreateServerlessScalingConfiguration();
        factoryAction?.Invoke(serverlessScalingConfigurationResult);

        return serverlessScalingConfigurationResult;
    }

    private Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration CreateServerlessScalingConfiguration()
    {
        var serverlessScalingConfigurationResult = new Humidifier.Neptune.DBClusterTypes.ServerlessScalingConfiguration();

        return serverlessScalingConfigurationResult;
    }

} // End Of Class

public static class InnerDBClusterServerlessScalingConfigurationFactoryExtensions
{
}
