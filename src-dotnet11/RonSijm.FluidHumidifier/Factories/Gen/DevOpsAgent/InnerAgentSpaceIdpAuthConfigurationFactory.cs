// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAgentSpaceIdpAuthConfigurationFactory(Action<Humidifier.DevOpsAgent.AgentSpaceTypes.IdpAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AgentSpaceTypes.IdpAuthConfiguration>
{

    protected override Humidifier.DevOpsAgent.AgentSpaceTypes.IdpAuthConfiguration Create()
    {
        var idpAuthConfigurationResult = CreateIdpAuthConfiguration();
        factoryAction?.Invoke(idpAuthConfigurationResult);

        return idpAuthConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AgentSpaceTypes.IdpAuthConfiguration CreateIdpAuthConfiguration()
    {
        var idpAuthConfigurationResult = new Humidifier.DevOpsAgent.AgentSpaceTypes.IdpAuthConfiguration();

        return idpAuthConfigurationResult;
    }

} // End Of Class

public static class InnerAgentSpaceIdpAuthConfigurationFactoryExtensions
{
}
