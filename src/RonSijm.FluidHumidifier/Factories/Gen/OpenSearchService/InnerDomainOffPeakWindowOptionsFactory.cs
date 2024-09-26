// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainOffPeakWindowOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions>
{

    internal InnerDomainOffPeakWindowFactory OffPeakWindowFactory { get; set; }

    protected override Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions Create()
    {
        var offPeakWindowOptionsResult = CreateOffPeakWindowOptions();
        factoryAction?.Invoke(offPeakWindowOptionsResult);

        return offPeakWindowOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions CreateOffPeakWindowOptions()
    {
        var offPeakWindowOptionsResult = new Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions();

        return offPeakWindowOptionsResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchService.DomainTypes.OffPeakWindowOptions result)
    {
        base.CreateChildren(result);

        result.OffPeakWindow ??= OffPeakWindowFactory?.Build();
    }

} // End Of Class

public static class InnerDomainOffPeakWindowOptionsFactoryExtensions
{
    public static CombinedResult<InnerDomainOffPeakWindowOptionsFactory, InnerDomainOffPeakWindowFactory> WithOffPeakWindow(this InnerDomainOffPeakWindowOptionsFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null)
    {
        parentFactory.OffPeakWindowFactory = new InnerDomainOffPeakWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OffPeakWindowFactory);
    }

    public static CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1>(this CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1>(this CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, T2, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2>(this CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, T2, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2>(this CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainOffPeakWindowOptionsFactory, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2>(this CombinedResult<T1, T2, InnerDomainOffPeakWindowOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, T2, T3, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3>(this CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, T2, T3, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3>(this CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainOffPeakWindowOptionsFactory, T3, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainOffPeakWindowOptionsFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowOptionsFactory, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, T2, T3, T4, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3, T4>(this CombinedResult<InnerDomainOffPeakWindowOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, T2, T3, T4, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainOffPeakWindowOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainOffPeakWindowOptionsFactory, T3, T4, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainOffPeakWindowOptionsFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowOptionsFactory, T4, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowOptionsFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainOffPeakWindowOptionsFactory, InnerDomainOffPeakWindowFactory> WithOffPeakWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainOffPeakWindowOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOffPeakWindow(combinedResult.T5, subFactoryAction));
}
