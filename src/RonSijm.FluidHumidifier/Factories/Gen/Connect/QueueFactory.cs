// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class QueueFactory(string resourceName = null, Action<Humidifier.Connect.Queue> factoryAction = null) : ResourceFactory<Humidifier.Connect.Queue>(resourceName)
{

    internal InnerQueueOutboundCallerConfigFactory OutboundCallerConfigFactory { get; set; }

    protected override Humidifier.Connect.Queue Create()
    {
        var queueResult = CreateQueue();
        factoryAction?.Invoke(queueResult);

        return queueResult;
    }

    private Humidifier.Connect.Queue CreateQueue()
    {
        var queueResult = new Humidifier.Connect.Queue
        {
            GivenName = InputResourceName,
        };

        return queueResult;
    }
    public override void CreateChildren(Humidifier.Connect.Queue result)
    {
        base.CreateChildren(result);

        result.OutboundCallerConfig ??= OutboundCallerConfigFactory?.Build();
    }

} // End Of Class

public static class QueueFactoryExtensions
{
    public static CombinedResult<QueueFactory, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig(this QueueFactory parentFactory, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null)
    {
        parentFactory.OutboundCallerConfigFactory = new InnerQueueOutboundCallerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutboundCallerConfigFactory);
    }

    public static CombinedResult<QueueFactory, T1, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1>(this CombinedResult<QueueFactory, T1> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1>(this CombinedResult<T1, QueueFactory> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2>(this CombinedResult<QueueFactory, T1, T2> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2>(this CombinedResult<T1, QueueFactory, T2> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2>(this CombinedResult<T1, T2, QueueFactory> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3>(this CombinedResult<QueueFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3>(this CombinedResult<T1, QueueFactory, T2, T3> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3>(this CombinedResult<T1, T2, QueueFactory, T3> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, QueueFactory> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<QueueFactory, T1, T2, T3, T4, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3, T4>(this CombinedResult<QueueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, QueueFactory, T2, T3, T4, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3, T4>(this CombinedResult<T1, QueueFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, QueueFactory, T3, T4, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, QueueFactory, T3, T4> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, QueueFactory, T4, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, QueueFactory, T4> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, QueueFactory, InnerQueueOutboundCallerConfigFactory> WithOutboundCallerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, QueueFactory> combinedResult, Action<Humidifier.Connect.QueueTypes.OutboundCallerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutboundCallerConfig(combinedResult.T5, subFactoryAction));
}
