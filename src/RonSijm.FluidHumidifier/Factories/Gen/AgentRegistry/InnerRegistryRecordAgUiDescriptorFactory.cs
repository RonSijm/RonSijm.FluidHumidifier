// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordAgUiDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor>
{

    internal InnerRegistryRecordSourceOnlyDescriptorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor Create()
    {
        var agUiDescriptorResult = CreateAgUiDescriptor();
        factoryAction?.Invoke(agUiDescriptorResult);

        return agUiDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor CreateAgUiDescriptor()
    {
        var agUiDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor();

        return agUiDescriptorResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordAgUiDescriptorFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource(this InnerRegistryRecordAgUiDescriptorFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerRegistryRecordSourceOnlyDescriptorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1>(this CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgUiDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordAgUiDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgUiDescriptorFactory, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordAgUiDescriptorFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgUiDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgUiDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordAgUiDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordAgUiDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordAgUiDescriptorFactory, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordAgUiDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordAgUiDescriptorFactory, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordAgUiDescriptorFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgUiDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordAgUiDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
