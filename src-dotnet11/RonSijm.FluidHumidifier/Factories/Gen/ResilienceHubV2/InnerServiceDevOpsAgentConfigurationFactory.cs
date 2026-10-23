// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceDevOpsAgentConfigurationFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.DevOpsAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.DevOpsAgentConfiguration>
{

    protected override Humidifier.ResilienceHubV2.ServiceTypes.DevOpsAgentConfiguration Create()
    {
        var devOpsAgentConfigurationResult = CreateDevOpsAgentConfiguration();
        factoryAction?.Invoke(devOpsAgentConfigurationResult);

        return devOpsAgentConfigurationResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.DevOpsAgentConfiguration CreateDevOpsAgentConfiguration()
    {
        var devOpsAgentConfigurationResult = new Humidifier.ResilienceHubV2.ServiceTypes.DevOpsAgentConfiguration();

        return devOpsAgentConfigurationResult;
    }

} // End Of Class

public static class InnerServiceDevOpsAgentConfigurationFactoryExtensions
{
}
