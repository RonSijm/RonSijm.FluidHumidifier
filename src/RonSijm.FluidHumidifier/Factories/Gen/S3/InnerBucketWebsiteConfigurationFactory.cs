// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketWebsiteConfigurationFactory(Action<Humidifier.S3.BucketTypes.WebsiteConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.WebsiteConfiguration>
{

    internal InnerBucketRedirectAllRequestsToFactory RedirectAllRequestsToFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.WebsiteConfiguration Create()
    {
        var websiteConfigurationResult = CreateWebsiteConfiguration();
        factoryAction?.Invoke(websiteConfigurationResult);

        return websiteConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.WebsiteConfiguration CreateWebsiteConfiguration()
    {
        var websiteConfigurationResult = new Humidifier.S3.BucketTypes.WebsiteConfiguration();

        return websiteConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.WebsiteConfiguration result)
    {
        base.CreateChildren(result);

        result.RedirectAllRequestsTo ??= RedirectAllRequestsToFactory?.Build();
    }

} // End Of Class

public static class InnerBucketWebsiteConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketWebsiteConfigurationFactory, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo(this InnerBucketWebsiteConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null)
    {
        parentFactory.RedirectAllRequestsToFactory = new InnerBucketRedirectAllRequestsToFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RedirectAllRequestsToFactory);
    }

    public static CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1>(this CombinedResult<InnerBucketWebsiteConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1>(this CombinedResult<T1, InnerBucketWebsiteConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, T2, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2>(this CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, T2, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2>(this CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketWebsiteConfigurationFactory, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2>(this CombinedResult<T1, T2, InnerBucketWebsiteConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, T2, T3, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3>(this CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, T2, T3, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3>(this CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketWebsiteConfigurationFactory, T3, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketWebsiteConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketWebsiteConfigurationFactory, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketWebsiteConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, T2, T3, T4, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3, T4>(this CombinedResult<InnerBucketWebsiteConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, T2, T3, T4, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketWebsiteConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketWebsiteConfigurationFactory, T3, T4, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketWebsiteConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketWebsiteConfigurationFactory, T4, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketWebsiteConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketWebsiteConfigurationFactory, InnerBucketRedirectAllRequestsToFactory> WithRedirectAllRequestsTo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketWebsiteConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.RedirectAllRequestsTo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRedirectAllRequestsTo(combinedResult.T5, subFactoryAction));
}
