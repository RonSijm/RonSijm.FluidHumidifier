// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class NetworkConnectorFactory(string resourceName = null, Action<Humidifier.Lambda.NetworkConnector> factoryAction = null) : ResourceFactory<Humidifier.Lambda.NetworkConnector>(resourceName)
{

    internal InnerNetworkConnectorConfigFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Lambda.NetworkConnector Create()
    {
        var networkConnectorResult = CreateNetworkConnector();
        factoryAction?.Invoke(networkConnectorResult);

        return networkConnectorResult;
    }

    private Humidifier.Lambda.NetworkConnector CreateNetworkConnector()
    {
        var networkConnectorResult = new Humidifier.Lambda.NetworkConnector
        {
            GivenName = InputResourceName,
        };

        return networkConnectorResult;
    }
    public override void CreateChildren(Humidifier.Lambda.NetworkConnector result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class NetworkConnectorFactoryExtensions
{
    public static CombinedResult<NetworkConnectorFactory, InnerNetworkConnectorConfigFactory> WithConfiguration(this NetworkConnectorFactory parentFactory, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerNetworkConnectorConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<NetworkConnectorFactory, T1, InnerNetworkConnectorConfigFactory> WithConfiguration<T1>(this CombinedResult<NetworkConnectorFactory, T1> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NetworkConnectorFactory, InnerNetworkConnectorConfigFactory> WithConfiguration<T1>(this CombinedResult<T1, NetworkConnectorFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NetworkConnectorFactory, T1, T2, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2>(this CombinedResult<NetworkConnectorFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NetworkConnectorFactory, T2, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, NetworkConnectorFactory, T2> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NetworkConnectorFactory, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, NetworkConnectorFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NetworkConnectorFactory, T1, T2, T3, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<NetworkConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NetworkConnectorFactory, T2, T3, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, NetworkConnectorFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NetworkConnectorFactory, T3, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, NetworkConnectorFactory, T3> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NetworkConnectorFactory, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkConnectorFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NetworkConnectorFactory, T1, T2, T3, T4, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<NetworkConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NetworkConnectorFactory, T2, T3, T4, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, NetworkConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NetworkConnectorFactory, T3, T4, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkConnectorFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NetworkConnectorFactory, T4, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkConnectorFactory, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NetworkConnectorFactory, InnerNetworkConnectorConfigFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkConnectorFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
