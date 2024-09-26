// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerLoggerDefinitionLoggerDefinitionVersionFactory(Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion>
{

    internal List<InnerLoggerDefinitionLoggerFactory> LoggersFactories { get; set; } = [];

    protected override Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion Create()
    {
        var loggerDefinitionVersionResult = CreateLoggerDefinitionVersion();
        factoryAction?.Invoke(loggerDefinitionVersionResult);

        return loggerDefinitionVersionResult;
    }

    private Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion CreateLoggerDefinitionVersion()
    {
        var loggerDefinitionVersionResult = new Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion();

        return loggerDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Loggers = LoggersFactories.Any() ? LoggersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerLoggerDefinitionLoggerDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, InnerLoggerDefinitionLoggerFactory> WithLoggers(this InnerLoggerDefinitionLoggerDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null)
    {
        var factory = new InnerLoggerDefinitionLoggerFactory(subFactoryAction);
        parentFactory.LoggersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1>(this CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1>(this CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, T2, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2>(this CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T2, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2>(this CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2>(this CombinedResult<T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, T2, T3, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T2, T3, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T3, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, T2, T3, T4, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<InnerLoggerDefinitionLoggerDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T2, T3, T4, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T3, T4, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T4, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLoggerDefinitionLoggerDefinitionVersionFactory, InnerLoggerDefinitionLoggerFactory> WithLoggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLoggerDefinitionLoggerDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.Logger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggers(combinedResult.T5, subFactoryAction));
}
