// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceEksSourceFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.EksSource> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.EksSource>
{

    internal InnerServiceEksLabelSelectorFactory LabelSelectorFactory { get; set; }

    protected override Humidifier.ResilienceHubV2.ServiceTypes.EksSource Create()
    {
        var eksSourceResult = CreateEksSource();
        factoryAction?.Invoke(eksSourceResult);

        return eksSourceResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.EksSource CreateEksSource()
    {
        var eksSourceResult = new Humidifier.ResilienceHubV2.ServiceTypes.EksSource();

        return eksSourceResult;
    }
    public override void CreateChildren(Humidifier.ResilienceHubV2.ServiceTypes.EksSource result)
    {
        base.CreateChildren(result);

        result.LabelSelector ??= LabelSelectorFactory?.Build();
    }

} // End Of Class

public static class InnerServiceEksSourceFactoryExtensions
{
    public static CombinedResult<InnerServiceEksSourceFactory, InnerServiceEksLabelSelectorFactory> WithLabelSelector(this InnerServiceEksSourceFactory parentFactory, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null)
    {
        parentFactory.LabelSelectorFactory = new InnerServiceEksLabelSelectorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LabelSelectorFactory);
    }

    public static CombinedResult<InnerServiceEksSourceFactory, T1, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1>(this CombinedResult<InnerServiceEksSourceFactory, T1> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithLabelSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceEksSourceFactory, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1>(this CombinedResult<T1, InnerServiceEksSourceFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithLabelSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceEksSourceFactory, T1, T2, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2>(this CombinedResult<InnerServiceEksSourceFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceEksSourceFactory, T2, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2>(this CombinedResult<T1, InnerServiceEksSourceFactory, T2> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceEksSourceFactory, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2>(this CombinedResult<T1, T2, InnerServiceEksSourceFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceEksSourceFactory, T1, T2, T3, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3>(this CombinedResult<InnerServiceEksSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceEksSourceFactory, T2, T3, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3>(this CombinedResult<T1, InnerServiceEksSourceFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceEksSourceFactory, T3, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceEksSourceFactory, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceEksSourceFactory, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceEksSourceFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceEksSourceFactory, T1, T2, T3, T4, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3, T4>(this CombinedResult<InnerServiceEksSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceEksSourceFactory, T2, T3, T4, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceEksSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceEksSourceFactory, T3, T4, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceEksSourceFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceEksSourceFactory, T4, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceEksSourceFactory, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceEksSourceFactory, InnerServiceEksLabelSelectorFactory> WithLabelSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceEksSourceFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.EksLabelSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLabelSelector(combinedResult.T5, subFactoryAction).T2);
}
