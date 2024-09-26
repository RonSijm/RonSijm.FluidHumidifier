// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class BucketFactory(string resourceName = null, Action<Humidifier.Lightsail.Bucket> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Bucket>(resourceName)
{

    internal InnerBucketAccessRulesFactory AccessRulesFactory { get; set; }

    protected override Humidifier.Lightsail.Bucket Create()
    {
        var bucketResult = CreateBucket();
        factoryAction?.Invoke(bucketResult);

        return bucketResult;
    }

    private Humidifier.Lightsail.Bucket CreateBucket()
    {
        var bucketResult = new Humidifier.Lightsail.Bucket
        {
            GivenName = InputResourceName,
        };

        return bucketResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.Bucket result)
    {
        base.CreateChildren(result);

        result.AccessRules ??= AccessRulesFactory?.Build();
    }

} // End Of Class

public static class BucketFactoryExtensions
{
    public static CombinedResult<BucketFactory, InnerBucketAccessRulesFactory> WithAccessRules(this BucketFactory parentFactory, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null)
    {
        parentFactory.AccessRulesFactory = new InnerBucketAccessRulesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessRulesFactory);
    }

    public static CombinedResult<BucketFactory, T1, InnerBucketAccessRulesFactory> WithAccessRules<T1>(this CombinedResult<BucketFactory, T1> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, InnerBucketAccessRulesFactory> WithAccessRules<T1>(this CombinedResult<T1, BucketFactory> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BucketFactory, T1, T2, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2>(this CombinedResult<BucketFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, T2, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2>(this CombinedResult<T1, BucketFactory, T2> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BucketFactory, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2>(this CombinedResult<T1, T2, BucketFactory> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BucketFactory, T1, T2, T3, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3>(this CombinedResult<BucketFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, T2, T3, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3>(this CombinedResult<T1, BucketFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BucketFactory, T3, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3>(this CombinedResult<T1, T2, BucketFactory, T3> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BucketFactory, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, BucketFactory> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BucketFactory, T1, T2, T3, T4, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3, T4>(this CombinedResult<BucketFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BucketFactory, T2, T3, T4, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3, T4>(this CombinedResult<T1, BucketFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BucketFactory, T3, T4, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, BucketFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BucketFactory, T4, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BucketFactory, T4> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BucketFactory, InnerBucketAccessRulesFactory> WithAccessRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BucketFactory> combinedResult, Action<Humidifier.Lightsail.BucketTypes.AccessRules> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessRules(combinedResult.T5, subFactoryAction));
}
