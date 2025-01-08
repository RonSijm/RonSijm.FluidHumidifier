// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class QueueFactory(string resourceName = null, Action<Humidifier.PCS.Queue> factoryAction = null) : ResourceFactory<Humidifier.PCS.Queue>(resourceName)
{

    internal List<InnerQueueComputeNodeGroupConfigurationFactory> ComputeNodeGroupConfigurationsFactories { get; set; } = [];

    protected override Humidifier.PCS.Queue Create()
    {
        var queueResult = CreateQueue();
        factoryAction?.Invoke(queueResult);

        return queueResult;
    }

    private Humidifier.PCS.Queue CreateQueue()
    {
        var queueResult = new Humidifier.PCS.Queue
        {
            GivenName = InputResourceName,
        };

        return queueResult;
    }
    public override void CreateChildren(Humidifier.PCS.Queue result)
    {
        base.CreateChildren(result);

        result.ComputeNodeGroupConfigurations = ComputeNodeGroupConfigurationsFactories.Any() ? ComputeNodeGroupConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class QueueFactoryExtensions
{
    public static CombinedResult<QueueFactory, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations(this QueueFactory parentFactory, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null)
    {
        var factory = new InnerQueueComputeNodeGroupConfigurationFactory(subFactoryAction);
        parentFactory.ComputeNodeGroupConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<QueueFactory, T1, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1>(this CombinedResult<QueueFactory, T1> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1>(this CombinedResult<T1, QueueFactory> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2>(this CombinedResult<QueueFactory, T1, T2> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2>(this CombinedResult<T1, QueueFactory, T2> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2>(this CombinedResult<T1, T2, QueueFactory> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3>(this CombinedResult<QueueFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3>(this CombinedResult<T1, QueueFactory, T2, T3> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, QueueFactory, T3> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, QueueFactory> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, T4, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<QueueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, T4, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, QueueFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, T4, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, QueueFactory, T3, T4> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, T4, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QueueFactory, T4> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, QueueFactory, InnerQueueComputeNodeGroupConfigurationFactory> WithComputeNodeGroupConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QueueFactory> combinedResult, Action<Humidifier.PCS.QueueTypes.ComputeNodeGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeNodeGroupConfigurations(combinedResult.T5, subFactoryAction));
}
