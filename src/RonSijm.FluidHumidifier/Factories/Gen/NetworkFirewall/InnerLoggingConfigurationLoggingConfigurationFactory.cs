// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerLoggingConfigurationLoggingConfigurationFactory(Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration>
{

    internal List<InnerLoggingConfigurationLogDestinationConfigFactory> LogDestinationConfigsFactories { get; set; } = [];

    protected override Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration();

        return loggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.LogDestinationConfigs = LogDestinationConfigsFactories.Any() ? LogDestinationConfigsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerLoggingConfigurationLoggingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs(this InnerLoggingConfigurationLoggingConfigurationFactory parentFactory, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null)
    {
        var factory = new InnerLoggingConfigurationLogDestinationConfigFactory(subFactoryAction);
        parentFactory.LogDestinationConfigsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1>(this CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1>(this CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, T2, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2>(this CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, T2, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2>(this CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2>(this CombinedResult<T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, T2, T3, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3>(this CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, T2, T3, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3>(this CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory, T3, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3>(this CombinedResult<T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLoggingConfigurationLoggingConfigurationFactory, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLoggingConfigurationLoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, T2, T3, T4, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3, T4>(this CombinedResult<InnerLoggingConfigurationLoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, T2, T3, T4, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3, T4>(this CombinedResult<T1, InnerLoggingConfigurationLoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory, T3, T4, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLoggingConfigurationLoggingConfigurationFactory, T4, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLoggingConfigurationLoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLoggingConfigurationLoggingConfigurationFactory, InnerLoggingConfigurationLogDestinationConfigFactory> WithLogDestinationConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLoggingConfigurationLoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LogDestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogDestinationConfigs(combinedResult.T5, subFactoryAction));
}
