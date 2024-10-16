// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensS3BucketDestinationFactory(Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.S3BucketDestination>
{

    internal InnerStorageLensEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.S3BucketDestination Create()
    {
        var s3BucketDestinationResult = CreateS3BucketDestination();
        factoryAction?.Invoke(s3BucketDestinationResult);

        return s3BucketDestinationResult;
    }

    private Humidifier.S3.StorageLensTypes.S3BucketDestination CreateS3BucketDestination()
    {
        var s3BucketDestinationResult = new Humidifier.S3.StorageLensTypes.S3BucketDestination();

        return s3BucketDestinationResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.S3BucketDestination result)
    {
        base.CreateChildren(result);

        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensS3BucketDestinationFactoryExtensions
{
    public static CombinedResult<InnerStorageLensS3BucketDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption(this InnerStorageLensS3BucketDestinationFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerStorageLensEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, InnerStorageLensEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, T2, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, T2, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensS3BucketDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensS3BucketDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, T2, T3, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, T2, T3, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensS3BucketDestinationFactory, T3, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensS3BucketDestinationFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensS3BucketDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensS3BucketDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, T2, T3, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensS3BucketDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, T2, T3, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensS3BucketDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensS3BucketDestinationFactory, T3, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensS3BucketDestinationFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensS3BucketDestinationFactory, T4, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensS3BucketDestinationFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensS3BucketDestinationFactory, InnerStorageLensEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensS3BucketDestinationFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
