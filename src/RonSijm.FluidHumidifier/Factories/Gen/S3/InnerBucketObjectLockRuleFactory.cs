// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketObjectLockRuleFactory(Action<Humidifier.S3.BucketTypes.ObjectLockRule> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.ObjectLockRule>
{

    internal InnerBucketDefaultRetentionFactory DefaultRetentionFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.ObjectLockRule Create()
    {
        var objectLockRuleResult = CreateObjectLockRule();
        factoryAction?.Invoke(objectLockRuleResult);

        return objectLockRuleResult;
    }

    private Humidifier.S3.BucketTypes.ObjectLockRule CreateObjectLockRule()
    {
        var objectLockRuleResult = new Humidifier.S3.BucketTypes.ObjectLockRule();

        return objectLockRuleResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.ObjectLockRule result)
    {
        base.CreateChildren(result);

        result.DefaultRetention ??= DefaultRetentionFactory?.Build();
    }

} // End Of Class

public static class InnerBucketObjectLockRuleFactoryExtensions
{
    public static CombinedResult<InnerBucketObjectLockRuleFactory, InnerBucketDefaultRetentionFactory> WithDefaultRetention(this InnerBucketObjectLockRuleFactory parentFactory, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null)
    {
        parentFactory.DefaultRetentionFactory = new InnerBucketDefaultRetentionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultRetentionFactory);
    }

    public static CombinedResult<InnerBucketObjectLockRuleFactory, T1, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1>(this CombinedResult<InnerBucketObjectLockRuleFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockRuleFactory, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1>(this CombinedResult<T1, InnerBucketObjectLockRuleFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketObjectLockRuleFactory, T1, T2, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2>(this CombinedResult<InnerBucketObjectLockRuleFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockRuleFactory, T2, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2>(this CombinedResult<T1, InnerBucketObjectLockRuleFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketObjectLockRuleFactory, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2>(this CombinedResult<T1, T2, InnerBucketObjectLockRuleFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketObjectLockRuleFactory, T1, T2, T3, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3>(this CombinedResult<InnerBucketObjectLockRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockRuleFactory, T2, T3, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3>(this CombinedResult<T1, InnerBucketObjectLockRuleFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketObjectLockRuleFactory, T3, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketObjectLockRuleFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketObjectLockRuleFactory, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketObjectLockRuleFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketObjectLockRuleFactory, T1, T2, T3, T4, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3, T4>(this CombinedResult<InnerBucketObjectLockRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockRuleFactory, T2, T3, T4, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketObjectLockRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketObjectLockRuleFactory, T3, T4, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketObjectLockRuleFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketObjectLockRuleFactory, T4, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketObjectLockRuleFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketObjectLockRuleFactory, InnerBucketDefaultRetentionFactory> WithDefaultRetention<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketObjectLockRuleFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DefaultRetention> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRetention(combinedResult.T5, subFactoryAction));
}
