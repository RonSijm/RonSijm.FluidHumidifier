// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionViewerMtlsConfigFactory(Action<Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig>
{

    internal InnerDistributionTrustStoreConfigFactory TrustStoreConfigFactory { get; set; }

    protected override Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig Create()
    {
        var viewerMtlsConfigResult = CreateViewerMtlsConfig();
        factoryAction?.Invoke(viewerMtlsConfigResult);

        return viewerMtlsConfigResult;
    }

    private Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig CreateViewerMtlsConfig()
    {
        var viewerMtlsConfigResult = new Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig();

        return viewerMtlsConfigResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.DistributionTypes.ViewerMtlsConfig result)
    {
        base.CreateChildren(result);

        result.TrustStoreConfig ??= TrustStoreConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDistributionViewerMtlsConfigFactoryExtensions
{
    public static CombinedResult<InnerDistributionViewerMtlsConfigFactory, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig(this InnerDistributionViewerMtlsConfigFactory parentFactory, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null)
    {
        parentFactory.TrustStoreConfigFactory = new InnerDistributionTrustStoreConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrustStoreConfigFactory);
    }

    public static CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1>(this CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1>(this CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, T2, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2>(this CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, T2, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2>(this CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDistributionViewerMtlsConfigFactory, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2>(this CombinedResult<T1, T2, InnerDistributionViewerMtlsConfigFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, T2, T3, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3>(this CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, T2, T3, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3>(this CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDistributionViewerMtlsConfigFactory, T3, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionViewerMtlsConfigFactory, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDistributionViewerMtlsConfigFactory, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionViewerMtlsConfigFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, T2, T3, T4, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3, T4>(this CombinedResult<InnerDistributionViewerMtlsConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, T2, T3, T4, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionViewerMtlsConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDistributionViewerMtlsConfigFactory, T3, T4, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionViewerMtlsConfigFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDistributionViewerMtlsConfigFactory, T4, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionViewerMtlsConfigFactory, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionViewerMtlsConfigFactory, InnerDistributionTrustStoreConfigFactory> WithTrustStoreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionViewerMtlsConfigFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.TrustStoreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrustStoreConfig(combinedResult.T5, subFactoryAction).T2);
}
