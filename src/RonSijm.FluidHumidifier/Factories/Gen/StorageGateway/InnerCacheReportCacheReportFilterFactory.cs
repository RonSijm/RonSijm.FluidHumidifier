// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class InnerCacheReportCacheReportFilterFactory(Action<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter> factoryAction = null) : SubResourceFactory<Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter>
{

    protected override Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter Create()
    {
        var cacheReportFilterResult = CreateCacheReportFilter();
        factoryAction?.Invoke(cacheReportFilterResult);

        return cacheReportFilterResult;
    }

    private Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter CreateCacheReportFilter()
    {
        var cacheReportFilterResult = new Humidifier.StorageGateway.CacheReportTypes.CacheReportFilter();

        return cacheReportFilterResult;
    }

} // End Of Class

public static class InnerCacheReportCacheReportFilterFactoryExtensions
{
}
