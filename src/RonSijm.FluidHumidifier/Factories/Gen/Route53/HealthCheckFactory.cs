// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class HealthCheckFactory(string resourceName = null, Action<Humidifier.Route53.HealthCheck> factoryAction = null) : ResourceFactory<Humidifier.Route53.HealthCheck>(resourceName)
{

    internal List<InnerHealthCheckHealthCheckTagFactory> HealthCheckTagsFactories { get; set; } = [];

    internal InnerHealthCheckHealthCheckConfigFactory HealthCheckConfigFactory { get; set; }

    protected override Humidifier.Route53.HealthCheck Create()
    {
        var healthCheckResult = CreateHealthCheck();
        factoryAction?.Invoke(healthCheckResult);

        return healthCheckResult;
    }

    private Humidifier.Route53.HealthCheck CreateHealthCheck()
    {
        var healthCheckResult = new Humidifier.Route53.HealthCheck
        {
            GivenName = InputResourceName,
        };

        return healthCheckResult;
    }
    public override void CreateChildren(Humidifier.Route53.HealthCheck result)
    {
        base.CreateChildren(result);

        result.HealthCheckTags = HealthCheckTagsFactories.Any() ? HealthCheckTagsFactories.Select(x => x.Build()).ToList() : null;
        result.HealthCheckConfig ??= HealthCheckConfigFactory?.Build();
    }

} // End Of Class

public static class HealthCheckFactoryExtensions
{
    public static CombinedResult<HealthCheckFactory, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags(this HealthCheckFactory parentFactory, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null)
    {
        var factory = new InnerHealthCheckHealthCheckTagFactory(subFactoryAction);
        parentFactory.HealthCheckTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<HealthCheckFactory, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig(this HealthCheckFactory parentFactory, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null)
    {
        parentFactory.HealthCheckConfigFactory = new InnerHealthCheckHealthCheckConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckConfigFactory);
    }

    public static CombinedResult<HealthCheckFactory, T1, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1>(this CombinedResult<HealthCheckFactory, T1> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1>(this CombinedResult<T1, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, T2, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2>(this CombinedResult<HealthCheckFactory, T1, T2> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, T2, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2>(this CombinedResult<T1, HealthCheckFactory, T2> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HealthCheckFactory, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2>(this CombinedResult<T1, T2, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, T2, T3, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3>(this CombinedResult<HealthCheckFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, T2, T3, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3>(this CombinedResult<T1, HealthCheckFactory, T2, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HealthCheckFactory, T3, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3>(this CombinedResult<T1, T2, HealthCheckFactory, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HealthCheckFactory, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, T2, T3, T4, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3, T4>(this CombinedResult<HealthCheckFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, T2, T3, T4, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3, T4>(this CombinedResult<T1, HealthCheckFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HealthCheckFactory, T3, T4, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, HealthCheckFactory, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HealthCheckFactory, T4, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HealthCheckFactory, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, HealthCheckFactory, InnerHealthCheckHealthCheckTagFactory> WithHealthCheckTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<HealthCheckFactory, T1> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<T1, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, T2, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<HealthCheckFactory, T1, T2> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, T2, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, HealthCheckFactory, T2> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HealthCheckFactory, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, T2, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, T2, T3, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<HealthCheckFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, T2, T3, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, HealthCheckFactory, T2, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HealthCheckFactory, T3, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, HealthCheckFactory, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HealthCheckFactory, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<HealthCheckFactory, T1, T2, T3, T4, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<HealthCheckFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HealthCheckFactory, T2, T3, T4, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, HealthCheckFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HealthCheckFactory, T3, T4, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, HealthCheckFactory, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HealthCheckFactory, T4, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HealthCheckFactory, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, HealthCheckFactory, InnerHealthCheckHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HealthCheckFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T5, subFactoryAction));
}
