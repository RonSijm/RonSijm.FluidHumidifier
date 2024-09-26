// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelMotionGraphicsSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings>
{

    internal InnerChannelHtmlMotionGraphicsSettingsFactory HtmlMotionGraphicsSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings Create()
    {
        var motionGraphicsSettingsResult = CreateMotionGraphicsSettings();
        factoryAction?.Invoke(motionGraphicsSettingsResult);

        return motionGraphicsSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings CreateMotionGraphicsSettings()
    {
        var motionGraphicsSettingsResult = new Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings();

        return motionGraphicsSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings result)
    {
        base.CreateChildren(result);

        result.HtmlMotionGraphicsSettings ??= HtmlMotionGraphicsSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelMotionGraphicsSettingsFactoryExtensions
{
    public static CombinedResult<InnerChannelMotionGraphicsSettingsFactory, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings(this InnerChannelMotionGraphicsSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null)
    {
        parentFactory.HtmlMotionGraphicsSettingsFactory = new InnerChannelHtmlMotionGraphicsSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HtmlMotionGraphicsSettingsFactory);
    }

    public static CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1>(this CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1>(this CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, T2, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2>(this CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, T2, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2>(this CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelMotionGraphicsSettingsFactory, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelMotionGraphicsSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, T2, T3, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, T2, T3, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelMotionGraphicsSettingsFactory, T3, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelMotionGraphicsSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsSettingsFactory, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, T2, T3, T4, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelMotionGraphicsSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, T2, T3, T4, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelMotionGraphicsSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelMotionGraphicsSettingsFactory, T3, T4, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelMotionGraphicsSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsSettingsFactory, T4, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelMotionGraphicsSettingsFactory, InnerChannelHtmlMotionGraphicsSettingsFactory> WithHtmlMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelMotionGraphicsSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHtmlMotionGraphicsSettings(combinedResult.T5, subFactoryAction));
}
