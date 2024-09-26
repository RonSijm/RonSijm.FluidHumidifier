// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorApacheKafkaClusterFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster>
{

    internal InnerConnectorVpcFactory VpcFactory { get; set; }

    protected override Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster Create()
    {
        var apacheKafkaClusterResult = CreateApacheKafkaCluster();
        factoryAction?.Invoke(apacheKafkaClusterResult);

        return apacheKafkaClusterResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster CreateApacheKafkaCluster()
    {
        var apacheKafkaClusterResult = new Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster();

        return apacheKafkaClusterResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster result)
    {
        base.CreateChildren(result);

        result.Vpc ??= VpcFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorApacheKafkaClusterFactoryExtensions
{
    public static CombinedResult<InnerConnectorApacheKafkaClusterFactory, InnerConnectorVpcFactory> WithVpc(this InnerConnectorApacheKafkaClusterFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null)
    {
        parentFactory.VpcFactory = new InnerConnectorVpcFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcFactory);
    }

    public static CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, InnerConnectorVpcFactory> WithVpc<T1>(this CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, InnerConnectorVpcFactory> WithVpc<T1>(this CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, T2, InnerConnectorVpcFactory> WithVpc<T1, T2>(this CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, T2, InnerConnectorVpcFactory> WithVpc<T1, T2>(this CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorApacheKafkaClusterFactory, InnerConnectorVpcFactory> WithVpc<T1, T2>(this CombinedResult<T1, T2, InnerConnectorApacheKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, T2, T3, InnerConnectorVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, T2, T3, InnerConnectorVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorApacheKafkaClusterFactory, T3, InnerConnectorVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorApacheKafkaClusterFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorApacheKafkaClusterFactory, InnerConnectorVpcFactory> WithVpc<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorApacheKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, T2, T3, T4, InnerConnectorVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<InnerConnectorApacheKafkaClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, T2, T3, T4, InnerConnectorVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorApacheKafkaClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorApacheKafkaClusterFactory, T3, T4, InnerConnectorVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorApacheKafkaClusterFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorApacheKafkaClusterFactory, T4, InnerConnectorVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorApacheKafkaClusterFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorApacheKafkaClusterFactory, InnerConnectorVpcFactory> WithVpc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorApacheKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.Vpc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpc(combinedResult.T5, subFactoryAction));
}
