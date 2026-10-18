// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelTopicConfigurationFactory(Action<Humidifier.MSK.ChannelTypes.TopicConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.TopicConfiguration>
{

    internal InnerChannelRecordConverterFactory RecordConverterFactory { get; set; }

    internal InnerChannelRecordSchemaFactory RecordSchemaFactory { get; set; }

    protected override Humidifier.MSK.ChannelTypes.TopicConfiguration Create()
    {
        var topicConfigurationResult = CreateTopicConfiguration();
        factoryAction?.Invoke(topicConfigurationResult);

        return topicConfigurationResult;
    }

    private Humidifier.MSK.ChannelTypes.TopicConfiguration CreateTopicConfiguration()
    {
        var topicConfigurationResult = new Humidifier.MSK.ChannelTypes.TopicConfiguration();

        return topicConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MSK.ChannelTypes.TopicConfiguration result)
    {
        base.CreateChildren(result);

        result.RecordConverter ??= RecordConverterFactory?.Build();
        result.RecordSchema ??= RecordSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerChannelTopicConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelTopicConfigurationFactory, InnerChannelRecordConverterFactory> WithRecordConverter(this InnerChannelTopicConfigurationFactory parentFactory, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null)
    {
        parentFactory.RecordConverterFactory = new InnerChannelRecordConverterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordConverterFactory);
    }

    public static CombinedResult<InnerChannelTopicConfigurationFactory, InnerChannelRecordSchemaFactory> WithRecordSchema(this InnerChannelTopicConfigurationFactory parentFactory, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null)
    {
        parentFactory.RecordSchemaFactory = new InnerChannelRecordSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordSchemaFactory);
    }

    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, InnerChannelRecordConverterFactory> WithRecordConverter<T1>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordConverter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, InnerChannelRecordConverterFactory> WithRecordConverter<T1>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordConverter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2>(this CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3, T4, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3, T4>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3, T4, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3, T4, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory, T4, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelTopicConfigurationFactory, InnerChannelRecordConverterFactory> WithRecordConverter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordConverter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConverter(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, InnerChannelRecordSchemaFactory> WithRecordSchema<T1>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, InnerChannelRecordSchemaFactory> WithRecordSchema<T1>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2>(this CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3, T4, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3, T4>(this CombinedResult<InnerChannelTopicConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3, T4, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelTopicConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3, T4, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelTopicConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory, T4, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelTopicConfigurationFactory, T4> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelTopicConfigurationFactory, InnerChannelRecordSchemaFactory> WithRecordSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelTopicConfigurationFactory> combinedResult, Action<Humidifier.MSK.ChannelTypes.RecordSchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordSchema(combinedResult.T5, subFactoryAction).T2);
}
