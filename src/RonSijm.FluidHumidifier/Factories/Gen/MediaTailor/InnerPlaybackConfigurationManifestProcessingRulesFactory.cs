// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationManifestProcessingRulesFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules>
{

    internal InnerPlaybackConfigurationAdMarkerPassthroughFactory AdMarkerPassthroughFactory { get; set; }

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules Create()
    {
        var manifestProcessingRulesResult = CreateManifestProcessingRules();
        factoryAction?.Invoke(manifestProcessingRulesResult);

        return manifestProcessingRulesResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules CreateManifestProcessingRules()
    {
        var manifestProcessingRulesResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules();

        return manifestProcessingRulesResult;
    }
    public override void CreateChildren(Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestProcessingRules result)
    {
        base.CreateChildren(result);

        result.AdMarkerPassthrough ??= AdMarkerPassthroughFactory?.Build();
    }

} // End Of Class

public static class InnerPlaybackConfigurationManifestProcessingRulesFactoryExtensions
{
    public static CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough(this InnerPlaybackConfigurationManifestProcessingRulesFactory parentFactory, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null)
    {
        parentFactory.AdMarkerPassthroughFactory = new InnerPlaybackConfigurationAdMarkerPassthroughFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdMarkerPassthroughFactory);
    }

    public static CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1>(this CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1>(this CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, T2, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2>(this CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, T2, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2>(this CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, T2> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationManifestProcessingRulesFactory, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2>(this CombinedResult<T1, T2, InnerPlaybackConfigurationManifestProcessingRulesFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, T2, T3, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3>(this CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, T2, T3, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3>(this CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, T2, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationManifestProcessingRulesFactory, T3, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3>(this CombinedResult<T1, T2, InnerPlaybackConfigurationManifestProcessingRulesFactory, T3> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationManifestProcessingRulesFactory, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationManifestProcessingRulesFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, T2, T3, T4, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3, T4>(this CombinedResult<InnerPlaybackConfigurationManifestProcessingRulesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, T2, T3, T4, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, InnerPlaybackConfigurationManifestProcessingRulesFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPlaybackConfigurationManifestProcessingRulesFactory, T3, T4, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPlaybackConfigurationManifestProcessingRulesFactory, T3, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPlaybackConfigurationManifestProcessingRulesFactory, T4, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPlaybackConfigurationManifestProcessingRulesFactory, T4> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationManifestProcessingRulesFactory, InnerPlaybackConfigurationAdMarkerPassthroughFactory> WithAdMarkerPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPlaybackConfigurationManifestProcessingRulesFactory> combinedResult, Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdMarkerPassthrough(combinedResult.T5, subFactoryAction));
}
