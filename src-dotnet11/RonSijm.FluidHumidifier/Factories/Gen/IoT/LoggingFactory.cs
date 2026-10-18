// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class LoggingFactory(string resourceName = null, Action<Humidifier.IoT.Logging> factoryAction = null) : ResourceFactory<Humidifier.IoT.Logging>(resourceName)
{

    internal List<InnerLoggingEventConfigurationFactory> EventConfigurationsFactories { get; set; } = [];

    protected override Humidifier.IoT.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.IoT.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.IoT.Logging
        {
            GivenName = InputResourceName,
        };

        return loggingResult;
    }
    public override void CreateChildren(Humidifier.IoT.Logging result)
    {
        base.CreateChildren(result);

        result.EventConfigurations = EventConfigurationsFactories.Any() ? EventConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LoggingFactoryExtensions
{
    public static CombinedResult<LoggingFactory, InnerLoggingEventConfigurationFactory> WithEventConfigurations(this LoggingFactory parentFactory, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null)
    {
        var factory = new InnerLoggingEventConfigurationFactory(subFactoryAction);
        parentFactory.EventConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LoggingFactory, T1, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1>(this CombinedResult<LoggingFactory, T1> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LoggingFactory, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1>(this CombinedResult<T1, LoggingFactory> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LoggingFactory, T1, T2, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2>(this CombinedResult<LoggingFactory, T1, T2> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LoggingFactory, T2, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2>(this CombinedResult<T1, LoggingFactory, T2> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LoggingFactory, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2>(this CombinedResult<T1, T2, LoggingFactory> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LoggingFactory, T1, T2, T3, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3>(this CombinedResult<LoggingFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LoggingFactory, T2, T3, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3>(this CombinedResult<T1, LoggingFactory, T2, T3> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LoggingFactory, T3, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, LoggingFactory, T3> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LoggingFactory, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggingFactory> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LoggingFactory, T1, T2, T3, T4, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3, T4>(this CombinedResult<LoggingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LoggingFactory, T2, T3, T4, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, LoggingFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LoggingFactory, T3, T4, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggingFactory, T3, T4> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LoggingFactory, T4, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggingFactory, T4> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LoggingFactory, InnerLoggingEventConfigurationFactory> WithEventConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggingFactory> combinedResult, Action<Humidifier.IoT.LoggingTypes.EventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfigurations(combinedResult.T5, subFactoryAction).T2);
}
