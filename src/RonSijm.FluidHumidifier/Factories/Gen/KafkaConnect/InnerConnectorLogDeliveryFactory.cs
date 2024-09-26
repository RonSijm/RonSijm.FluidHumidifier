// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorLogDeliveryFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.LogDelivery> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.LogDelivery>
{

    internal InnerConnectorWorkerLogDeliveryFactory WorkerLogDeliveryFactory { get; set; }

    protected override Humidifier.KafkaConnect.ConnectorTypes.LogDelivery Create()
    {
        var logDeliveryResult = CreateLogDelivery();
        factoryAction?.Invoke(logDeliveryResult);

        return logDeliveryResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.LogDelivery CreateLogDelivery()
    {
        var logDeliveryResult = new Humidifier.KafkaConnect.ConnectorTypes.LogDelivery();

        return logDeliveryResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.ConnectorTypes.LogDelivery result)
    {
        base.CreateChildren(result);

        result.WorkerLogDelivery ??= WorkerLogDeliveryFactory?.Build();
    }

} // End Of Class

public static class InnerConnectorLogDeliveryFactoryExtensions
{
    public static CombinedResult<InnerConnectorLogDeliveryFactory, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery(this InnerConnectorLogDeliveryFactory parentFactory, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null)
    {
        parentFactory.WorkerLogDeliveryFactory = new InnerConnectorWorkerLogDeliveryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WorkerLogDeliveryFactory);
    }

    public static CombinedResult<InnerConnectorLogDeliveryFactory, T1, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1>(this CombinedResult<InnerConnectorLogDeliveryFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorLogDeliveryFactory, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1>(this CombinedResult<T1, InnerConnectorLogDeliveryFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConnectorLogDeliveryFactory, T1, T2, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2>(this CombinedResult<InnerConnectorLogDeliveryFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorLogDeliveryFactory, T2, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2>(this CombinedResult<T1, InnerConnectorLogDeliveryFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorLogDeliveryFactory, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2>(this CombinedResult<T1, T2, InnerConnectorLogDeliveryFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConnectorLogDeliveryFactory, T1, T2, T3, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3>(this CombinedResult<InnerConnectorLogDeliveryFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorLogDeliveryFactory, T2, T3, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3>(this CombinedResult<T1, InnerConnectorLogDeliveryFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorLogDeliveryFactory, T3, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectorLogDeliveryFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorLogDeliveryFactory, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectorLogDeliveryFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConnectorLogDeliveryFactory, T1, T2, T3, T4, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3, T4>(this CombinedResult<InnerConnectorLogDeliveryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConnectorLogDeliveryFactory, T2, T3, T4, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectorLogDeliveryFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConnectorLogDeliveryFactory, T3, T4, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectorLogDeliveryFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConnectorLogDeliveryFactory, T4, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectorLogDeliveryFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConnectorLogDeliveryFactory, InnerConnectorWorkerLogDeliveryFactory> WithWorkerLogDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectorLogDeliveryFactory> combinedResult, Action<Humidifier.KafkaConnect.ConnectorTypes.WorkerLogDelivery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerLogDelivery(combinedResult.T5, subFactoryAction));
}
