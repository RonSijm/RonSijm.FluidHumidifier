// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDeserializerFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer>
{

    internal InnerDeliveryStreamHiveJsonSerDeFactory HiveJsonSerDeFactory { get; set; }

    internal InnerDeliveryStreamOpenXJsonSerDeFactory OpenXJsonSerDeFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer Create()
    {
        var deserializerResult = CreateDeserializer();
        factoryAction?.Invoke(deserializerResult);

        return deserializerResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer CreateDeserializer()
    {
        var deserializerResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer();

        return deserializerResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.Deserializer result)
    {
        base.CreateChildren(result);

        result.HiveJsonSerDe ??= HiveJsonSerDeFactory?.Build();
        result.OpenXJsonSerDe ??= OpenXJsonSerDeFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamDeserializerFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe(this InnerDeliveryStreamDeserializerFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null)
    {
        parentFactory.HiveJsonSerDeFactory = new InnerDeliveryStreamHiveJsonSerDeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HiveJsonSerDeFactory);
    }

    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe(this InnerDeliveryStreamDeserializerFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null)
    {
        parentFactory.OpenXJsonSerDeFactory = new InnerDeliveryStreamOpenXJsonSerDeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenXJsonSerDeFactory);
    }

    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3, T4, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3, T4, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3, T4, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory, T4, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamHiveJsonSerDeFactory> WithHiveJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.HiveJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHiveJsonSerDe(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3, T4, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamDeserializerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3, T4, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamDeserializerFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3, T4, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamDeserializerFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory, T4, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDeserializerFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDeserializerFactory, InnerDeliveryStreamOpenXJsonSerDeFactory> WithOpenXJsonSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDeserializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OpenXJsonSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenXJsonSerDe(combinedResult.T5, subFactoryAction));
}
