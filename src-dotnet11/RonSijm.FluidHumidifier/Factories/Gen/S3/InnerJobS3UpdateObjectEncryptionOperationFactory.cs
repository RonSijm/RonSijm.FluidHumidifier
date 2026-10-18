// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3UpdateObjectEncryptionOperationFactory(Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation>
{

    internal InnerJobObjectEncryptionFactory ObjectEncryptionFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation Create()
    {
        var s3UpdateObjectEncryptionOperationResult = CreateS3UpdateObjectEncryptionOperation();
        factoryAction?.Invoke(s3UpdateObjectEncryptionOperationResult);

        return s3UpdateObjectEncryptionOperationResult;
    }

    private Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation CreateS3UpdateObjectEncryptionOperation()
    {
        var s3UpdateObjectEncryptionOperationResult = new Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation();

        return s3UpdateObjectEncryptionOperationResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3UpdateObjectEncryptionOperation result)
    {
        base.CreateChildren(result);

        result.ObjectEncryption ??= ObjectEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3UpdateObjectEncryptionOperationFactoryExtensions
{
    public static CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, InnerJobObjectEncryptionFactory> WithObjectEncryption(this InnerJobS3UpdateObjectEncryptionOperationFactory parentFactory, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null)
    {
        parentFactory.ObjectEncryptionFactory = new InnerJobObjectEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ObjectEncryptionFactory);
    }

    public static CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1>(this CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1>(this CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, T2, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2>(this CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, T2, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2>(this CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3UpdateObjectEncryptionOperationFactory, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2>(this CombinedResult<T1, T2, InnerJobS3UpdateObjectEncryptionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, T2, T3, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3>(this CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, T2, T3, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3>(this CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3UpdateObjectEncryptionOperationFactory, T3, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3UpdateObjectEncryptionOperationFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3UpdateObjectEncryptionOperationFactory, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3UpdateObjectEncryptionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, T2, T3, T4, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3, T4>(this CombinedResult<InnerJobS3UpdateObjectEncryptionOperationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, T2, T3, T4, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3UpdateObjectEncryptionOperationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3UpdateObjectEncryptionOperationFactory, T3, T4, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3UpdateObjectEncryptionOperationFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3UpdateObjectEncryptionOperationFactory, T4, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3UpdateObjectEncryptionOperationFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3UpdateObjectEncryptionOperationFactory, InnerJobObjectEncryptionFactory> WithObjectEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3UpdateObjectEncryptionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.ObjectEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectEncryption(combinedResult.T5, subFactoryAction).T2);
}
