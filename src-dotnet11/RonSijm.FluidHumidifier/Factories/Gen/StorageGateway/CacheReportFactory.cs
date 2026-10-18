// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class CacheReportFactory(string resourceName = null, Action<Humidifier.StorageGateway.CacheReport> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.CacheReport>(resourceName)
{

    internal List<InnerCacheReportCacheReportFilterFactory> InclusionFiltersFactories { get; set; } = [];

    internal List<InnerCacheReportCacheReportFilterFactory> ExclusionFiltersFactories { get; set; } = [];

    protected override Humidifier.StorageGateway.CacheReport Create()
    {
        var cacheReportResult = CreateCacheReport();
        factoryAction?.Invoke(cacheReportResult);

        return cacheReportResult;
    }

    private Humidifier.StorageGateway.CacheReport CreateCacheReport()
    {
        var cacheReportResult = new Humidifier.StorageGateway.CacheReport
        {
            GivenName = InputResourceName,
        };

        return cacheReportResult;
    }
    public override void CreateChildren(Humidifier.StorageGateway.CacheReport result)
    {
        base.CreateChildren(result);

        result.InclusionFilters = InclusionFiltersFactories.Any() ? InclusionFiltersFactories.Select(x => x.Build()).ToList() : null;
        result.ExclusionFilters = ExclusionFiltersFactories.Any() ? ExclusionFiltersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CacheReportFactoryExtensions
{
    public static CombinedResult<CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters(this CacheReportFactory parentFactory, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null)
    {
        var factory = new InnerCacheReportCacheReportFilterFactory(subFactoryAction);
        parentFactory.InclusionFiltersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters(this CacheReportFactory parentFactory, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null)
    {
        var factory = new InnerCacheReportCacheReportFilterFactory(subFactoryAction);
        parentFactory.ExclusionFiltersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CacheReportFactory, T1, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1>(this CombinedResult<CacheReportFactory, T1> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithInclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1>(this CombinedResult<T1, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithInclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, T2, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2>(this CombinedResult<CacheReportFactory, T1, T2> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, T2, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2>(this CombinedResult<T1, CacheReportFactory, T2> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2>(this CombinedResult<T1, T2, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, T2, T3, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3>(this CombinedResult<CacheReportFactory, T1, T2, T3> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, T2, T3, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3>(this CombinedResult<T1, CacheReportFactory, T2, T3> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CacheReportFactory, T3, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3>(this CombinedResult<T1, T2, CacheReportFactory, T3> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, T2, T3, T4, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3, T4>(this CombinedResult<CacheReportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, T2, T3, T4, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, CacheReportFactory, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CacheReportFactory, T3, T4, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, CacheReportFactory, T3, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CacheReportFactory, T4, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CacheReportFactory, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithInclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInclusionFilters(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1>(this CombinedResult<CacheReportFactory, T1> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithExclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1>(this CombinedResult<T1, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithExclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, T2, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2>(this CombinedResult<CacheReportFactory, T1, T2> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, T2, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2>(this CombinedResult<T1, CacheReportFactory, T2> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2>(this CombinedResult<T1, T2, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, T2, T3, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3>(this CombinedResult<CacheReportFactory, T1, T2, T3> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, T2, T3, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3>(this CombinedResult<T1, CacheReportFactory, T2, T3> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CacheReportFactory, T3, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3>(this CombinedResult<T1, T2, CacheReportFactory, T3> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CacheReportFactory, T1, T2, T3, T4, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3, T4>(this CombinedResult<CacheReportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CacheReportFactory, T2, T3, T4, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, CacheReportFactory, T2, T3, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CacheReportFactory, T3, T4, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, CacheReportFactory, T3, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CacheReportFactory, T4, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CacheReportFactory, T4> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CacheReportFactory, InnerCacheReportCacheReportFilterFactory> WithExclusionFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CacheReportFactory> combinedResult, Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusionFilters(combinedResult.T5, subFactoryAction).T2);
}
