// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionDefaultCacheBehaviorFactory(Action<Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior>
{

    internal InnerDistributionGrpcConfigFactory GrpcConfigFactory { get; set; }

    internal InnerDistributionForwardedValuesFactory ForwardedValuesFactory { get; set; }

    protected override Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior Create()
    {
        var defaultCacheBehaviorResult = CreateDefaultCacheBehavior();
        factoryAction?.Invoke(defaultCacheBehaviorResult);

        return defaultCacheBehaviorResult;
    }

    private Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior CreateDefaultCacheBehavior()
    {
        var defaultCacheBehaviorResult = new Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior();

        return defaultCacheBehaviorResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.DistributionTypes.DefaultCacheBehavior result)
    {
        base.CreateChildren(result);

        result.GrpcConfig ??= GrpcConfigFactory?.Build();
        result.ForwardedValues ??= ForwardedValuesFactory?.Build();
    }

} // End Of Class

public static class InnerDistributionDefaultCacheBehaviorFactoryExtensions
{
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionGrpcConfigFactory> WithGrpcConfig(this InnerDistributionDefaultCacheBehaviorFactory parentFactory, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null)
    {
        parentFactory.GrpcConfigFactory = new InnerDistributionGrpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GrpcConfigFactory);
    }

    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionForwardedValuesFactory> WithForwardedValues(this InnerDistributionDefaultCacheBehaviorFactory parentFactory, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null)
    {
        parentFactory.ForwardedValuesFactory = new InnerDistributionForwardedValuesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedValuesFactory);
    }

    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGrpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithGrpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3, T4, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3, T4, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3, T4, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory, T4, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionGrpcConfigFactory> WithGrpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGrpcConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2>(this CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3, T4, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3, T4>(this CombinedResult<InnerDistributionDefaultCacheBehaviorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3, T4, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionDefaultCacheBehaviorFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3, T4, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionDefaultCacheBehaviorFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory, T4, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionDefaultCacheBehaviorFactory, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionDefaultCacheBehaviorFactory, InnerDistributionForwardedValuesFactory> WithForwardedValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionDefaultCacheBehaviorFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.ForwardedValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedValues(combinedResult.T5, subFactoryAction));
}
