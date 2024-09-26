// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSerializerFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer>
{

    internal InnerDeliveryStreamOrcSerDeFactory OrcSerDeFactory { get; set; }

    internal InnerDeliveryStreamParquetSerDeFactory ParquetSerDeFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer Create()
    {
        var serializerResult = CreateSerializer();
        factoryAction?.Invoke(serializerResult);

        return serializerResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer CreateSerializer()
    {
        var serializerResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer();

        return serializerResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer result)
    {
        base.CreateChildren(result);

        result.OrcSerDe ??= OrcSerDeFactory?.Build();
        result.ParquetSerDe ??= ParquetSerDeFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamSerializerFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe(this InnerDeliveryStreamSerializerFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null)
    {
        parentFactory.OrcSerDeFactory = new InnerDeliveryStreamOrcSerDeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OrcSerDeFactory);
    }

    public static CombinedResult<InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe(this InnerDeliveryStreamSerializerFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null)
    {
        parentFactory.ParquetSerDeFactory = new InnerDeliveryStreamParquetSerDeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParquetSerDeFactory);
    }

    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithOrcSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithOrcSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3, T4, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3, T4, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3, T4, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory, T4, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamOrcSerDeFactory> WithOrcSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OrcSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOrcSerDe(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithParquetSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, WithParquetSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3, T4, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamSerializerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3, T4, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamSerializerFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3, T4, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamSerializerFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory, T4, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamSerializerFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamSerializerFactory, InnerDeliveryStreamParquetSerDeFactory> WithParquetSerDe<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamSerializerFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.ParquetSerDe> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParquetSerDe(combinedResult.T5, subFactoryAction));
}
