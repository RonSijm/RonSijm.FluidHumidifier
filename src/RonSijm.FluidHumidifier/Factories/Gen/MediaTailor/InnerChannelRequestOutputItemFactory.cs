// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerChannelRequestOutputItemFactory(Action<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem>
{

    internal InnerChannelDashPlaylistSettingsFactory DashPlaylistSettingsFactory { get; set; }

    internal InnerChannelHlsPlaylistSettingsFactory HlsPlaylistSettingsFactory { get; set; }

    protected override Humidifier.MediaTailor.ChannelTypes.RequestOutputItem Create()
    {
        var requestOutputItemResult = CreateRequestOutputItem();
        factoryAction?.Invoke(requestOutputItemResult);

        return requestOutputItemResult;
    }

    private Humidifier.MediaTailor.ChannelTypes.RequestOutputItem CreateRequestOutputItem()
    {
        var requestOutputItemResult = new Humidifier.MediaTailor.ChannelTypes.RequestOutputItem();

        return requestOutputItemResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.ChannelTypes.RequestOutputItem result)
    {
        base.CreateChildren(result);

        result.DashPlaylistSettings ??= DashPlaylistSettingsFactory?.Build();
        result.HlsPlaylistSettings ??= HlsPlaylistSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelRequestOutputItemFactoryExtensions
{
    public static CombinedResult<InnerChannelRequestOutputItemFactory, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings(this InnerChannelRequestOutputItemFactory parentFactory, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null)
    {
        parentFactory.DashPlaylistSettingsFactory = new InnerChannelDashPlaylistSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DashPlaylistSettingsFactory);
    }

    public static CombinedResult<InnerChannelRequestOutputItemFactory, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings(this InnerChannelRequestOutputItemFactory parentFactory, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null)
    {
        parentFactory.HlsPlaylistSettingsFactory = new InnerChannelHlsPlaylistSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HlsPlaylistSettingsFactory);
    }

    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3, T4, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3, T4, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3, T4, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory, T4, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelRequestOutputItemFactory, InnerChannelDashPlaylistSettingsFactory> WithDashPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashPlaylistSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3, T4, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelRequestOutputItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3, T4, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelRequestOutputItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3, T4, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelRequestOutputItemFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory, T4, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelRequestOutputItemFactory, T4> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelRequestOutputItemFactory, InnerChannelHlsPlaylistSettingsFactory> WithHlsPlaylistSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelRequestOutputItemFactory> combinedResult, Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHlsPlaylistSettings(combinedResult.T5, subFactoryAction));
}
