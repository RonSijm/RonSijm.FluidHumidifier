// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordHttpDescriptorFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor>
{

    internal InnerRegistryRecordSourceOnlyDescriptorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor Create()
    {
        var httpDescriptorResult = CreateHttpDescriptor();
        factoryAction?.Invoke(httpDescriptorResult);

        return httpDescriptorResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor CreateHttpDescriptor()
    {
        var httpDescriptorResult = new Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor();

        return httpDescriptorResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor result)
    {
        base.CreateChildren(result);

        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordHttpDescriptorFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordHttpDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource(this InnerRegistryRecordHttpDescriptorFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerRegistryRecordSourceOnlyDescriptorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1>(this CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1>(this CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordHttpDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordHttpDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordHttpDescriptorFactory, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordHttpDescriptorFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordHttpDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordHttpDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordHttpDescriptorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordHttpDescriptorFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordHttpDescriptorFactory, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordHttpDescriptorFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordHttpDescriptorFactory, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordHttpDescriptorFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordHttpDescriptorFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordHttpDescriptorFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
