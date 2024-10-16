// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorSCEP;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.PCAConnectorSCEP.Connector> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorSCEP.Connector>(resourceName)
{

    internal InnerConnectorMobileDeviceManagementFactory MobileDeviceManagementFactory { get; set; }

    protected override Humidifier.PCAConnectorSCEP.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.PCAConnectorSCEP.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.PCAConnectorSCEP.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorSCEP.Connector result)
    {
        base.CreateChildren(result);

        result.MobileDeviceManagement ??= MobileDeviceManagementFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement(this ConnectorFactory parentFactory, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null)
    {
        parentFactory.MobileDeviceManagementFactory = new InnerConnectorMobileDeviceManagementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MobileDeviceManagementFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorMobileDeviceManagementFactory> WithMobileDeviceManagement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMobileDeviceManagement(combinedResult.T5, subFactoryAction));
}
