// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerTrustStoreCaCertificatesBundleSourceFactory(Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource>
{

    internal InnerTrustStoreCaCertificatesBundleS3LocationFactory CaCertificatesBundleS3LocationFactory { get; set; }

    protected override Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource Create()
    {
        var caCertificatesBundleSourceResult = CreateCaCertificatesBundleSource();
        factoryAction?.Invoke(caCertificatesBundleSourceResult);

        return caCertificatesBundleSourceResult;
    }

    private Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource CreateCaCertificatesBundleSource()
    {
        var caCertificatesBundleSourceResult = new Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource();

        return caCertificatesBundleSourceResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleSource result)
    {
        base.CreateChildren(result);

        result.CaCertificatesBundleS3Location ??= CaCertificatesBundleS3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerTrustStoreCaCertificatesBundleSourceFactoryExtensions
{
    public static CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location(this InnerTrustStoreCaCertificatesBundleSourceFactory parentFactory, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null)
    {
        parentFactory.CaCertificatesBundleS3LocationFactory = new InnerTrustStoreCaCertificatesBundleS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CaCertificatesBundleS3LocationFactory);
    }

    public static CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1>(this CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1>(this CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, T2, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2>(this CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, T2, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2>(this CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, T2> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2>(this CombinedResult<T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, T2, T3, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3>(this CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, T2, T3, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3>(this CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory, T3, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory, T3> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrustStoreCaCertificatesBundleSourceFactory, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrustStoreCaCertificatesBundleSourceFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, T2, T3, T4, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3, T4>(this CombinedResult<InnerTrustStoreCaCertificatesBundleSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, T2, T3, T4, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrustStoreCaCertificatesBundleSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory, T3, T4, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrustStoreCaCertificatesBundleSourceFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrustStoreCaCertificatesBundleSourceFactory, T4, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrustStoreCaCertificatesBundleSourceFactory, T4> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrustStoreCaCertificatesBundleSourceFactory, InnerTrustStoreCaCertificatesBundleS3LocationFactory> WithCaCertificatesBundleS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrustStoreCaCertificatesBundleSourceFactory> combinedResult, Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaCertificatesBundleS3Location(combinedResult.T5, subFactoryAction).T2);
}
