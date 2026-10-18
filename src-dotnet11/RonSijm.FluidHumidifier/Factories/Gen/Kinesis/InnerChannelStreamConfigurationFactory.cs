// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelStreamConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.StreamConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.StreamConfiguration>
{

    internal InnerChannelRecordConfigurationFactory RecordConfigurationFactory { get; set; }

    protected override Humidifier.Kinesis.ChannelTypes.StreamConfiguration Create()
    {
        var streamConfigurationResult = CreateStreamConfiguration();
        factoryAction?.Invoke(streamConfigurationResult);

        return streamConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.StreamConfiguration CreateStreamConfiguration()
    {
        var streamConfigurationResult = new Humidifier.Kinesis.ChannelTypes.StreamConfiguration();

        return streamConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kinesis.ChannelTypes.StreamConfiguration result)
    {
        base.CreateChildren(result);

        result.RecordConfiguration ??= RecordConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerChannelStreamConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelStreamConfigurationFactory, InnerChannelRecordConfigurationFactory> WithRecordConfiguration(this InnerChannelStreamConfigurationFactory parentFactory, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null)
    {
        parentFactory.RecordConfigurationFactory = new InnerChannelRecordConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecordConfigurationFactory);
    }

    public static CombinedResult<InnerChannelStreamConfigurationFactory, T1, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1>(this CombinedResult<InnerChannelStreamConfigurationFactory, T1> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelStreamConfigurationFactory, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1>(this CombinedResult<T1, InnerChannelStreamConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerChannelStreamConfigurationFactory, T1, T2, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2>(this CombinedResult<InnerChannelStreamConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelStreamConfigurationFactory, T2, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2>(this CombinedResult<T1, InnerChannelStreamConfigurationFactory, T2> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelStreamConfigurationFactory, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerChannelStreamConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerChannelStreamConfigurationFactory, T1, T2, T3, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3>(this CombinedResult<InnerChannelStreamConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelStreamConfigurationFactory, T2, T3, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerChannelStreamConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelStreamConfigurationFactory, T3, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelStreamConfigurationFactory, T3> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelStreamConfigurationFactory, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelStreamConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerChannelStreamConfigurationFactory, T1, T2, T3, T4, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerChannelStreamConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerChannelStreamConfigurationFactory, T2, T3, T4, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelStreamConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerChannelStreamConfigurationFactory, T3, T4, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelStreamConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerChannelStreamConfigurationFactory, T4, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelStreamConfigurationFactory, T4> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerChannelStreamConfigurationFactory, InnerChannelRecordConfigurationFactory> WithRecordConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelStreamConfigurationFactory> combinedResult, Action<Humidifier.Kinesis.ChannelTypes.RecordConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecordConfiguration(combinedResult.T5, subFactoryAction).T2);
}
