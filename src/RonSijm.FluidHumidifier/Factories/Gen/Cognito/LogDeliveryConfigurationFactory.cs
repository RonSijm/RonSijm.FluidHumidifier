// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class LogDeliveryConfigurationFactory(string resourceName = null, Action<Humidifier.Cognito.LogDeliveryConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Cognito.LogDeliveryConfiguration>(resourceName)
{

    internal List<InnerLogDeliveryConfigurationLogConfigurationFactory> LogConfigurationsFactories { get; set; } = [];

    protected override Humidifier.Cognito.LogDeliveryConfiguration Create()
    {
        var logDeliveryConfigurationResult = CreateLogDeliveryConfiguration();
        factoryAction?.Invoke(logDeliveryConfigurationResult);

        return logDeliveryConfigurationResult;
    }

    private Humidifier.Cognito.LogDeliveryConfiguration CreateLogDeliveryConfiguration()
    {
        var logDeliveryConfigurationResult = new Humidifier.Cognito.LogDeliveryConfiguration
        {
            GivenName = InputResourceName,
        };

        return logDeliveryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Cognito.LogDeliveryConfiguration result)
    {
        base.CreateChildren(result);

        result.LogConfigurations = LogConfigurationsFactories.Any() ? LogConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LogDeliveryConfigurationFactoryExtensions
{
    public static CombinedResult<LogDeliveryConfigurationFactory, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations(this LogDeliveryConfigurationFactory parentFactory, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null)
    {
        var factory = new InnerLogDeliveryConfigurationLogConfigurationFactory(subFactoryAction);
        parentFactory.LogConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LogDeliveryConfigurationFactory, T1, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1>(this CombinedResult<LogDeliveryConfigurationFactory, T1> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogDeliveryConfigurationFactory, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1>(this CombinedResult<T1, LogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LogDeliveryConfigurationFactory, T1, T2, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2>(this CombinedResult<LogDeliveryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogDeliveryConfigurationFactory, T2, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2>(this CombinedResult<T1, LogDeliveryConfigurationFactory, T2> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LogDeliveryConfigurationFactory, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2>(this CombinedResult<T1, T2, LogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LogDeliveryConfigurationFactory, T1, T2, T3, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3>(this CombinedResult<LogDeliveryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogDeliveryConfigurationFactory, T2, T3, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3>(this CombinedResult<T1, LogDeliveryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LogDeliveryConfigurationFactory, T3, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, LogDeliveryConfigurationFactory, T3> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LogDeliveryConfigurationFactory, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, LogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LogDeliveryConfigurationFactory, T1, T2, T3, T4, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3, T4>(this CombinedResult<LogDeliveryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogDeliveryConfigurationFactory, T2, T3, T4, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, LogDeliveryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LogDeliveryConfigurationFactory, T3, T4, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, LogDeliveryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LogDeliveryConfigurationFactory, T4, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LogDeliveryConfigurationFactory, T4> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LogDeliveryConfigurationFactory, InnerLogDeliveryConfigurationLogConfigurationFactory> WithLogConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LogDeliveryConfigurationFactory> combinedResult, Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfigurations(combinedResult.T5, subFactoryAction));
}
