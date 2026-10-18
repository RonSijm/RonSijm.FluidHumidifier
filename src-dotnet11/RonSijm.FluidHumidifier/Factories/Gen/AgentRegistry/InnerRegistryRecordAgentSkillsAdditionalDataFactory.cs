// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordAgentSkillsAdditionalDataFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData>
{

    internal InnerRegistryRecordAgentSkillsMdDescriptorFactory SkillMdFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData Create()
    {
        var agentSkillsAdditionalDataResult = CreateAgentSkillsAdditionalData();
        factoryAction?.Invoke(agentSkillsAdditionalDataResult);

        return agentSkillsAdditionalDataResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData CreateAgentSkillsAdditionalData()
    {
        var agentSkillsAdditionalDataResult = new Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData();

        return agentSkillsAdditionalDataResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData result)
    {
        base.CreateChildren(result);

        result.SkillMd ??= SkillMdFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordAgentSkillsAdditionalDataFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd(this InnerRegistryRecordAgentSkillsAdditionalDataFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null)
    {
        parentFactory.SkillMdFactory = new InnerRegistryRecordAgentSkillsMdDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SkillMdFactory);
    }

    public static CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1>(this CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkillMd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkillMd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2>(this CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, T2, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3>(this CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T2, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, T2, T3, T4, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordAgentSkillsAdditionalDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T2, T3, T4, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T3, T4, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T4, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsAdditionalDataFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgentSkillsAdditionalDataFactory, InnerRegistryRecordAgentSkillsMdDescriptorFactory> WithSkillMd<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgentSkillsAdditionalDataFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillMd(combinedResult.T5, subFactoryAction).T2);
}
