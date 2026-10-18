// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class TrustStoreFactory(string resourceName = null, Action<Humidifier.CloudFront.TrustStore> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.TrustStore>(resourceName)
{

    internal InnerTrustStoreCaCertificatesBundleSourceFactory CaCertificatesBundleSourceFactory { get; set; }

    protected override Humidifier.CloudFront.TrustStore Create()
    {
        var trustStoreResult = CreateTrustStore();
        factoryAction?.Invoke(trustStoreResult);

        return trustStoreResult;
    }

    private Humidifier.CloudFront.TrustStore CreateTrustStore()
    {
        var trustStoreResult = new Humidifier.CloudFront.TrustStore
        {
            GivenName = InputResourceName,
        };

        return trustStoreResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.TrustStore result)
    {
        base.CreateChildren(result);

        result.CaCertificatesBundleSource ??= CaCertificatesBundleSourceFactory?.Build();
    }

} // End Of Class

public static class TrustStoreFactoryExtensions
{
    public static CombinedResult<TrustStoreFactory, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource(this TrustStoreFactory parentFactory, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null)
    {
        parentFactory.CaCertificatesBundleSourceFactory = new InnerTrustStoreCaCertificatesBundleSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CaCertificatesBundleSourceFactory);
    }

    public static CombinedResult<TrustStoreFactory, T1, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1>(this CombinedResult<TrustStoreFactory, T1> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustStoreFactory, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1>(this CombinedResult<T1, TrustStoreFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TrustStoreFactory, T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2>(this CombinedResult<TrustStoreFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustStoreFactory, T2, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2>(this CombinedResult<T1, TrustStoreFactory, T2> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrustStoreFactory, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2>(this CombinedResult<T1, T2, TrustStoreFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TrustStoreFactory, T1, T2, T3, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3>(this CombinedResult<TrustStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustStoreFactory, T2, T3, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3>(this CombinedResult<T1, TrustStoreFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrustStoreFactory, T3, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3>(this CombinedResult<T1, T2, TrustStoreFactory, T3> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrustStoreFactory, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrustStoreFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TrustStoreFactory, T1, T2, T3, T4, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3, T4>(this CombinedResult<TrustStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustStoreFactory, T2, T3, T4, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3, T4>(this CombinedResult<T1, TrustStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrustStoreFactory, T3, T4, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrustStoreFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrustStoreFactory, T4, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrustStoreFactory, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TrustStoreFactory, InnerTrustStoreCaCertificatesBundleSourceFactory> WithCaCertificatesBundleSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrustStoreFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleSource(combinedResult.T5, subFactoryAction).T2);
}
