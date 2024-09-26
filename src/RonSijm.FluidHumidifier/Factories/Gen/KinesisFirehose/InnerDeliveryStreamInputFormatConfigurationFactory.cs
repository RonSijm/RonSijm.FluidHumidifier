// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamInputFormatConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.InputFormatConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.InputFormatConfiguration>
{

    internal InnerDeliveryStreamDeserializerFactory DeserializerFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.InputFormatConfiguration Create()
    {
        var inputFormatConfigurationResult = CreateInputFormatConfiguration();
        factoryAction?.Invoke(inputFormatConfigurationResult);

        return inputFormatConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.InputFormatConfiguration CreateInputFormatConfiguration()
    {
        var inputFormatConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.InputFormatConfiguration();

        return inputFormatConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.InputFormatConfiguration result)
    {
        base.CreateChildren(result);

        result.Deserializer ??= DeserializerFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamInputFormatConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, InnerDeliveryStreamDeserializerFactory> WithDeserializer(this InnerDeliveryStreamInputFormatConfigurationFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null)
    {
        parentFactory.DeserializerFactory = new InnerDeliveryStreamDeserializerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeserializerFactory);
    }

    public static CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1>(this CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeserializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1>(this CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeserializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, T2, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2>(this CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, T2, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamInputFormatConfigurationFactory, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamInputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, T2, T3, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, T2, T3, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamInputFormatConfigurationFactory, T3, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamInputFormatConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamInputFormatConfigurationFactory, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamInputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, T2, T3, T4, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamInputFormatConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, T2, T3, T4, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamInputFormatConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamInputFormatConfigurationFactory, T3, T4, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamInputFormatConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamInputFormatConfigurationFactory, T4, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamInputFormatConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamInputFormatConfigurationFactory, InnerDeliveryStreamDeserializerFactory> WithDeserializer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamInputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeserializer(combinedResult.T5, subFactoryAction));
}
