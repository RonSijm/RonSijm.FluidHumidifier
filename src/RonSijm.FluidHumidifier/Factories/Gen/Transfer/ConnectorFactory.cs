// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.Transfer.Connector> factoryAction = null) : ResourceFactory<Humidifier.Transfer.Connector>(resourceName)
{

    internal InnerConnectorAs2ConfigFactory As2ConfigFactory { get; set; }

    internal InnerConnectorSftpConfigFactory SftpConfigFactory { get; set; }

    protected override Humidifier.Transfer.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.Transfer.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.Transfer.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.Transfer.Connector result)
    {
        base.CreateChildren(result);

        result.As2Config ??= As2ConfigFactory?.Build();
        result.SftpConfig ??= SftpConfigFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorAs2ConfigFactory> WithAs2Config(this ConnectorFactory parentFactory, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null)
    {
        parentFactory.As2ConfigFactory = new InnerConnectorAs2ConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.As2ConfigFactory);
    }

    public static CombinedResult<ConnectorFactory, InnerConnectorSftpConfigFactory> WithSftpConfig(this ConnectorFactory parentFactory, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null)
    {
        parentFactory.SftpConfigFactory = new InnerConnectorSftpConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SftpConfigFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorAs2ConfigFactory> WithAs2Config<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithAs2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorAs2ConfigFactory> WithAs2Config<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, WithAs2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorAs2ConfigFactory> WithAs2Config<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.As2Config> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAs2Config(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, InnerConnectorSftpConfigFactory> WithSftpConfig<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSftpConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorSftpConfigFactory> WithSftpConfig<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSftpConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorSftpConfigFactory> WithSftpConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSftpConfig(combinedResult.T5, subFactoryAction));
}
