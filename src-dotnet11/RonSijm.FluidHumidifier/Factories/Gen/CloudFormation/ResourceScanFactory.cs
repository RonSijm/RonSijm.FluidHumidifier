// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class ResourceScanFactory(string resourceName = null, Action<Humidifier.CloudFormation.ResourceScan> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.ResourceScan>(resourceName)
{

    internal List<InnerResourceScanScanFilterFactory> ScanFiltersFactories { get; set; } = [];

    protected override Humidifier.CloudFormation.ResourceScan Create()
    {
        var resourceScanResult = CreateResourceScan();
        factoryAction?.Invoke(resourceScanResult);

        return resourceScanResult;
    }

    private Humidifier.CloudFormation.ResourceScan CreateResourceScan()
    {
        var resourceScanResult = new Humidifier.CloudFormation.ResourceScan
        {
            GivenName = InputResourceName,
        };

        return resourceScanResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.ResourceScan result)
    {
        base.CreateChildren(result);

        result.ScanFilters = ScanFiltersFactories.Any() ? ScanFiltersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ResourceScanFactoryExtensions
{
    public static CombinedResult<ResourceScanFactory, InnerResourceScanScanFilterFactory> WithScanFilters(this ResourceScanFactory parentFactory, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null)
    {
        var factory = new InnerResourceScanScanFilterFactory(subFactoryAction);
        parentFactory.ScanFiltersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ResourceScanFactory, T1, InnerResourceScanScanFilterFactory> WithScanFilters<T1>(this CombinedResult<ResourceScanFactory, T1> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithScanFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceScanFactory, InnerResourceScanScanFilterFactory> WithScanFilters<T1>(this CombinedResult<T1, ResourceScanFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithScanFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ResourceScanFactory, T1, T2, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2>(this CombinedResult<ResourceScanFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceScanFactory, T2, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2>(this CombinedResult<T1, ResourceScanFactory, T2> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceScanFactory, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2>(this CombinedResult<T1, T2, ResourceScanFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ResourceScanFactory, T1, T2, T3, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3>(this CombinedResult<ResourceScanFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceScanFactory, T2, T3, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3>(this CombinedResult<T1, ResourceScanFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceScanFactory, T3, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3>(this CombinedResult<T1, T2, ResourceScanFactory, T3> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ResourceScanFactory, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceScanFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ResourceScanFactory, T1, T2, T3, T4, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3, T4>(this CombinedResult<ResourceScanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceScanFactory, T2, T3, T4, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3, T4>(this CombinedResult<T1, ResourceScanFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceScanFactory, T3, T4, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceScanFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ResourceScanFactory, T4, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceScanFactory, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ResourceScanFactory, InnerResourceScanScanFilterFactory> WithScanFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceScanFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceScanTypes.ScanFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScanFilters(combinedResult.T5, subFactoryAction).T2);
}
