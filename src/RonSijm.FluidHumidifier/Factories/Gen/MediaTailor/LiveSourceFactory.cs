// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class LiveSourceFactory(string resourceName = null, Action<Humidifier.MediaTailor.LiveSource> factoryAction = null) : ResourceFactory<Humidifier.MediaTailor.LiveSource>(resourceName)
{

    internal List<InnerLiveSourceHttpPackageConfigurationFactory> HttpPackageConfigurationsFactories { get; set; } = [];

    protected override Humidifier.MediaTailor.LiveSource Create()
    {
        var liveSourceResult = CreateLiveSource();
        factoryAction?.Invoke(liveSourceResult);

        return liveSourceResult;
    }

    private Humidifier.MediaTailor.LiveSource CreateLiveSource()
    {
        var liveSourceResult = new Humidifier.MediaTailor.LiveSource
        {
            GivenName = InputResourceName,
        };

        return liveSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.LiveSource result)
    {
        base.CreateChildren(result);

        result.HttpPackageConfigurations = HttpPackageConfigurationsFactories.Any() ? HttpPackageConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LiveSourceFactoryExtensions
{
    public static CombinedResult<LiveSourceFactory, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations(this LiveSourceFactory parentFactory, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null)
    {
        var factory = new InnerLiveSourceHttpPackageConfigurationFactory(subFactoryAction);
        parentFactory.HttpPackageConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LiveSourceFactory, T1, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1>(this CombinedResult<LiveSourceFactory, T1> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LiveSourceFactory, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1>(this CombinedResult<T1, LiveSourceFactory> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LiveSourceFactory, T1, T2, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2>(this CombinedResult<LiveSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LiveSourceFactory, T2, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2>(this CombinedResult<T1, LiveSourceFactory, T2> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LiveSourceFactory, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2>(this CombinedResult<T1, T2, LiveSourceFactory> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LiveSourceFactory, T1, T2, T3, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<LiveSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LiveSourceFactory, T2, T3, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<T1, LiveSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LiveSourceFactory, T3, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, LiveSourceFactory, T3> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LiveSourceFactory, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, LiveSourceFactory> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LiveSourceFactory, T1, T2, T3, T4, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<LiveSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LiveSourceFactory, T2, T3, T4, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, LiveSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LiveSourceFactory, T3, T4, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, LiveSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LiveSourceFactory, T4, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LiveSourceFactory, T4> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LiveSourceFactory, InnerLiveSourceHttpPackageConfigurationFactory> WithHttpPackageConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LiveSourceFactory> combinedResult, Action<Humidifier.MediaTailor.LiveSourceTypes.HttpPackageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpPackageConfigurations(combinedResult.T5, subFactoryAction));
}
