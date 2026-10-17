// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor>
{

    internal InnerRegistryRecordAgentSkillsAdditionalDataFactory AdditionalDataFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor Create()
    {
        var agentSkillsDefinitionDescriptorResult = CreateAgentSkillsDefinitionDescriptor();
        factoryAction?.Invoke(agentSkillsDefinitionDescriptorResult);

        return agentSkillsDefinitionDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor CreateAgentSkillsDefinitionDescriptor()
    {
        var agentSkillsDefinitionDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor();

        return agentSkillsDefinitionDescriptorResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor result)
    {
        base.CreateChildren(result);

        result.AdditionalData ??= AdditionalDataFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordAgentSkillsDefinitionDescriptorFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData(this InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null)
    {
        parentFactory.AdditionalDataFactory = new InnerRegistryRecordAgentSkillsAdditionalDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdditionalDataFactory);
    }

    public static CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1>(this CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdditionalData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdditionalData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2>(this CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, T2, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3>(this CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T2, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, T2, T3, T4, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T2, T3, T4, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T3, T4, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T4, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory, InnerRegistryRecordAgentSkillsAdditionalDataFactory> WithAdditionalData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgentSkillsDefinitionDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalData(combinedResult.T5, subFactoryAction).T2);
}
