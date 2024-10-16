// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class ConnectorFactory(string resourceName = null, Action<Humidifier.PCAConnectorAD.Connector> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorAD.Connector>(resourceName)
{

    internal InnerConnectorVpcInformationFactory VpcInformationFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.Connector Create()
    {
        var connectorResult = CreateConnector();
        factoryAction?.Invoke(connectorResult);

        return connectorResult;
    }

    private Humidifier.PCAConnectorAD.Connector CreateConnector()
    {
        var connectorResult = new Humidifier.PCAConnectorAD.Connector
        {
            GivenName = InputResourceName,
        };

        return connectorResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.Connector result)
    {
        base.CreateChildren(result);

        result.VpcInformation ??= VpcInformationFactory?.Build();
    }

} // End Of Class

public static class ConnectorFactoryExtensions
{
    public static CombinedResult<ConnectorFactory, InnerConnectorVpcInformationFactory> WithVpcInformation(this ConnectorFactory parentFactory, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null)
    {
        parentFactory.VpcInformationFactory = new InnerConnectorVpcInformationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcInformationFactory);
    }

    public static CombinedResult<ConnectorFactory, T1, InnerConnectorVpcInformationFactory> WithVpcInformation<T1>(this CombinedResult<ConnectorFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcInformation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, InnerConnectorVpcInformationFactory> WithVpcInformation<T1>(this CombinedResult<T1, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcInformation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2>(this CombinedResult<ConnectorFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2>(this CombinedResult<T1, ConnectorFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2>(this CombinedResult<T1, T2, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3>(this CombinedResult<ConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3>(this CombinedResult<T1, ConnectorFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3>(this CombinedResult<T1, T2, ConnectorFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectorFactory, T1, T2, T3, T4, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3, T4>(this CombinedResult<ConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectorFactory, T2, T3, T4, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3, T4>(this CombinedResult<T1, ConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectorFactory, T3, T4, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectorFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectorFactory, T4, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectorFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectorFactory, InnerConnectorVpcInformationFactory> WithVpcInformation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectorFactory> combinedResult, Action<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInformation(combinedResult.T5, subFactoryAction));
}
