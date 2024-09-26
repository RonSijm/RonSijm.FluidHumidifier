// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerClusterExecuteCommandLogConfigurationFactory(Action<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration>
{

    protected override Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration Create()
    {
        var executeCommandLogConfigurationResult = CreateExecuteCommandLogConfiguration();
        factoryAction?.Invoke(executeCommandLogConfigurationResult);

        return executeCommandLogConfigurationResult;
    }

    private Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration CreateExecuteCommandLogConfiguration()
    {
        var executeCommandLogConfigurationResult = new Humidifier.ECS.ClusterTypes.ExecuteCommandLogConfiguration();

        return executeCommandLogConfigurationResult;
    }

} // End Of Class

public static class InnerClusterExecuteCommandLogConfigurationFactoryExtensions
{
}
