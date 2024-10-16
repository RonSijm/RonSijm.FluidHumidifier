// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainOffPeakWindowFactory(Action<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.OffPeakWindow>
{

    internal InnerDomainWindowStartTimeFactory WindowStartTimeFactory { get; set; }

    protected override Humidifier.OpenSearchService.DomainTypes.OffPeakWindow Create()
    {
        var offPeakWindowResult = CreateOffPeakWindow();
        factoryAction?.Invoke(offPeakWindowResult);

        return offPeakWindowResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.OffPeakWindow CreateOffPeakWindow()
    {
        var offPeakWindowResult = new Humidifier.OpenSearchService.DomainTypes.OffPeakWindow();

        return offPeakWindowResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchService.DomainTypes.OffPeakWindow result)
    {
        base.CreateChildren(result);

        result.WindowStartTime ??= WindowStartTimeFactory?.Build();
    }

} // End Of Class

public static class InnerDomainOffPeakWindowFactoryExtensions
{
    public static CombinedResult<InnerDomainOffPeakWindowFactory, InnerDomainWindowStartTimeFactory> WithWindowStartTime(this InnerDomainOffPeakWindowFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null)
    {
        parentFactory.WindowStartTimeFactory = new InnerDomainWindowStartTimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WindowStartTimeFactory);
    }

    public static CombinedResult<InnerDomainOffPeakWindowFactory, T1, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1>(this CombinedResult<InnerDomainOffPeakWindowFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindowStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowFactory, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1>(this CombinedResult<T1, InnerDomainOffPeakWindowFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, WithWindowStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainOffPeakWindowFactory, T1, T2, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2>(this CombinedResult<InnerDomainOffPeakWindowFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowFactory, T2, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2>(this CombinedResult<T1, InnerDomainOffPeakWindowFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainOffPeakWindowFactory, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2>(this CombinedResult<T1, T2, InnerDomainOffPeakWindowFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainOffPeakWindowFactory, T1, T2, T3, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3>(this CombinedResult<InnerDomainOffPeakWindowFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowFactory, T2, T3, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3>(this CombinedResult<T1, InnerDomainOffPeakWindowFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainOffPeakWindowFactory, T3, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainOffPeakWindowFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowFactory, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainOffPeakWindowFactory, T1, T2, T3, T4, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3, T4>(this CombinedResult<InnerDomainOffPeakWindowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainOffPeakWindowFactory, T2, T3, T4, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainOffPeakWindowFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainOffPeakWindowFactory, T3, T4, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainOffPeakWindowFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowFactory, T4, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainOffPeakWindowFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainOffPeakWindowFactory, InnerDomainWindowStartTimeFactory> WithWindowStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainOffPeakWindowFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.WindowStartTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWindowStartTime(combinedResult.T5, subFactoryAction));
}
