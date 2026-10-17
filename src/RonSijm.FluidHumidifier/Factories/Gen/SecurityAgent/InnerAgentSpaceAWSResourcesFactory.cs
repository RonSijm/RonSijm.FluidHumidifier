// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerAgentSpaceAWSResourcesFactory(Action<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources>
{

    protected override Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources Create()
    {
        var aWSResourcesResult = CreateAWSResources();
        factoryAction?.Invoke(aWSResourcesResult);

        return aWSResourcesResult;
    }

    private Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources CreateAWSResources()
    {
        var aWSResourcesResult = new Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources();

        return aWSResourcesResult;
    }

} // End Of Class

public static class InnerAgentSpaceAWSResourcesFactoryExtensions
{
}
