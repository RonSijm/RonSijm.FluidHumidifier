// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAgentSpaceIamAuthConfigurationFactory(Action<Humidifier.DevOpsAgent.AgentSpaceTypes.IamAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AgentSpaceTypes.IamAuthConfiguration>
{

    protected override Humidifier.DevOpsAgent.AgentSpaceTypes.IamAuthConfiguration Create()
    {
        var iamAuthConfigurationResult = CreateIamAuthConfiguration();
        factoryAction?.Invoke(iamAuthConfigurationResult);

        return iamAuthConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AgentSpaceTypes.IamAuthConfiguration CreateIamAuthConfiguration()
    {
        var iamAuthConfigurationResult = new Humidifier.DevOpsAgent.AgentSpaceTypes.IamAuthConfiguration();

        return iamAuthConfigurationResult;
    }

} // End Of Class

public static class InnerAgentSpaceIamAuthConfigurationFactoryExtensions
{
}
