// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupOnlineStoreConfigFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig>
{

    internal InnerFeatureGroupOnlineStoreSecurityConfigFactory SecurityConfigFactory { get; set; }

    internal InnerFeatureGroupTtlDurationFactory TtlDurationFactory { get; set; }

    protected override Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig Create()
    {
        var onlineStoreConfigResult = CreateOnlineStoreConfig();
        factoryAction?.Invoke(onlineStoreConfigResult);

        return onlineStoreConfigResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig CreateOnlineStoreConfig()
    {
        var onlineStoreConfigResult = new Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig();

        return onlineStoreConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreConfig result)
    {
        base.CreateChildren(result);

        result.SecurityConfig ??= SecurityConfigFactory?.Build();
        result.TtlDuration ??= TtlDurationFactory?.Build();
    }

} // End Of Class

public static class InnerFeatureGroupOnlineStoreConfigFactoryExtensions
{
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig(this InnerFeatureGroupOnlineStoreConfigFactory parentFactory, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null)
    {
        parentFactory.SecurityConfigFactory = new InnerFeatureGroupOnlineStoreSecurityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecurityConfigFactory);
    }

    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupTtlDurationFactory> WithTtlDuration(this InnerFeatureGroupOnlineStoreConfigFactory parentFactory, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null)
    {
        parentFactory.TtlDurationFactory = new InnerFeatureGroupTtlDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TtlDurationFactory);
    }

    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2>(this CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3, T4, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3, T4, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3, T4, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory, T4, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupOnlineStoreSecurityConfigFactory> WithSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.OnlineStoreSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTtlDuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTtlDuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2>(this CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3, T4, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3, T4>(this CombinedResult<InnerFeatureGroupOnlineStoreConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3, T4, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeatureGroupOnlineStoreConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3, T4, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeatureGroupOnlineStoreConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory, T4, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeatureGroupOnlineStoreConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOnlineStoreConfigFactory, InnerFeatureGroupTtlDurationFactory> WithTtlDuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeatureGroupOnlineStoreConfigFactory> combinedResult, Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTtlDuration(combinedResult.T5, subFactoryAction));
}
