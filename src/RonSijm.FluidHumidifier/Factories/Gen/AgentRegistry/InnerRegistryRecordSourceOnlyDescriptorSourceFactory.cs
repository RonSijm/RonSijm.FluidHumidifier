// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordSourceOnlyDescriptorSourceFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource>
{

    internal InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory FromUrlFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource Create()
    {
        var sourceOnlyDescriptorSourceResult = CreateSourceOnlyDescriptorSource();
        factoryAction?.Invoke(sourceOnlyDescriptorSourceResult);

        return sourceOnlyDescriptorSourceResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource CreateSourceOnlyDescriptorSource()
    {
        var sourceOnlyDescriptorSourceResult = new Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource();

        return sourceOnlyDescriptorSourceResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource result)
    {
        base.CreateChildren(result);

        result.FromUrl ??= FromUrlFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordSourceOnlyDescriptorSourceFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl(this InnerRegistryRecordSourceOnlyDescriptorSourceFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null)
    {
        parentFactory.FromUrlFactory = new InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FromUrlFactory);
    }

    public static CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1>(this CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1>(this CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory, InnerRegistryRecordSourceOnlyDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordSourceOnlyDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T5, subFactoryAction).T2);
}
