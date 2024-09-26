// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class LoggerDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.LoggerDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.LoggerDefinition>(resourceName)
{

    internal InnerLoggerDefinitionLoggerDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.LoggerDefinition Create()
    {
        var loggerDefinitionResult = CreateLoggerDefinition();
        factoryAction?.Invoke(loggerDefinitionResult);

        return loggerDefinitionResult;
    }

    private Humidifier.Greengrass.LoggerDefinition CreateLoggerDefinition()
    {
        var loggerDefinitionResult = new Humidifier.Greengrass.LoggerDefinition
        {
            GivenName = InputResourceName,
        };

        return loggerDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.LoggerDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class LoggerDefinitionFactoryExtensions
{
    public static CombinedResult<LoggerDefinitionFactory, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion(this LoggerDefinitionFactory parentFactory, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerLoggerDefinitionLoggerDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<LoggerDefinitionFactory, T1, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<LoggerDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionFactory, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, LoggerDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoggerDefinitionFactory, T1, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<LoggerDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionFactory, T2, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, LoggerDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggerDefinitionFactory, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, LoggerDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoggerDefinitionFactory, T1, T2, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<LoggerDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionFactory, T2, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, LoggerDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggerDefinitionFactory, T3, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, LoggerDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggerDefinitionFactory, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggerDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoggerDefinitionFactory, T1, T2, T3, T4, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<LoggerDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggerDefinitionFactory, T2, T3, T4, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, LoggerDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggerDefinitionFactory, T3, T4, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggerDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggerDefinitionFactory, T4, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggerDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoggerDefinitionFactory, InnerLoggerDefinitionLoggerDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggerDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.LoggerDefinitionTypes.LoggerDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
