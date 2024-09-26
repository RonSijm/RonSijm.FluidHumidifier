// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class LoggerDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.LoggerDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.LoggerDefinitionVersion>(resourceName)
{

    internal List<InnerLoggerDefinitionVersionLoggerFactory> LoggersFactories { get; set; } = [];

    protected override Humidifier.Greengrass.LoggerDefinitionVersion Create()
    {
        var loggerDefinitionVersionResult = CreateLoggerDefinitionVersion();
        factoryAction?.Invoke(loggerDefinitionVersionResult);

        return loggerDefinitionVersionResult;
    }

    private Humidifier.Greengrass.LoggerDefinitionVersion CreateLoggerDefinitionVersion()
    {
        var loggerDefinitionVersionResult = new Humidifier.Greengrass.LoggerDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return loggerDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.LoggerDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Loggers = LoggersFactories.Any() ? LoggersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LoggerDefinitionVersionFactoryExtensions
{
    public static CombinedResult<LoggerDefinitionVersionFactory, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers(this LoggerDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null)
    {
        var factory = new InnerLoggerDefinitionVersionLoggerFactory(subFactoryAction);
        parentFactory.LoggersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LoggerDefinitionVersionFactory, T1, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1>(this CombinedResult<LoggerDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionVersionFactory, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1>(this CombinedResult<T1, LoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoggerDefinitionVersionFactory, T1, T2, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2>(this CombinedResult<LoggerDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionVersionFactory, T2, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2>(this CombinedResult<T1, LoggerDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggerDefinitionVersionFactory, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2>(this CombinedResult<T1, T2, LoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoggerDefinitionVersionFactory, T1, T2, T3, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<LoggerDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionVersionFactory, T2, T3, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<T1, LoggerDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggerDefinitionVersionFactory, T3, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<T1, T2, LoggerDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggerDefinitionVersionFactory, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoggerDefinitionVersionFactory, T1, T2, T3, T4, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<LoggerDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionVersionFactory, T2, T3, T4, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, LoggerDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggerDefinitionVersionFactory, T3, T4, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggerDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggerDefinitionVersionFactory, T4, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggerDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoggerDefinitionVersionFactory, InnerLoggerDefinitionVersionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionVersionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T5, subFactoryAction));
}
