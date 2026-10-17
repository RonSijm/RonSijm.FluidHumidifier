// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration>
{

    internal InnerPlaybackConfigurationPreRollVastResponseFactory VastResponseFactory { get; set; }

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration Create()
    {
        var preRollAdDecisionServerConfigurationResult = CreatePreRollAdDecisionServerConfiguration();
        factoryAction?.Invoke(preRollAdDecisionServerConfigurationResult);

        return preRollAdDecisionServerConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration CreatePreRollAdDecisionServerConfiguration()
    {
        var preRollAdDecisionServerConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration();

        return preRollAdDecisionServerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollAdDecisionServerConfiguration result)
    {
        base.CreateChildren(result);

        result.VastResponse ??= VastResponseFactory?.Build();
    }

} // End Of Class

public static class InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse(this InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory parentFactory, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null)
    {
        parentFactory.VastResponseFactory = new InnerPlaybackConfigurationPreRollVastResponseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VastResponseFactory);
    }

    public static CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1>(this CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithVastResponse(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1>(this CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, WithVastResponse(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, T2, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2>(this CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T2, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2>(this CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2>(this CombinedResult<T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, T2, T3, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3>(this CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T2, T3, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3>(this CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T3, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3>(this CombinedResult<T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, T2, T3, T4, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3, T4>(this CombinedResult<InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T2, T3, T4, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3, T4>(this CombinedResult<T1, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T3, T4, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T4, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory, InnerPlaybackConfigurationPreRollVastResponseFactory> WithVastResponse<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationPreRollAdDecisionServerConfigurationFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.PreRollVastResponse> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVastResponse(combinedResult.T5, subFactoryAction).T2);
}
