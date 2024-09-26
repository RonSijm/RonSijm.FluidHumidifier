// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBClusterServerlessV2ScalingConfigurationFactory(Action<Humidifier.RDS.DBClusterTypes.ServerlessV2ScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBClusterTypes.ServerlessV2ScalingConfiguration>
{

    protected override Humidifier.RDS.DBClusterTypes.ServerlessV2ScalingConfiguration Create()
    {
        var serverlessV2ScalingConfigurationResult = CreateServerlessV2ScalingConfiguration();
        factoryAction?.Invoke(serverlessV2ScalingConfigurationResult);

        return serverlessV2ScalingConfigurationResult;
    }

    private Humidifier.RDS.DBClusterTypes.ServerlessV2ScalingConfiguration CreateServerlessV2ScalingConfiguration()
    {
        var serverlessV2ScalingConfigurationResult = new Humidifier.RDS.DBClusterTypes.ServerlessV2ScalingConfiguration();

        return serverlessV2ScalingConfigurationResult;
    }

} // End Of Class

public static class InnerDBClusterServerlessV2ScalingConfigurationFactoryExtensions
{
}
