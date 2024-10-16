// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelAvailConfigurationFactory(Action<Humidifier.MediaLive.ChannelTypes.AvailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.AvailConfiguration>
{

    internal InnerChannelAvailSettingsFactory AvailSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.AvailConfiguration Create()
    {
        var availConfigurationResult = CreateAvailConfiguration();
        factoryAction?.Invoke(availConfigurationResult);

        return availConfigurationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.AvailConfiguration CreateAvailConfiguration()
    {
        var availConfigurationResult = new Humidifier.MediaLive.ChannelTypes.AvailConfiguration();

        return availConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.AvailConfiguration result)
    {
        base.CreateChildren(result);

        result.AvailSettings ??= AvailSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelAvailConfigurationFactoryExtensions
{
    public static CombinedResult<InnerChannelAvailConfigurationFactory, InnerChannelAvailSettingsFactory> WithAvailSettings(this InnerChannelAvailConfigurationFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null)
    {
        parentFactory.AvailSettingsFactory = new InnerChannelAvailSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AvailSettingsFactory);
    }

    public static CombinedResult<InnerChannelAvailConfigurationFactory, T1, InnerChannelAvailSettingsFactory> WithAvailSettings<T1>(this CombinedResult<InnerChannelAvailConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailConfigurationFactory, InnerChannelAvailSettingsFactory> WithAvailSettings<T1>(this CombinedResult<T1, InnerChannelAvailConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelAvailConfigurationFactory, T1, T2, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2>(this CombinedResult<InnerChannelAvailConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailConfigurationFactory, T2, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2>(this CombinedResult<T1, InnerChannelAvailConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelAvailConfigurationFactory, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelAvailConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelAvailConfigurationFactory, T1, T2, T3, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3>(this CombinedResult<InnerChannelAvailConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailConfigurationFactory, T2, T3, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelAvailConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelAvailConfigurationFactory, T3, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelAvailConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelAvailConfigurationFactory, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelAvailConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelAvailConfigurationFactory, T1, T2, T3, T4, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelAvailConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelAvailConfigurationFactory, T2, T3, T4, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelAvailConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelAvailConfigurationFactory, T3, T4, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelAvailConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelAvailConfigurationFactory, T4, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelAvailConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelAvailConfigurationFactory, InnerChannelAvailSettingsFactory> WithAvailSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelAvailConfigurationFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AvailSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailSettings(combinedResult.T5, subFactoryAction));
}
