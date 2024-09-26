// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class CloudFrontOriginAccessIdentityFactory(string resourceName = null, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentity> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.CloudFrontOriginAccessIdentity>(resourceName)
{

    internal InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory CloudFrontOriginAccessIdentityConfigFactory { get; set; }

    protected override Humidifier.CloudFront.CloudFrontOriginAccessIdentity Create()
    {
        var cloudFrontOriginAccessIdentityResult = CreateCloudFrontOriginAccessIdentity();
        factoryAction?.Invoke(cloudFrontOriginAccessIdentityResult);

        return cloudFrontOriginAccessIdentityResult;
    }

    private Humidifier.CloudFront.CloudFrontOriginAccessIdentity CreateCloudFrontOriginAccessIdentity()
    {
        var cloudFrontOriginAccessIdentityResult = new Humidifier.CloudFront.CloudFrontOriginAccessIdentity
        {
            GivenName = InputResourceName,
        };

        return cloudFrontOriginAccessIdentityResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.CloudFrontOriginAccessIdentity result)
    {
        base.CreateChildren(result);

        result.CloudFrontOriginAccessIdentityConfig ??= CloudFrontOriginAccessIdentityConfigFactory?.Build();
    }

} // End Of Class

public static class CloudFrontOriginAccessIdentityFactoryExtensions
{
    public static CombinedResult<CloudFrontOriginAccessIdentityFactory, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig(this CloudFrontOriginAccessIdentityFactory parentFactory, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null)
    {
        parentFactory.CloudFrontOriginAccessIdentityConfigFactory = new InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudFrontOriginAccessIdentityConfigFactory);
    }

    public static CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1>(this CombinedResult<CloudFrontOriginAccessIdentityFactory, T1> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1>(this CombinedResult<T1, CloudFrontOriginAccessIdentityFactory> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, T2, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2>(this CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, T2, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2>(this CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, T2> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CloudFrontOriginAccessIdentityFactory, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2>(this CombinedResult<T1, T2, CloudFrontOriginAccessIdentityFactory> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, T2, T3, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3>(this CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, T2, T3, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3>(this CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CloudFrontOriginAccessIdentityFactory, T3, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3>(this CombinedResult<T1, T2, CloudFrontOriginAccessIdentityFactory, T3> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CloudFrontOriginAccessIdentityFactory, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CloudFrontOriginAccessIdentityFactory> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, T2, T3, T4, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3, T4>(this CombinedResult<CloudFrontOriginAccessIdentityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, T2, T3, T4, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3, T4>(this CombinedResult<T1, CloudFrontOriginAccessIdentityFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CloudFrontOriginAccessIdentityFactory, T3, T4, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CloudFrontOriginAccessIdentityFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CloudFrontOriginAccessIdentityFactory, T4, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CloudFrontOriginAccessIdentityFactory, T4> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CloudFrontOriginAccessIdentityFactory, InnerCloudFrontOriginAccessIdentityCloudFrontOriginAccessIdentityConfigFactory> WithCloudFrontOriginAccessIdentityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CloudFrontOriginAccessIdentityFactory> combinedResult, Action<Humidifier.CloudFront.CloudFrontOriginAccessIdentityTypes.CloudFrontOriginAccessIdentityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFrontOriginAccessIdentityConfig(combinedResult.T5, subFactoryAction));
}
