// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Outposts;

public class BucketFactory(string resourceName = null, Action<Humidifier.S3Outposts.Bucket> factoryAction = null) : ResourceFactory<Humidifier.S3Outposts.Bucket>(resourceName)
{

    internal InnerBucketLifecycleConfigurationFactory LifecycleConfigurationFactory { get; set; }

    protected override Humidifier.S3Outposts.Bucket Create()
    {
        var bucketResult = CreateBucket();
        factoryAction?.Invoke(bucketResult);

        return bucketResult;
    }

    private Humidifier.S3Outposts.Bucket CreateBucket()
    {
        var bucketResult = new Humidifier.S3Outposts.Bucket
        {
            GivenName = InputResourceName,
        };

        return bucketResult;
    }
    public override void CreateChildren(Humidifier.S3Outposts.Bucket result)
    {
        base.CreateChildren(result);

        result.LifecycleConfiguration ??= LifecycleConfigurationFactory?.Build();
    }

} // End Of Class

public static class BucketFactoryExtensions
{
    public static CombinedResult<BucketFactory, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration(this BucketFactory parentFactory, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null)
    {
        parentFactory.LifecycleConfigurationFactory = new InnerBucketLifecycleConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LifecycleConfigurationFactory);
    }

    public static CombinedResult<BucketFactory, T1, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1>(this CombinedResult<BucketFactory, T1> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1>(this CombinedResult<T1, BucketFactory> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BucketFactory, T1, T2, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<BucketFactory, T1, T2> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, T2, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<T1, BucketFactory, T2> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BucketFactory, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<T1, T2, BucketFactory> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BucketFactory, T1, T2, T3, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<BucketFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, T2, T3, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, BucketFactory, T2, T3> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BucketFactory, T3, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, BucketFactory, T3> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BucketFactory, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, BucketFactory> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BucketFactory, T1, T2, T3, T4, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<BucketFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, T2, T3, T4, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, BucketFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BucketFactory, T3, T4, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, BucketFactory, T3, T4> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BucketFactory, T4, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BucketFactory, T4> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BucketFactory, InnerBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BucketFactory> combinedResult, Action<Humidifier.S3Outposts.BucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T5, subFactoryAction));
}
