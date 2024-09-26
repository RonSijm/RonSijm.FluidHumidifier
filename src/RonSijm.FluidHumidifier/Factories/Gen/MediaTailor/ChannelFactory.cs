// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class ChannelFactory(string resourceName = null, Action<Humidifier.MediaTailor.Channel> factoryAction = null) : ResourceFactory<Humidifier.MediaTailor.Channel>(resourceName)
{

    internal List<InnerChannelRequestOutputItemFactory> OutputsFactories { get; set; } = [];

    internal InnerChannelSlateSourceFactory FillerSlateFactory { get; set; }

    internal InnerChannelLogConfigurationForChannelFactory LogConfigurationFactory { get; set; }

    internal InnerChannelTimeShiftConfigurationFactory TimeShiftConfigurationFactory { get; set; }

    protected override Humidifier.MediaTailor.Channel Create()
    {
        var channelResult = CreateChannel();
        factoryAction?.Invoke(channelResult);

        return channelResult;
    }

    private Humidifier.MediaTailor.Channel CreateChannel()
    {
        var channelResult = new Humidifier.MediaTailor.Channel
        {
            GivenName = InputResourceName,
        };

        return channelResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.Channel result)
    {
        base.CreateChildren(result);

        result.Outputs = OutputsFactories.Any() ? OutputsFactories.Select(x => x.Build()).ToList() : null;
        result.FillerSlate ??= FillerSlateFactory?.Build();
        result.LogConfiguration ??= LogConfigurationFactory?.Build();
        result.TimeShiftConfiguration ??= TimeShiftConfigurationFactory?.Build();
    }

} // End Of Class

public static class ChannelFactoryExtensions
{
    public static CombinedResult<ChannelFactory, InnerChannelRequestOutputItemFactory> WithOutputs(this ChannelFactory parentFactory, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null)
    {
        var factory = new InnerChannelRequestOutputItemFactory(subFactoryAction);
        parentFactory.OutputsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChannelFactory, InnerChannelSlateSourceFactory> WithFillerSlate(this ChannelFactory parentFactory, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null)
    {
        parentFactory.FillerSlateFactory = new InnerChannelSlateSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FillerSlateFactory);
    }

    public static CombinedResult<ChannelFactory, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration(this ChannelFactory parentFactory, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null)
    {
        parentFactory.LogConfigurationFactory = new InnerChannelLogConfigurationForChannelFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigurationFactory);
    }

    public static CombinedResult<ChannelFactory, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration(this ChannelFactory parentFactory, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null)
    {
        parentFactory.TimeShiftConfigurationFactory = new InnerChannelTimeShiftConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeShiftConfigurationFactory);
    }

    public static CombinedResult<ChannelFactory, T1, InnerChannelRequestOutputItemFactory> WithOutputs<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelRequestOutputItemFactory> WithOutputs<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelRequestOutputItemFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, InnerChannelSlateSourceFactory> WithFillerSlate<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFillerSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelSlateSourceFactory> WithFillerSlate<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFillerSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelSlateSourceFactory> WithFillerSlate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.SlateSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFillerSlate(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelLogConfigurationForChannelFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1>(this CombinedResult<ChannelFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1>(this CombinedResult<T1, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2>(this CombinedResult<ChannelFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2>(this CombinedResult<T1, ChannelFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2>(this CombinedResult<T1, T2, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3>(this CombinedResult<ChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3>(this CombinedResult<T1, ChannelFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ChannelFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelFactory, T1, T2, T3, T4, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3, T4>(this CombinedResult<ChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelFactory, T2, T3, T4, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelFactory, T3, T4, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelFactory, T4, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelFactory, InnerChannelTimeShiftConfigurationFactory> WithTimeShiftConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeShiftConfiguration(combinedResult.T5, subFactoryAction));
}
