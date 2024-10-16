// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAA;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.MWAA.Environment> factoryAction = null) : ResourceFactory<Humidifier.MWAA.Environment>(resourceName)
{

    internal InnerEnvironmentLoggingConfigurationFactory LoggingConfigurationFactory { get; set; }

    internal InnerEnvironmentNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    protected override Humidifier.MWAA.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.MWAA.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.MWAA.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.MWAA.Environment result)
    {
        base.CreateChildren(result);

        result.LoggingConfiguration ??= LoggingConfigurationFactory?.Build();
        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration(this EnvironmentFactory parentFactory, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null)
    {
        parentFactory.LoggingConfigurationFactory = new InnerEnvironmentLoggingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigurationFactory);
    }

    public static CombinedResult<EnvironmentFactory, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration(this EnvironmentFactory parentFactory, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerEnvironmentNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentLoggingConfigurationFactory> WithLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.LoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.MWAA.EnvironmentTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction));
}
