// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamOutputFormatConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.OutputFormatConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.OutputFormatConfiguration>
{

    internal InnerDeliveryStreamSerializerFactory SerializerFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.OutputFormatConfiguration Create()
    {
        var outputFormatConfigurationResult = CreateOutputFormatConfiguration();
        factoryAction?.Invoke(outputFormatConfigurationResult);

        return outputFormatConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.OutputFormatConfiguration CreateOutputFormatConfiguration()
    {
        var outputFormatConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.OutputFormatConfiguration();

        return outputFormatConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.OutputFormatConfiguration result)
    {
        base.CreateChildren(result);

        result.Serializer ??= SerializerFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamOutputFormatConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, InnerDeliveryStreamSerializerFactory> WithSerializer(this InnerDeliveryStreamOutputFormatConfigurationFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null)
    {
        parentFactory.SerializerFactory = new InnerDeliveryStreamSerializerFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SerializerFactory);
    }

    public static CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, InnerDeliveryStreamSerializerFactory> WithSerializer<T1>(this CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, WithSerializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, InnerDeliveryStreamSerializerFactory> WithSerializer<T1>(this CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, WithSerializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, T2, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2>(this CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, T2, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamOutputFormatConfigurationFactory, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamOutputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, T2, T3, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, T2, T3, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamOutputFormatConfigurationFactory, T3, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamOutputFormatConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamOutputFormatConfigurationFactory, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamOutputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, T2, T3, T4, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamOutputFormatConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, T2, T3, T4, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamOutputFormatConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamOutputFormatConfigurationFactory, T3, T4, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamOutputFormatConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamOutputFormatConfigurationFactory, T4, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamOutputFormatConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamOutputFormatConfigurationFactory, InnerDeliveryStreamSerializerFactory> WithSerializer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamOutputFormatConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.Serializer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSerializer(combinedResult.T5, subFactoryAction));
}
