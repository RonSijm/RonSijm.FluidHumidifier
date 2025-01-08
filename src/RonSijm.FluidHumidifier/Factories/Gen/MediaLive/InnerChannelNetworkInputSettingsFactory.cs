// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelNetworkInputSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.NetworkInputSettings>
{

    internal InnerChannelHlsInputSettingsFactory HlsInputSettingsFactory { get; set; }

    internal InnerChannelMulticastInputSettingsFactory MulticastInputSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.NetworkInputSettings Create()
    {
        var networkInputSettingsResult = CreateNetworkInputSettings();
        factoryAction?.Invoke(networkInputSettingsResult);

        return networkInputSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.NetworkInputSettings CreateNetworkInputSettings()
    {
        var networkInputSettingsResult = new Humidifier.MediaLive.ChannelTypes.NetworkInputSettings();

        return networkInputSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.NetworkInputSettings result)
    {
        base.CreateChildren(result);

        result.HlsInputSettings ??= HlsInputSettingsFactory?.Build();
        result.MulticastInputSettings ??= MulticastInputSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelNetworkInputSettingsFactoryExtensions
{
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings(this InnerChannelNetworkInputSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null)
    {
        parentFactory.HlsInputSettingsFactory = new InnerChannelHlsInputSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HlsInputSettingsFactory);
    }

    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings(this InnerChannelNetworkInputSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null)
    {
        parentFactory.MulticastInputSettingsFactory = new InnerChannelMulticastInputSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MulticastInputSettingsFactory);
    }

    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3, T4, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3, T4, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3, T4, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory, T4, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelNetworkInputSettingsFactory, InnerChannelHlsInputSettingsFactory> WithHlsInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsInputSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3, T4, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelNetworkInputSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3, T4, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelNetworkInputSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3, T4, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelNetworkInputSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory, T4, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelNetworkInputSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelNetworkInputSettingsFactory, InnerChannelMulticastInputSettingsFactory> WithMulticastInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelNetworkInputSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastInputSettings(combinedResult.T5, subFactoryAction));
}
