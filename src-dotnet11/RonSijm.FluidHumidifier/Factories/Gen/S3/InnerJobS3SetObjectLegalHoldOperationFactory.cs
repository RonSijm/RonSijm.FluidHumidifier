// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3SetObjectLegalHoldOperationFactory(Action<Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation>
{

    internal InnerJobS3ObjectLockLegalHoldFactory LegalHoldFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation Create()
    {
        var s3SetObjectLegalHoldOperationResult = CreateS3SetObjectLegalHoldOperation();
        factoryAction?.Invoke(s3SetObjectLegalHoldOperationResult);

        return s3SetObjectLegalHoldOperationResult;
    }

    private Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation CreateS3SetObjectLegalHoldOperation()
    {
        var s3SetObjectLegalHoldOperationResult = new Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation();

        return s3SetObjectLegalHoldOperationResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3SetObjectLegalHoldOperation result)
    {
        base.CreateChildren(result);

        result.LegalHold ??= LegalHoldFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3SetObjectLegalHoldOperationFactoryExtensions
{
    public static CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold(this InnerJobS3SetObjectLegalHoldOperationFactory parentFactory, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null)
    {
        parentFactory.LegalHoldFactory = new InnerJobS3ObjectLockLegalHoldFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LegalHoldFactory);
    }

    public static CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1>(this CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, WithLegalHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1>(this CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, WithLegalHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, T2, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2>(this CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, T2, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2>(this CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectLegalHoldOperationFactory, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2>(this CombinedResult<T1, T2, InnerJobS3SetObjectLegalHoldOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, T2, T3, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3>(this CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, T2, T3, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3>(this CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectLegalHoldOperationFactory, T3, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3SetObjectLegalHoldOperationFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3SetObjectLegalHoldOperationFactory, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3SetObjectLegalHoldOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, T2, T3, T4, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3, T4>(this CombinedResult<InnerJobS3SetObjectLegalHoldOperationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, T2, T3, T4, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3SetObjectLegalHoldOperationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectLegalHoldOperationFactory, T3, T4, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3SetObjectLegalHoldOperationFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3SetObjectLegalHoldOperationFactory, T4, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3SetObjectLegalHoldOperationFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3SetObjectLegalHoldOperationFactory, InnerJobS3ObjectLockLegalHoldFactory> WithLegalHold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3SetObjectLegalHoldOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectLockLegalHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLegalHold(combinedResult.T5, subFactoryAction).T2);
}
