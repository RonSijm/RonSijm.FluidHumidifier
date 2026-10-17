// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceResourceConfigurationFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration>
{

    internal InnerServiceEksSourceFactory EksFactory { get; set; }

    protected override Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration Create()
    {
        var resourceConfigurationResult = CreateResourceConfiguration();
        factoryAction?.Invoke(resourceConfigurationResult);

        return resourceConfigurationResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration CreateResourceConfiguration()
    {
        var resourceConfigurationResult = new Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration();

        return resourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration result)
    {
        base.CreateChildren(result);

        result.Eks ??= EksFactory?.Build();
    }

} // End Of Class

public static class InnerServiceResourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceResourceConfigurationFactory, InnerServiceEksSourceFactory> WithEks(this InnerServiceResourceConfigurationFactory parentFactory, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null)
    {
        parentFactory.EksFactory = new InnerServiceEksSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EksFactory);
    }

    public static CombinedResult<InnerServiceResourceConfigurationFactory, T1, InnerServiceEksSourceFactory> WithEks<T1>(this CombinedResult<InnerServiceResourceConfigurationFactory, T1> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceResourceConfigurationFactory, InnerServiceEksSourceFactory> WithEks<T1>(this CombinedResult<T1, InnerServiceResourceConfigurationFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceResourceConfigurationFactory, T1, T2, InnerServiceEksSourceFactory> WithEks<T1, T2>(this CombinedResult<InnerServiceResourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceResourceConfigurationFactory, T2, InnerServiceEksSourceFactory> WithEks<T1, T2>(this CombinedResult<T1, InnerServiceResourceConfigurationFactory, T2> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceResourceConfigurationFactory, InnerServiceEksSourceFactory> WithEks<T1, T2>(this CombinedResult<T1, T2, InnerServiceResourceConfigurationFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceResourceConfigurationFactory, T1, T2, T3, InnerServiceEksSourceFactory> WithEks<T1, T2, T3>(this CombinedResult<InnerServiceResourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceResourceConfigurationFactory, T2, T3, InnerServiceEksSourceFactory> WithEks<T1, T2, T3>(this CombinedResult<T1, InnerServiceResourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceResourceConfigurationFactory, T3, InnerServiceEksSourceFactory> WithEks<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceResourceConfigurationFactory, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceResourceConfigurationFactory, InnerServiceEksSourceFactory> WithEks<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceResourceConfigurationFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceResourceConfigurationFactory, T1, T2, T3, T4, InnerServiceEksSourceFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<InnerServiceResourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceResourceConfigurationFactory, T2, T3, T4, InnerServiceEksSourceFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceResourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceResourceConfigurationFactory, T3, T4, InnerServiceEksSourceFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceResourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceResourceConfigurationFactory, T4, InnerServiceEksSourceFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceResourceConfigurationFactory, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceResourceConfigurationFactory, InnerServiceEksSourceFactory> WithEks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceResourceConfigurationFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEks(combinedResult.T5, subFactoryAction).T2);
}
