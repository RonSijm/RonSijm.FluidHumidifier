// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class OTelEnrichmentFactory(string resourceName = null, Action<Humidifier.CloudWatch.OTelEnrichment> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.OTelEnrichment>(resourceName)
{

    internal List<InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> IncludeFiltersFactories { get; set; } = [];

    internal List<InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> ExcludeFiltersFactories { get; set; } = [];

    protected override Humidifier.CloudWatch.OTelEnrichment Create()
    {
        var oTelEnrichmentResult = CreateOTelEnrichment();
        factoryAction?.Invoke(oTelEnrichmentResult);

        return oTelEnrichmentResult;
    }

    private Humidifier.CloudWatch.OTelEnrichment CreateOTelEnrichment()
    {
        var oTelEnrichmentResult = new Humidifier.CloudWatch.OTelEnrichment
        {
            GivenName = InputResourceName,
        };

        return oTelEnrichmentResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.OTelEnrichment result)
    {
        base.CreateChildren(result);

        result.IncludeFilters = IncludeFiltersFactories.Any() ? IncludeFiltersFactories.Select(x => x.Build()).ToList() : null;
        result.ExcludeFilters = ExcludeFiltersFactories.Any() ? ExcludeFiltersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class OTelEnrichmentFactoryExtensions
{
    public static CombinedResult<OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters(this OTelEnrichmentFactory parentFactory, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null)
    {
        var factory = new InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory(subFactoryAction);
        parentFactory.IncludeFiltersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters(this OTelEnrichmentFactory parentFactory, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null)
    {
        var factory = new InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory(subFactoryAction);
        parentFactory.ExcludeFiltersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<OTelEnrichmentFactory, T1, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1>(this CombinedResult<OTelEnrichmentFactory, T1> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1>(this CombinedResult<T1, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, T2, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2>(this CombinedResult<OTelEnrichmentFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, T2, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2>(this CombinedResult<T1, OTelEnrichmentFactory, T2> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2>(this CombinedResult<T1, T2, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, T2, T3, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3>(this CombinedResult<OTelEnrichmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, T2, T3, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3>(this CombinedResult<T1, OTelEnrichmentFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OTelEnrichmentFactory, T3, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3>(this CombinedResult<T1, T2, OTelEnrichmentFactory, T3> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, T2, T3, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3, T4>(this CombinedResult<OTelEnrichmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, T2, T3, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, OTelEnrichmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OTelEnrichmentFactory, T3, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, OTelEnrichmentFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OTelEnrichmentFactory, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OTelEnrichmentFactory, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithIncludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncludeFilters(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1>(this CombinedResult<OTelEnrichmentFactory, T1> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1>(this CombinedResult<T1, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, T2, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2>(this CombinedResult<OTelEnrichmentFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, T2, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2>(this CombinedResult<T1, OTelEnrichmentFactory, T2> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2>(this CombinedResult<T1, T2, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, T2, T3, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3>(this CombinedResult<OTelEnrichmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, T2, T3, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3>(this CombinedResult<T1, OTelEnrichmentFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OTelEnrichmentFactory, T3, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3>(this CombinedResult<T1, T2, OTelEnrichmentFactory, T3> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OTelEnrichmentFactory, T1, T2, T3, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3, T4>(this CombinedResult<OTelEnrichmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OTelEnrichmentFactory, T2, T3, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, OTelEnrichmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OTelEnrichmentFactory, T3, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, OTelEnrichmentFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OTelEnrichmentFactory, T4, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OTelEnrichmentFactory, T4> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OTelEnrichmentFactory, InnerOTelEnrichmentOTelEnrichmentMetricSelectorFactory> WithExcludeFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OTelEnrichmentFactory> combinedResult, Action<Humidifier.CloudWatch.OTelEnrichmentTypes.OTelEnrichmentMetricSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeFilters(combinedResult.T5, subFactoryAction).T2);
}
