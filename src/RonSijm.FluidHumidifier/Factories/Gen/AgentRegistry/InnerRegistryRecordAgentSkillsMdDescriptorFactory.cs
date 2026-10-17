// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordAgentSkillsMdDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor>
{

    internal InnerRegistryRecordSkillMdSourceFactory SourceFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor Create()
    {
        var agentSkillsMdDescriptorResult = CreateAgentSkillsMdDescriptor();
        factoryAction?.Invoke(agentSkillsMdDescriptorResult);

        return agentSkillsMdDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor CreateAgentSkillsMdDescriptor()
    {
        var agentSkillsMdDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor();

        return agentSkillsMdDescriptorResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordAgentSkillsMdDescriptorFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, InnerRegistryRecordSkillMdSourceFactory> WithSource(this InnerRegistryRecordAgentSkillsMdDescriptorFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerRegistryRecordSkillMdSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1>(this CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, T2, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T2, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, T2, T3, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T2, T3, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T3, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, T2, T3, T4, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordAgentSkillsMdDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T2, T3, T4, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T3, T4, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T4, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgentSkillsMdDescriptorFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgentSkillsMdDescriptorFactory, InnerRegistryRecordSkillMdSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgentSkillsMdDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
