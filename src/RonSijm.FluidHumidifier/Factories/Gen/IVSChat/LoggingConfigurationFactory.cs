// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVSChat;

public class LoggingConfigurationFactory(string resourceName = null, Action<Humidifier.IVSChat.LoggingConfiguration> factoryAction = null) : ResourceFactory<Humidifier.IVSChat.LoggingConfiguration>(resourceName)
{

    internal InnerLoggingConfigurationDestinationConfigurationFactory DestinationConfigurationFactory { get; set; }

    protected override Humidifier.IVSChat.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.IVSChat.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.IVSChat.LoggingConfiguration
        {
            GivenName = InputResourceName,
        };

        return loggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IVSChat.LoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.DestinationConfiguration ??= DestinationConfigurationFactory?.Build();
    }

} // End Of Class

public static class LoggingConfigurationFactoryExtensions
{
    public static CombinedResult<LoggingConfigurationFactory, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration(this LoggingConfigurationFactory parentFactory, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationConfigurationFactory = new InnerLoggingConfigurationDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigurationFactory);
    }

    public static CombinedResult<LoggingConfigurationFactory, T1, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<LoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<T1, LoggingConfigurationFactory> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<LoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, LoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, T2, LoggingConfigurationFactory> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<LoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, LoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, LoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory, InnerLoggingConfigurationDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LoggingConfigurationFactory> combinedResult, Action<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T5, subFactoryAction));
}
