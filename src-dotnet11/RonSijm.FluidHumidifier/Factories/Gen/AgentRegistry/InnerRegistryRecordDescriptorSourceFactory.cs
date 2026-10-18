// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordDescriptorSourceFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource>
{

    internal InnerRegistryRecordDescriptorSourceFromUrlFactory FromUrlFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource Create()
    {
        var descriptorSourceResult = CreateDescriptorSource();
        factoryAction?.Invoke(descriptorSourceResult);

        return descriptorSourceResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource CreateDescriptorSource()
    {
        var descriptorSourceResult = new Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource();

        return descriptorSourceResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource result)
    {
        base.CreateChildren(result);

        result.FromUrl ??= FromUrlFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordDescriptorSourceFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordDescriptorSourceFactory, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl(this InnerRegistryRecordDescriptorSourceFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null)
    {
        parentFactory.FromUrlFactory = new InnerRegistryRecordDescriptorSourceFromUrlFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FromUrlFactory);
    }

    public static CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1>(this CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1>(this CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, T2, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, T2, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordDescriptorSourceFactory, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, T2, T3, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, T2, T3, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordDescriptorSourceFactory, T3, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordDescriptorSourceFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordDescriptorSourceFactory, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, T2, T3, T4, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordDescriptorSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, T2, T3, T4, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordDescriptorSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordDescriptorSourceFactory, T3, T4, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordDescriptorSourceFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordDescriptorSourceFactory, T4, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordDescriptorSourceFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordDescriptorSourceFactory, InnerRegistryRecordDescriptorSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordDescriptorSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T5, subFactoryAction).T2);
}
