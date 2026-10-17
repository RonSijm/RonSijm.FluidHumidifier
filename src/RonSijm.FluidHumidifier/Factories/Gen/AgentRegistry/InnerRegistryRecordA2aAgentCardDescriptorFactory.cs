// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordA2aAgentCardDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor>
{

    internal InnerRegistryRecordDescriptorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor Create()
    {
        var a2aAgentCardDescriptorResult = CreateA2aAgentCardDescriptor();
        factoryAction?.Invoke(a2aAgentCardDescriptorResult);

        return a2aAgentCardDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor CreateA2aAgentCardDescriptor()
    {
        var a2aAgentCardDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor();

        return a2aAgentCardDescriptorResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordA2aAgentCardDescriptorFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, InnerRegistryRecordDescriptorSourceFactory> WithSource(this InnerRegistryRecordA2aAgentCardDescriptorFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerRegistryRecordDescriptorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1>(this CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, T2, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, T2, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordA2aAgentCardDescriptorFactory, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordA2aAgentCardDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, T2, T3, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, T2, T3, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordA2aAgentCardDescriptorFactory, T3, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordA2aAgentCardDescriptorFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordA2aAgentCardDescriptorFactory, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordA2aAgentCardDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, T2, T3, T4, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordA2aAgentCardDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, T2, T3, T4, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordA2aAgentCardDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordA2aAgentCardDescriptorFactory, T3, T4, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordA2aAgentCardDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordA2aAgentCardDescriptorFactory, T4, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordA2aAgentCardDescriptorFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordA2aAgentCardDescriptorFactory, InnerRegistryRecordDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordA2aAgentCardDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
