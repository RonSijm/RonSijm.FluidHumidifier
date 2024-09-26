// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelInputSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.InputSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.InputSettings>
{

    internal InnerChannelVideoSelectorFactory VideoSelectorFactory { get; set; }

    internal InnerChannelNetworkInputSettingsFactory NetworkInputSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.InputSettings Create()
    {
        var inputSettingsResult = CreateInputSettings();
        factoryAction?.Invoke(inputSettingsResult);

        return inputSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.InputSettings CreateInputSettings()
    {
        var inputSettingsResult = new Humidifier.MediaLive.ChannelTypes.InputSettings();

        return inputSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.InputSettings result)
    {
        base.CreateChildren(result);

        result.VideoSelector ??= VideoSelectorFactory?.Build();
        result.NetworkInputSettings ??= NetworkInputSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelInputSettingsFactoryExtensions
{
    public static CombinedResult<InnerChannelInputSettingsFactory, InnerChannelVideoSelectorFactory> WithVideoSelector(this InnerChannelInputSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null)
    {
        parentFactory.VideoSelectorFactory = new InnerChannelVideoSelectorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VideoSelectorFactory);
    }

    public static CombinedResult<InnerChannelInputSettingsFactory, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings(this InnerChannelInputSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null)
    {
        parentFactory.NetworkInputSettingsFactory = new InnerChannelNetworkInputSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkInputSettingsFactory);
    }

    public static CombinedResult<InnerChannelInputSettingsFactory, T1, InnerChannelVideoSelectorFactory> WithVideoSelector<T1>(this CombinedResult<InnerChannelInputSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSelector(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, InnerChannelVideoSelectorFactory> WithVideoSelector<T1>(this CombinedResult<T1, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSelector(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, T2, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2>(this CombinedResult<InnerChannelInputSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, T2, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2>(this CombinedResult<T1, InnerChannelInputSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputSettingsFactory, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2>(this CombinedResult<T1, T2, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3>(this CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3>(this CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3, T4, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3, T4>(this CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3, T4, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3, T4, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory, T4, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelInputSettingsFactory, InnerChannelVideoSelectorFactory> WithVideoSelector<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelector(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1>(this CombinedResult<InnerChannelInputSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1>(this CombinedResult<T1, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, T2, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2>(this CombinedResult<InnerChannelInputSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, T2, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2>(this CombinedResult<T1, InnerChannelInputSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputSettingsFactory, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3>(this CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3, T4, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelInputSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3, T4, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelInputSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3, T4, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelInputSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory, T4, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelInputSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelInputSettingsFactory, InnerChannelNetworkInputSettingsFactory> WithNetworkInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkInputSettings(combinedResult.T5, subFactoryAction));
}
