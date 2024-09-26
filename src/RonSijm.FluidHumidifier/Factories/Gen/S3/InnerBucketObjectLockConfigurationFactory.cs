// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketObjectLockConfigurationFactory(Action<Humidifier.S3.BucketTypes.ObjectLockConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.ObjectLockConfiguration>
{

    internal InnerBucketObjectLockRuleFactory RuleFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.ObjectLockConfiguration Create()
    {
        var objectLockConfigurationResult = CreateObjectLockConfiguration();
        factoryAction?.Invoke(objectLockConfigurationResult);

        return objectLockConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.ObjectLockConfiguration CreateObjectLockConfiguration()
    {
        var objectLockConfigurationResult = new Humidifier.S3.BucketTypes.ObjectLockConfiguration();

        return objectLockConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.ObjectLockConfiguration result)
    {
        base.CreateChildren(result);

        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class InnerBucketObjectLockConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketObjectLockConfigurationFactory, InnerBucketObjectLockRuleFactory> WithRule(this InnerBucketObjectLockConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerBucketObjectLockRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, InnerBucketObjectLockRuleFactory> WithRule<T1>(this CombinedResult<InnerBucketObjectLockConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, InnerBucketObjectLockRuleFactory> WithRule<T1>(this CombinedResult<T1, InnerBucketObjectLockConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, T2, InnerBucketObjectLockRuleFactory> WithRule<T1, T2>(this CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, T2, InnerBucketObjectLockRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketObjectLockConfigurationFactory, InnerBucketObjectLockRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, InnerBucketObjectLockConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, T2, T3, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, T2, T3, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketObjectLockConfigurationFactory, T3, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketObjectLockConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketObjectLockConfigurationFactory, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketObjectLockConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, T2, T3, T4, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<InnerBucketObjectLockConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, T2, T3, T4, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketObjectLockConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketObjectLockConfigurationFactory, T3, T4, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketObjectLockConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketObjectLockConfigurationFactory, T4, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketObjectLockConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketObjectLockConfigurationFactory, InnerBucketObjectLockRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketObjectLockConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.ObjectLockRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction));
}
