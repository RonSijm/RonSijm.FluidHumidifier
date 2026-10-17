// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordMcpToolsDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor>
{

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor Create()
    {
        var mcpToolsDescriptorResult = CreateMcpToolsDescriptor();
        factoryAction?.Invoke(mcpToolsDescriptorResult);

        return mcpToolsDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor CreateMcpToolsDescriptor()
    {
        var mcpToolsDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor();

        return mcpToolsDescriptorResult;
    }

} // End Of Class

public static class InnerRegistryRecordMcpToolsDescriptorFactoryExtensions
{
}
