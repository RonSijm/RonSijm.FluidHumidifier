// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordMcpServerAdditionalDataFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData>
{

    internal InnerRegistryRecordMcpToolsDescriptorFactory ToolsFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData Create()
    {
        var mcpServerAdditionalDataResult = CreateMcpServerAdditionalData();
        factoryAction?.Invoke(mcpServerAdditionalDataResult);

        return mcpServerAdditionalDataResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData CreateMcpServerAdditionalData()
    {
        var mcpServerAdditionalDataResult = new Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData();

        return mcpServerAdditionalDataResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData result)
    {
        base.CreateChildren(result);

        result.Tools ??= ToolsFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordMcpServerAdditionalDataFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools(this InnerRegistryRecordMcpServerAdditionalDataFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null)
    {
        parentFactory.ToolsFactory = new InnerRegistryRecordMcpToolsDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ToolsFactory);
    }

    public static CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1>(this CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithTools(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1>(this CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithTools(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, T2, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2>(this CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, T2, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2>(this CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordMcpServerAdditionalDataFactory, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordMcpServerAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, T2, T3, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3>(this CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, T2, T3, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordMcpServerAdditionalDataFactory, T3, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordMcpServerAdditionalDataFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordMcpServerAdditionalDataFactory, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordMcpServerAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, T2, T3, T4, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordMcpServerAdditionalDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, T2, T3, T4, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordMcpServerAdditionalDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordMcpServerAdditionalDataFactory, T3, T4, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordMcpServerAdditionalDataFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordMcpServerAdditionalDataFactory, T4, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordMcpServerAdditionalDataFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordMcpServerAdditionalDataFactory, InnerRegistryRecordMcpToolsDescriptorFactory> WithTools<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordMcpServerAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTools(combinedResult.T5, subFactoryAction).T2);
}
