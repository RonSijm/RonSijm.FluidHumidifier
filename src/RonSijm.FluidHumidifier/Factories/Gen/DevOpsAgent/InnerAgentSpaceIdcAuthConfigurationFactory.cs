// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAgentSpaceIdcAuthConfigurationFactory(Action<Humidifier.DevOpsAgent.AgentSpaceTypes.IdcAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AgentSpaceTypes.IdcAuthConfiguration>
{

    protected override Humidifier.DevOpsAgent.AgentSpaceTypes.IdcAuthConfiguration Create()
    {
        var idcAuthConfigurationResult = CreateIdcAuthConfiguration();
        factoryAction?.Invoke(idcAuthConfigurationResult);

        return idcAuthConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AgentSpaceTypes.IdcAuthConfiguration CreateIdcAuthConfiguration()
    {
        var idcAuthConfigurationResult = new Humidifier.DevOpsAgent.AgentSpaceTypes.IdcAuthConfiguration();

        return idcAuthConfigurationResult;
    }

} // End Of Class

public static class InnerAgentSpaceIdcAuthConfigurationFactoryExtensions
{
}
