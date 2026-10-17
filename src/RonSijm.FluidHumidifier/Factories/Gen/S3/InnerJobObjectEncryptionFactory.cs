// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobObjectEncryptionFactory(Action<Humidifier.S3.JobTypes.ObjectEncryption> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.ObjectEncryption>
{

    internal InnerJobS3UpdateObjectEncryptionSSEKMSFactory SSEKMSFactory { get; set; }

    protected override Humidifier.S3.JobTypes.ObjectEncryption Create()
    {
        var objectEncryptionResult = CreateObjectEncryption();
        factoryAction?.Invoke(objectEncryptionResult);

        return objectEncryptionResult;
    }

    private Humidifier.S3.JobTypes.ObjectEncryption CreateObjectEncryption()
    {
        var objectEncryptionResult = new Humidifier.S3.JobTypes.ObjectEncryption();

        return objectEncryptionResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.ObjectEncryption result)
    {
        base.CreateChildren(result);

        result.SSEKMS ??= SSEKMSFactory?.Build();
    }

} // End Of Class

public static class InnerJobObjectEncryptionFactoryExtensions
{
    public static CombinedResult<InnerJobObjectEncryptionFactory, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS(this InnerJobObjectEncryptionFactory parentFactory, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null)
    {
        parentFactory.SSEKMSFactory = new InnerJobS3UpdateObjectEncryptionSSEKMSFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SSEKMSFactory);
    }

    public static CombinedResult<InnerJobObjectEncryptionFactory, T1, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1>(this CombinedResult<InnerJobObjectEncryptionFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobObjectEncryptionFactory, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1>(this CombinedResult<T1, InnerJobObjectEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobObjectEncryptionFactory, T1, T2, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2>(this CombinedResult<InnerJobObjectEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobObjectEncryptionFactory, T2, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2>(this CombinedResult<T1, InnerJobObjectEncryptionFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobObjectEncryptionFactory, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2>(this CombinedResult<T1, T2, InnerJobObjectEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobObjectEncryptionFactory, T1, T2, T3, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<InnerJobObjectEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobObjectEncryptionFactory, T2, T3, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, InnerJobObjectEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobObjectEncryptionFactory, T3, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobObjectEncryptionFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobObjectEncryptionFactory, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobObjectEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobObjectEncryptionFactory, T1, T2, T3, T4, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<InnerJobObjectEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobObjectEncryptionFactory, T2, T3, T4, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobObjectEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobObjectEncryptionFactory, T3, T4, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobObjectEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobObjectEncryptionFactory, T4, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobObjectEncryptionFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobObjectEncryptionFactory, InnerJobS3UpdateObjectEncryptionSSEKMSFactory> WithSSEKMS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobObjectEncryptionFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3UpdateObjectEncryptionSSEKMS> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSSEKMS(combinedResult.T5, subFactoryAction).T2);
}
