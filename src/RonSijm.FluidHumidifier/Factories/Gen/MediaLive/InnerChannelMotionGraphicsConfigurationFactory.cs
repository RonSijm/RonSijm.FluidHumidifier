// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelMotionGraphicsConfigurationFactory(Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration>
{

    internal InnerChannelMotionGraphicsSettingsFactory MotionGraphicsSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration Create()
    {
        var motionGraphicsConfigurationResult = CreateMotionGraphicsConfiguration();
        factoryAction?.Invoke(motionGraphicsConfigurationResult);

        return motionGraphicsConfigurationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration CreateMotionGraphicsConfiguration()
    {
        var motionGraphicsConfigurationResult = new Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration();

        return motionGraphicsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.MotionGraphicsConfiguration result)
    {
        base.CreateChildren(result);

        result.MotionGraphicsSettings ??= MotionGraphicsSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelMotionGraphicsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings(this InnerChannelMotionGraphicsConfigurationFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null)
    {
        parentFactory.MotionGraphicsSettingsFactory = new InnerChannelMotionGraphicsSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MotionGraphicsSettingsFactory);
    }

    public static CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1>(this CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1>(this CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, T2, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2>(this CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, T2, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2>(this CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelMotionGraphicsConfigurationFactory, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelMotionGraphicsConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, T2, T3, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, T2, T3, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelMotionGraphicsConfigurationFactory, T3, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelMotionGraphicsConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsConfigurationFactory, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, T2, T3, T4, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelMotionGraphicsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, T2, T3, T4, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelMotionGraphicsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelMotionGraphicsConfigurationFactory, T3, T4, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelMotionGraphicsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsConfigurationFactory, T4, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelMotionGraphicsConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelMotionGraphicsConfigurationFactory, InnerChannelMotionGraphicsSettingsFactory> WithMotionGraphicsSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelMotionGraphicsConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.MotionGraphicsSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMotionGraphicsSettings(combinedResult.T5, subFactoryAction));
}
