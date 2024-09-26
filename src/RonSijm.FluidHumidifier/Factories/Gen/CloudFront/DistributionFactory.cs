// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class DistributionFactory(string resourceName = null, Action<Humidifier.CloudFront.Distribution> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.Distribution>(resourceName)
{

    internal InnerDistributionDistributionConfigFactory DistributionConfigFactory { get; set; }

    protected override Humidifier.CloudFront.Distribution Create()
    {
        var distributionResult = CreateDistribution();
        factoryAction?.Invoke(distributionResult);

        return distributionResult;
    }

    private Humidifier.CloudFront.Distribution CreateDistribution()
    {
        var distributionResult = new Humidifier.CloudFront.Distribution
        {
            GivenName = InputResourceName,
        };

        return distributionResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.Distribution result)
    {
        base.CreateChildren(result);

        result.DistributionConfig ??= DistributionConfigFactory?.Build();
    }

} // End Of Class

public static class DistributionFactoryExtensions
{
    public static CombinedResult<DistributionFactory, InnerDistributionDistributionConfigFactory> WithDistributionConfig(this DistributionFactory parentFactory, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null)
    {
        parentFactory.DistributionConfigFactory = new InnerDistributionDistributionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DistributionConfigFactory);
    }

    public static CombinedResult<DistributionFactory, T1, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1>(this CombinedResult<DistributionFactory, T1> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionFactory, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1>(this CombinedResult<T1, DistributionFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DistributionFactory, T1, T2, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2>(this CombinedResult<DistributionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionFactory, T2, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2>(this CombinedResult<T1, DistributionFactory, T2> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DistributionFactory, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2>(this CombinedResult<T1, T2, DistributionFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DistributionFactory, T1, T2, T3, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3>(this CombinedResult<DistributionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionFactory, T2, T3, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3>(this CombinedResult<T1, DistributionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DistributionFactory, T3, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3>(this CombinedResult<T1, T2, DistributionFactory, T3> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DistributionFactory, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DistributionFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DistributionFactory, T1, T2, T3, T4, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3, T4>(this CombinedResult<DistributionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionFactory, T2, T3, T4, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, DistributionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DistributionFactory, T3, T4, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DistributionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DistributionFactory, T4, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DistributionFactory, T4> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DistributionFactory, InnerDistributionDistributionConfigFactory> WithDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DistributionFactory> combinedResult, Action<Humidifier.CloudFront.DistributionTypes.DistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributionConfig(combinedResult.T5, subFactoryAction));
}
