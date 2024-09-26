// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaCluster> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaCluster>
{

    internal InnerReplicatorKafkaClusterClientVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerReplicatorAmazonMskClusterFactory AmazonMskClusterFactory { get; set; }

    protected override Humidifier.MSK.ReplicatorTypes.KafkaCluster Create()
    {
        var kafkaClusterResult = CreateKafkaCluster();
        factoryAction?.Invoke(kafkaClusterResult);

        return kafkaClusterResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaCluster CreateKafkaCluster()
    {
        var kafkaClusterResult = new Humidifier.MSK.ReplicatorTypes.KafkaCluster();

        return kafkaClusterResult;
    }
    public override void CreateChildren(Humidifier.MSK.ReplicatorTypes.KafkaCluster result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.AmazonMskCluster ??= AmazonMskClusterFactory?.Build();
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterFactoryExtensions
{
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig(this InnerReplicatorKafkaClusterFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerReplicatorKafkaClusterClientVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerReplicatorKafkaClusterFactory, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster(this InnerReplicatorKafkaClusterFactory parentFactory, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null)
    {
        parentFactory.AmazonMskClusterFactory = new InnerReplicatorAmazonMskClusterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AmazonMskClusterFactory);
    }

    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3, T4, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3, T4, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3, T4, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory, T4, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicatorKafkaClusterFactory, InnerReplicatorKafkaClusterClientVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2>(this CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3>(this CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3, T4, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3, T4>(this CombinedResult<InnerReplicatorKafkaClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3, T4, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3, T4>(this CombinedResult<T1, InnerReplicatorKafkaClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3, T4, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerReplicatorKafkaClusterFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory, T4, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerReplicatorKafkaClusterFactory, T4> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerReplicatorKafkaClusterFactory, InnerReplicatorAmazonMskClusterFactory> WithAmazonMskCluster<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerReplicatorKafkaClusterFactory> combinedResult, Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAmazonMskCluster(combinedResult.T5, subFactoryAction));
}
