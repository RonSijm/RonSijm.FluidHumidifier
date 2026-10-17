// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketDefaultRetentionFactory(Action<Humidifier.S3.BucketTypes.DefaultRetention> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.DefaultRetention>
{

    internal InnerBucketDefaultEventHoldFactory DefaultEventHoldFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.DefaultRetention Create()
    {
        var defaultRetentionResult = CreateDefaultRetention();
        factoryAction?.Invoke(defaultRetentionResult);

        return defaultRetentionResult;
    }

    private Humidifier.S3.BucketTypes.DefaultRetention CreateDefaultRetention()
    {
        var defaultRetentionResult = new Humidifier.S3.BucketTypes.DefaultRetention();

        return defaultRetentionResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.DefaultRetention result)
    {
        base.CreateChildren(result);

        result.DefaultEventHold ??= DefaultEventHoldFactory?.Build();
    }

} // End Of Class

public static class InnerBucketDefaultRetentionFactoryExtensions
{
    public static CombinedResult<InnerBucketDefaultRetentionFactory, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold(this InnerBucketDefaultRetentionFactory parentFactory, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null)
    {
        parentFactory.DefaultEventHoldFactory = new InnerBucketDefaultEventHoldFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultEventHoldFactory);
    }

    public static CombinedResult<InnerBucketDefaultRetentionFactory, T1, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1>(this CombinedResult<InnerBucketDefaultRetentionFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketDefaultRetentionFactory, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1>(this CombinedResult<T1, InnerBucketDefaultRetentionFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBucketDefaultRetentionFactory, T1, T2, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2>(this CombinedResult<InnerBucketDefaultRetentionFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketDefaultRetentionFactory, T2, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2>(this CombinedResult<T1, InnerBucketDefaultRetentionFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketDefaultRetentionFactory, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2>(this CombinedResult<T1, T2, InnerBucketDefaultRetentionFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBucketDefaultRetentionFactory, T1, T2, T3, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3>(this CombinedResult<InnerBucketDefaultRetentionFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketDefaultRetentionFactory, T2, T3, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3>(this CombinedResult<T1, InnerBucketDefaultRetentionFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketDefaultRetentionFactory, T3, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketDefaultRetentionFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketDefaultRetentionFactory, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketDefaultRetentionFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBucketDefaultRetentionFactory, T1, T2, T3, T4, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3, T4>(this CombinedResult<InnerBucketDefaultRetentionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBucketDefaultRetentionFactory, T2, T3, T4, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketDefaultRetentionFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBucketDefaultRetentionFactory, T3, T4, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketDefaultRetentionFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBucketDefaultRetentionFactory, T4, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketDefaultRetentionFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBucketDefaultRetentionFactory, InnerBucketDefaultEventHoldFactory> WithDefaultEventHold<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketDefaultRetentionFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultEventHold> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultEventHold(combinedResult.T5, subFactoryAction).T2);
}
