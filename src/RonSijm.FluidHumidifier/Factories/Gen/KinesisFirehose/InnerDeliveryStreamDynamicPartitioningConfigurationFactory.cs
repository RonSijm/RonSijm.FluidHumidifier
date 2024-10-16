// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDynamicPartitioningConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DynamicPartitioningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DynamicPartitioningConfiguration>
{

    internal InnerDeliveryStreamRetryOptionsFactory RetryOptionsFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DynamicPartitioningConfiguration Create()
    {
        var dynamicPartitioningConfigurationResult = CreateDynamicPartitioningConfiguration();
        factoryAction?.Invoke(dynamicPartitioningConfigurationResult);

        return dynamicPartitioningConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DynamicPartitioningConfiguration CreateDynamicPartitioningConfiguration()
    {
        var dynamicPartitioningConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DynamicPartitioningConfiguration();

        return dynamicPartitioningConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.DynamicPartitioningConfiguration result)
    {
        base.CreateChildren(result);

        result.RetryOptions ??= RetryOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamDynamicPartitioningConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions(this InnerDeliveryStreamDynamicPartitioningConfigurationFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null)
    {
        parentFactory.RetryOptionsFactory = new InnerDeliveryStreamRetryOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetryOptionsFactory);
    }

    public static CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1>(this CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1>(this CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, T2, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2>(this CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T2, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamDynamicPartitioningConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, T2, T3, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T2, T3, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T3, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDynamicPartitioningConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, T2, T3, T4, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T2, T3, T4, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T3, T4, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T4, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDynamicPartitioningConfigurationFactory, InnerDeliveryStreamRetryOptionsFactory> WithRetryOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDynamicPartitioningConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RetryOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryOptions(combinedResult.T5, subFactoryAction));
}
