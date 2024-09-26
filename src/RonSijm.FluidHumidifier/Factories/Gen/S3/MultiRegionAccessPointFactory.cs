// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class MultiRegionAccessPointFactory(string resourceName = null, Action<Humidifier.S3.MultiRegionAccessPoint> factoryAction = null) : ResourceFactory<Humidifier.S3.MultiRegionAccessPoint>(resourceName)
{

    internal List<InnerMultiRegionAccessPointRegionFactory> RegionsFactories { get; set; } = [];

    internal InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory PublicAccessBlockConfigurationFactory { get; set; }

    protected override Humidifier.S3.MultiRegionAccessPoint Create()
    {
        var multiRegionAccessPointResult = CreateMultiRegionAccessPoint();
        factoryAction?.Invoke(multiRegionAccessPointResult);

        return multiRegionAccessPointResult;
    }

    private Humidifier.S3.MultiRegionAccessPoint CreateMultiRegionAccessPoint()
    {
        var multiRegionAccessPointResult = new Humidifier.S3.MultiRegionAccessPoint
        {
            GivenName = InputResourceName,
        };

        return multiRegionAccessPointResult;
    }
    public override void CreateChildren(Humidifier.S3.MultiRegionAccessPoint result)
    {
        base.CreateChildren(result);

        result.Regions = RegionsFactories.Any() ? RegionsFactories.Select(x => x.Build()).ToList() : null;
        result.PublicAccessBlockConfiguration ??= PublicAccessBlockConfigurationFactory?.Build();
    }

} // End Of Class

public static class MultiRegionAccessPointFactoryExtensions
{
    public static CombinedResult<MultiRegionAccessPointFactory, InnerMultiRegionAccessPointRegionFactory> WithRegions(this MultiRegionAccessPointFactory parentFactory, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null)
    {
        var factory = new InnerMultiRegionAccessPointRegionFactory(subFactoryAction);
        parentFactory.RegionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MultiRegionAccessPointFactory, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration(this MultiRegionAccessPointFactory parentFactory, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null)
    {
        parentFactory.PublicAccessBlockConfigurationFactory = new InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicAccessBlockConfigurationFactory);
    }

    public static CombinedResult<MultiRegionAccessPointFactory, T1, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1>(this CombinedResult<MultiRegionAccessPointFactory, T1> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1>(this CombinedResult<T1, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, T2, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2>(this CombinedResult<MultiRegionAccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, T2, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2>(this CombinedResult<T1, MultiRegionAccessPointFactory, T2> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2>(this CombinedResult<T1, T2, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3>(this CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3, T4, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3, T4, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3, T4, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory, T4, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointRegionFactory> WithRegions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.Region> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRegions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1>(this CombinedResult<MultiRegionAccessPointFactory, T1> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1>(this CombinedResult<T1, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, T2, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<MultiRegionAccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, T2, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<T1, MultiRegionAccessPointFactory, T2> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<T1, T2, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3, T4, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<MultiRegionAccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3, T4, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MultiRegionAccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3, T4, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MultiRegionAccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory, T4, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MultiRegionAccessPointFactory, T4> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MultiRegionAccessPointFactory, InnerMultiRegionAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MultiRegionAccessPointFactory> combinedResult, Action<Humidifier.S3.MultiRegionAccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T5, subFactoryAction));
}
