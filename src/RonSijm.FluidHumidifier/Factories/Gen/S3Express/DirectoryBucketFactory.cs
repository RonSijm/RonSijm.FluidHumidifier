// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class DirectoryBucketFactory(string resourceName = null, Action<Humidifier.S3Express.DirectoryBucket> factoryAction = null) : ResourceFactory<Humidifier.S3Express.DirectoryBucket>(resourceName)
{

    internal InnerDirectoryBucketBucketEncryptionFactory BucketEncryptionFactory { get; set; }

    internal InnerDirectoryBucketLifecycleConfigurationFactory LifecycleConfigurationFactory { get; set; }

    protected override Humidifier.S3Express.DirectoryBucket Create()
    {
        var directoryBucketResult = CreateDirectoryBucket();
        factoryAction?.Invoke(directoryBucketResult);

        return directoryBucketResult;
    }

    private Humidifier.S3Express.DirectoryBucket CreateDirectoryBucket()
    {
        var directoryBucketResult = new Humidifier.S3Express.DirectoryBucket
        {
            GivenName = InputResourceName,
        };

        return directoryBucketResult;
    }
    public override void CreateChildren(Humidifier.S3Express.DirectoryBucket result)
    {
        base.CreateChildren(result);

        result.BucketEncryption ??= BucketEncryptionFactory?.Build();
        result.LifecycleConfiguration ??= LifecycleConfigurationFactory?.Build();
    }

} // End Of Class

public static class DirectoryBucketFactoryExtensions
{
    public static CombinedResult<DirectoryBucketFactory, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption(this DirectoryBucketFactory parentFactory, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null)
    {
        parentFactory.BucketEncryptionFactory = new InnerDirectoryBucketBucketEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BucketEncryptionFactory);
    }

    public static CombinedResult<DirectoryBucketFactory, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration(this DirectoryBucketFactory parentFactory, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null)
    {
        parentFactory.LifecycleConfigurationFactory = new InnerDirectoryBucketLifecycleConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LifecycleConfigurationFactory);
    }

    public static CombinedResult<DirectoryBucketFactory, T1, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1>(this CombinedResult<DirectoryBucketFactory, T1> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithBucketEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1>(this CombinedResult<T1, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithBucketEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, T2, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2>(this CombinedResult<DirectoryBucketFactory, T1, T2> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, T2, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2>(this CombinedResult<T1, DirectoryBucketFactory, T2> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryBucketFactory, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2>(this CombinedResult<T1, T2, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, T2, T3, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3>(this CombinedResult<DirectoryBucketFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, T2, T3, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3>(this CombinedResult<T1, DirectoryBucketFactory, T2, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryBucketFactory, T3, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3>(this CombinedResult<T1, T2, DirectoryBucketFactory, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryBucketFactory, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, T2, T3, T4, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3, T4>(this CombinedResult<DirectoryBucketFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, T2, T3, T4, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3, T4>(this CombinedResult<T1, DirectoryBucketFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryBucketFactory, T3, T4, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, DirectoryBucketFactory, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryBucketFactory, T4, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DirectoryBucketFactory, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DirectoryBucketFactory, InnerDirectoryBucketBucketEncryptionFactory> WithBucketEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.BucketEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBucketEncryption(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1>(this CombinedResult<DirectoryBucketFactory, T1> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1>(this CombinedResult<T1, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, T2, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<DirectoryBucketFactory, T1, T2> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, T2, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<T1, DirectoryBucketFactory, T2> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryBucketFactory, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2>(this CombinedResult<T1, T2, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, T2, T3, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<DirectoryBucketFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, T2, T3, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, DirectoryBucketFactory, T2, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryBucketFactory, T3, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DirectoryBucketFactory, T3> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryBucketFactory, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DirectoryBucketFactory, T1, T2, T3, T4, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<DirectoryBucketFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DirectoryBucketFactory, T2, T3, T4, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DirectoryBucketFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DirectoryBucketFactory, T3, T4, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DirectoryBucketFactory, T3, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DirectoryBucketFactory, T4, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DirectoryBucketFactory, T4> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DirectoryBucketFactory, InnerDirectoryBucketLifecycleConfigurationFactory> WithLifecycleConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DirectoryBucketFactory> combinedResult, Action<Humidifier.S3Express.DirectoryBucketTypes.LifecycleConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifecycleConfiguration(combinedResult.T5, subFactoryAction));
}
