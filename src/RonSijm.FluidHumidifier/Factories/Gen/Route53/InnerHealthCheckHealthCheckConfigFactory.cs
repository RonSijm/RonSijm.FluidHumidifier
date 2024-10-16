// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHealthCheckHealthCheckConfigFactory(Action<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HealthCheckTypes.HealthCheckConfig>
{

    internal InnerHealthCheckAlarmIdentifierFactory AlarmIdentifierFactory { get; set; }

    protected override Humidifier.Route53.HealthCheckTypes.HealthCheckConfig Create()
    {
        var healthCheckConfigResult = CreateHealthCheckConfig();
        factoryAction?.Invoke(healthCheckConfigResult);

        return healthCheckConfigResult;
    }

    private Humidifier.Route53.HealthCheckTypes.HealthCheckConfig CreateHealthCheckConfig()
    {
        var healthCheckConfigResult = new Humidifier.Route53.HealthCheckTypes.HealthCheckConfig();

        return healthCheckConfigResult;
    }
    public override void CreateChildren(Humidifier.Route53.HealthCheckTypes.HealthCheckConfig result)
    {
        base.CreateChildren(result);

        result.AlarmIdentifier ??= AlarmIdentifierFactory?.Build();
    }

} // End Of Class

public static class InnerHealthCheckHealthCheckConfigFactoryExtensions
{
    public static CombinedResult<InnerHealthCheckHealthCheckConfigFactory, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier(this InnerHealthCheckHealthCheckConfigFactory parentFactory, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null)
    {
        parentFactory.AlarmIdentifierFactory = new InnerHealthCheckAlarmIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmIdentifierFactory);
    }

    public static CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1>(this CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1>(this CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, T2, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2>(this CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, T2> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, T2, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2>(this CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, T2> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHealthCheckHealthCheckConfigFactory, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2>(this CombinedResult<T1, T2, InnerHealthCheckHealthCheckConfigFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, T2, T3, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3>(this CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, T2, T3, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3>(this CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, T2, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHealthCheckHealthCheckConfigFactory, T3, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3>(this CombinedResult<T1, T2, InnerHealthCheckHealthCheckConfigFactory, T3> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerHealthCheckHealthCheckConfigFactory, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHealthCheckHealthCheckConfigFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, T2, T3, T4, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3, T4>(this CombinedResult<InnerHealthCheckHealthCheckConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, T2, T3, T4, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, InnerHealthCheckHealthCheckConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerHealthCheckHealthCheckConfigFactory, T3, T4, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHealthCheckHealthCheckConfigFactory, T3, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerHealthCheckHealthCheckConfigFactory, T4, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHealthCheckHealthCheckConfigFactory, T4> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerHealthCheckHealthCheckConfigFactory, InnerHealthCheckAlarmIdentifierFactory> WithAlarmIdentifier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHealthCheckHealthCheckConfigFactory> combinedResult, Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarmIdentifier(combinedResult.T5, subFactoryAction));
}
