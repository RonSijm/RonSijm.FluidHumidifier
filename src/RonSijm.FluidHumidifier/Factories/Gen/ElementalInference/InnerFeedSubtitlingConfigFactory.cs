// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class InnerFeedSubtitlingConfigFactory(Action<Humidifier.ElementalInference.FeedTypes.SubtitlingConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElementalInference.FeedTypes.SubtitlingConfig>
{

    internal InnerFeedAspectRatioFactory AspectRatioFactory { get; set; }

    protected override Humidifier.ElementalInference.FeedTypes.SubtitlingConfig Create()
    {
        var subtitlingConfigResult = CreateSubtitlingConfig();
        factoryAction?.Invoke(subtitlingConfigResult);

        return subtitlingConfigResult;
    }

    private Humidifier.ElementalInference.FeedTypes.SubtitlingConfig CreateSubtitlingConfig()
    {
        var subtitlingConfigResult = new Humidifier.ElementalInference.FeedTypes.SubtitlingConfig();

        return subtitlingConfigResult;
    }
    public override void CreateChildren(Humidifier.ElementalInference.FeedTypes.SubtitlingConfig result)
    {
        base.CreateChildren(result);

        result.AspectRatio ??= AspectRatioFactory?.Build();
    }

} // End Of Class

public static class InnerFeedSubtitlingConfigFactoryExtensions
{
    public static CombinedResult<InnerFeedSubtitlingConfigFactory, InnerFeedAspectRatioFactory> WithAspectRatio(this InnerFeedSubtitlingConfigFactory parentFactory, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null)
    {
        parentFactory.AspectRatioFactory = new InnerFeedAspectRatioFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AspectRatioFactory);
    }

    public static CombinedResult<InnerFeedSubtitlingConfigFactory, T1, InnerFeedAspectRatioFactory> WithAspectRatio<T1>(this CombinedResult<InnerFeedSubtitlingConfigFactory, T1> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, WithAspectRatio(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedSubtitlingConfigFactory, InnerFeedAspectRatioFactory> WithAspectRatio<T1>(this CombinedResult<T1, InnerFeedSubtitlingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, WithAspectRatio(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFeedSubtitlingConfigFactory, T1, T2, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2>(this CombinedResult<InnerFeedSubtitlingConfigFactory, T1, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedSubtitlingConfigFactory, T2, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2>(this CombinedResult<T1, InnerFeedSubtitlingConfigFactory, T2> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedSubtitlingConfigFactory, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2>(this CombinedResult<T1, T2, InnerFeedSubtitlingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFeedSubtitlingConfigFactory, T1, T2, T3, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3>(this CombinedResult<InnerFeedSubtitlingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedSubtitlingConfigFactory, T2, T3, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3>(this CombinedResult<T1, InnerFeedSubtitlingConfigFactory, T2, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedSubtitlingConfigFactory, T3, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3>(this CombinedResult<T1, T2, InnerFeedSubtitlingConfigFactory, T3> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFeedSubtitlingConfigFactory, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFeedSubtitlingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFeedSubtitlingConfigFactory, T1, T2, T3, T4, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3, T4>(this CombinedResult<InnerFeedSubtitlingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFeedSubtitlingConfigFactory, T2, T3, T4, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3, T4>(this CombinedResult<T1, InnerFeedSubtitlingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFeedSubtitlingConfigFactory, T3, T4, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFeedSubtitlingConfigFactory, T3, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFeedSubtitlingConfigFactory, T4, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFeedSubtitlingConfigFactory, T4> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFeedSubtitlingConfigFactory, InnerFeedAspectRatioFactory> WithAspectRatio<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFeedSubtitlingConfigFactory> combinedResult, Action<Humidifier.ElementalInference.FeedTypes.AspectRatio> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAspectRatio(combinedResult.T5, subFactoryAction).T2);
}
