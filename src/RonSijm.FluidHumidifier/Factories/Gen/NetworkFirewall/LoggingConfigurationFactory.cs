// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class LoggingConfigurationFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.LoggingConfiguration> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.LoggingConfiguration>(resourceName)
{

    internal InnerLoggingConfigurationLoggingConfigurationFactory LoggingConfiguration_Factory { get; set; }

    protected override Humidifier.NetworkFirewall.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.NetworkFirewall.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.NetworkFirewall.LoggingConfiguration
        {
            GivenName = InputResourceName,
        };

        return loggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.LoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.LoggingConfiguration_ ??= LoggingConfiguration_Factory?.Build();
    }

} // End Of Class

public static class LoggingConfigurationFactoryExtensions
{
    public static CombinedResult<LoggingConfigurationFactory, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_(this LoggingConfigurationFactory parentFactory, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null)
    {
        parentFactory.LoggingConfiguration_Factory = new InnerLoggingConfigurationLoggingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfiguration_Factory);
    }

    public static CombinedResult<LoggingConfigurationFactory, T1, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1>(this CombinedResult<LoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1>(this CombinedResult<T1, LoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2>(this CombinedResult<LoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2>(this CombinedResult<T1, LoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2>(this CombinedResult<T1, T2, LoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3, T4>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory, InnerLoggingConfigurationLoggingConfigurationFactory> WithLoggingConfiguration_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory> combinedResult, Action<Humidifier.NetworkFirewall.LoggingConfigurationTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration_(combinedResult.T5, subFactoryAction));
}
