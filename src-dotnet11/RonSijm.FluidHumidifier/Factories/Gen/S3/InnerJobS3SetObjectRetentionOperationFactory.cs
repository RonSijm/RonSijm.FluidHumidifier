// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3SetObjectRetentionOperationFactory(Action<Humidifier.S3.JobTypes.S3SetObjectRetentionOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3SetObjectRetentionOperation>
{

    internal InnerJobS3RetentionFactory RetentionFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3SetObjectRetentionOperation Create()
    {
        var s3SetObjectRetentionOperationResult = CreateS3SetObjectRetentionOperation();
        factoryAction?.Invoke(s3SetObjectRetentionOperationResult);

        return s3SetObjectRetentionOperationResult;
    }

    private Humidifier.S3.JobTypes.S3SetObjectRetentionOperation CreateS3SetObjectRetentionOperation()
    {
        var s3SetObjectRetentionOperationResult = new Humidifier.S3.JobTypes.S3SetObjectRetentionOperation();

        return s3SetObjectRetentionOperationResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3SetObjectRetentionOperation result)
    {
        base.CreateChildren(result);

        result.Retention ??= RetentionFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3SetObjectRetentionOperationFactoryExtensions
{
    public static CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, InnerJobS3RetentionFactory> WithRetention(this InnerJobS3SetObjectRetentionOperationFactory parentFactory, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null)
    {
        parentFactory.RetentionFactory = new InnerJobS3RetentionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionFactory);
    }

    public static CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, InnerJobS3RetentionFactory> WithRetention<T1>(this CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, InnerJobS3RetentionFactory> WithRetention<T1>(this CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, T2, InnerJobS3RetentionFactory> WithRetention<T1, T2>(this CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, T2, InnerJobS3RetentionFactory> WithRetention<T1, T2>(this CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectRetentionOperationFactory, InnerJobS3RetentionFactory> WithRetention<T1, T2>(this CombinedResult<T1, T2, InnerJobS3SetObjectRetentionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, T2, T3, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, T2, T3, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectRetentionOperationFactory, T3, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3SetObjectRetentionOperationFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3SetObjectRetentionOperationFactory, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3SetObjectRetentionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, T2, T3, T4, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<InnerJobS3SetObjectRetentionOperationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, T2, T3, T4, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3SetObjectRetentionOperationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3SetObjectRetentionOperationFactory, T3, T4, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3SetObjectRetentionOperationFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3SetObjectRetentionOperationFactory, T4, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3SetObjectRetentionOperationFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3SetObjectRetentionOperationFactory, InnerJobS3RetentionFactory> WithRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3SetObjectRetentionOperationFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3Retention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetention(combinedResult.T5, subFactoryAction).T2);
}
