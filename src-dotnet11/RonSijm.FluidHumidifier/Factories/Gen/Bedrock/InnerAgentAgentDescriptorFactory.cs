// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentAgentDescriptorFactory(Action<Humidifier.Bedrock.AgentTypes.AgentDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.AgentDescriptor>
{

    protected override Humidifier.Bedrock.AgentTypes.AgentDescriptor Create()
    {
        var agentDescriptorResult = CreateAgentDescriptor();
        factoryAction?.Invoke(agentDescriptorResult);

        return agentDescriptorResult;
    }

    private Humidifier.Bedrock.AgentTypes.AgentDescriptor CreateAgentDescriptor()
    {
        var agentDescriptorResult = new Humidifier.Bedrock.AgentTypes.AgentDescriptor();

        return agentDescriptorResult;
    }

} // End Of Class

public static class InnerAgentAgentDescriptorFactoryExtensions
{
}
