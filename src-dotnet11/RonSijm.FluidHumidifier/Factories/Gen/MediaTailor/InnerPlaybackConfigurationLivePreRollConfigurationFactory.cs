// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationLivePreRollConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration>
{

    internal InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory AdDecisionServerConfigurationFactory { get; set; }

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration Create()
    {
        var livePreRollConfigurationResult = CreateLivePreRollConfiguration();
        factoryAction?.Invoke(livePreRollConfigurationResult);

        return livePreRollConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration CreateLivePreRollConfiguration()
    {
        var livePreRollConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration();

        return livePreRollConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration result)
    {
        base.CreateChildren(result);

        result.AdDecisionServerConfiguration ??= AdDecisionServerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPlaybackConfigurationLivePreRollConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration(this InnerPlaybackConfigurationLivePreRollConfigurationFactory parentFactory, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null)
    {
        parentFactory.AdDecisionServerConfigurationFactory = new InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdDecisionServerConfigurationFactory);
    }

    public static CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1>(this CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1>(this CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2>(this CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2>(this CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationLivePreRollConfigurationFactory, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPlaybackConfigurationLivePreRollConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, T2, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3>(this CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T2, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationLivePreRollConfigurationFactory, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationLivePreRollConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, T2, T3, T4, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPlaybackConfigurationLivePreRollConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T2, T3, T4, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T3, T4, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T4, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationLivePreRollConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationLivePreRollConfigurationFactory, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> WithAdDecisionServerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationLivePreRollConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdDecisionServerConfiguration(combinedResult.T5, subFactoryAction).T2);
}
