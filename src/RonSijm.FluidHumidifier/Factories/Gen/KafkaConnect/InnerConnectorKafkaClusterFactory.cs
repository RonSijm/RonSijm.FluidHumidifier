// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorKafkaClusterFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster>
{

    internal InnerConnectorApacheKafkaClusterFactory ApacheKafkaClusterFactory { get; set; }

    protected override Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster Create()
    {
        var kafkaClusterResult = CreateKafkaCluster();
        factoryAction?.Invoke(kafkaClusterResult);

        return kafkaClusterResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster CreateKafkaCluster()
    {
        var kafkaClusterResult = new Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster();

        return kafkaClusterResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.ConnectorTypes.KafkaCluster result)
    {
        base.CreateChildren(result);

        result.ApacheKafkaCluster ??= ApacheKafkaClusterFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorKafkaClusterFactoryExtensions
{
    public static CombinedResult<InnerConnectorKafkaClusterFactory, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster(this InnerConnectorKafkaClusterFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null)
    {
        parentFactory.ApacheKafkaClusterFactory = new InnerConnectorApacheKafkaClusterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApacheKafkaClusterFactory);
    }

    public static CombinedResult<InnerConnectorKafkaClusterFactory, T1, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1>(this CombinedResult<InnerConnectorKafkaClusterFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorKafkaClusterFactory, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1>(this CombinedResult<T1, InnerConnectorKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorKafkaClusterFactory, T1, T2, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2>(this CombinedResult<InnerConnectorKafkaClusterFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorKafkaClusterFactory, T2, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2>(this CombinedResult<T1, InnerConnectorKafkaClusterFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorKafkaClusterFactory, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2>(this CombinedResult<T1, T2, InnerConnectorKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorKafkaClusterFactory, T1, T2, T3, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3>(this CombinedResult<InnerConnectorKafkaClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorKafkaClusterFactory, T2, T3, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3>(this CombinedResult<T1, InnerConnectorKafkaClusterFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorKafkaClusterFactory, T3, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorKafkaClusterFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorKafkaClusterFactory, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorKafkaClusterFactory, T1, T2, T3, T4, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3, T4>(this CombinedResult<InnerConnectorKafkaClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorKafkaClusterFactory, T2, T3, T4, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorKafkaClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorKafkaClusterFactory, T3, T4, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorKafkaClusterFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorKafkaClusterFactory, T4, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorKafkaClusterFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorKafkaClusterFactory, InnerConnectorApacheKafkaClusterFactory> WithApacheKafkaCluster<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorKafkaClusterFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.ApacheKafkaCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApacheKafkaCluster(combinedResult.T5, subFactoryAction));
}
