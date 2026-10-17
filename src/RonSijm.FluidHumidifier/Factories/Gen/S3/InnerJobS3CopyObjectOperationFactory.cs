// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3CopyObjectOperationFactory(Action<Humidifier.S3.JobTypes.S3CopyObjectOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3CopyObjectOperation>
{

    internal InnerJobS3ObjectMetadataFactory NewObjectMetadataFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3CopyObjectOperation Create()
    {
        var s3CopyObjectOperationResult = CreateS3CopyObjectOperation();
        factoryAction?.Invoke(s3CopyObjectOperationResult);

        return s3CopyObjectOperationResult;
    }

    private Humidifier.S3.JobTypes.S3CopyObjectOperation CreateS3CopyObjectOperation()
    {
        var s3CopyObjectOperationResult = new Humidifier.S3.JobTypes.S3CopyObjectOperation();

        return s3CopyObjectOperationResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3CopyObjectOperation result)
    {
        base.CreateChildren(result);

        result.NewObjectMetadata ??= NewObjectMetadataFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3CopyObjectOperationFactoryExtensions
{
    public static CombinedResult<InnerJobS3CopyObjectOperationFactory, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata(this InnerJobS3CopyObjectOperationFactory parentFactory, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null)
    {
        parentFactory.NewObjectMetadataFactory = new InnerJobS3ObjectMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NewObjectMetadataFactory);
    }

    public static CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1>(this CombinedResult<InnerJobS3CopyObjectOperationFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1>(this CombinedResult<T1, InnerJobS3CopyObjectOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, T2, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2>(this CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, T2, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2>(this CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3CopyObjectOperationFactory, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2>(this CombinedResult<T1, T2, InnerJobS3CopyObjectOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, T2, T3, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3>(this CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, T2, T3, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3>(this CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3CopyObjectOperationFactory, T3, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3CopyObjectOperationFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3CopyObjectOperationFactory, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3CopyObjectOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, T2, T3, T4, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3, T4>(this CombinedResult<InnerJobS3CopyObjectOperationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, T2, T3, T4, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3CopyObjectOperationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3CopyObjectOperationFactory, T3, T4, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3CopyObjectOperationFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3CopyObjectOperationFactory, T4, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3CopyObjectOperationFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3CopyObjectOperationFactory, InnerJobS3ObjectMetadataFactory> WithNewObjectMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3CopyObjectOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ObjectMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNewObjectMetadata(combinedResult.T5, subFactoryAction).T2);
}
