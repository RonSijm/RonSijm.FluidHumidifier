// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputRouterContentQualityAnalysisConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration>
{

    internal InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory ContentLevelFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration Create()
    {
        var routerContentQualityAnalysisConfigurationResult = CreateRouterContentQualityAnalysisConfiguration();
        factoryAction?.Invoke(routerContentQualityAnalysisConfigurationResult);

        return routerContentQualityAnalysisConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration CreateRouterContentQualityAnalysisConfiguration()
    {
        var routerContentQualityAnalysisConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration();

        return routerContentQualityAnalysisConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.RouterContentQualityAnalysisConfiguration result)
    {
        base.CreateChildren(result);

        result.ContentLevel ??= ContentLevelFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputRouterContentQualityAnalysisConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel(this InnerRouterInputRouterContentQualityAnalysisConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null)
    {
        parentFactory.ContentLevelFactory = new InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentLevelFactory);
    }

    public static CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1>(this CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentLevel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1>(this CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContentLevel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, T2, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2>(this CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T2, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2>(this CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, T2, T3, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3>(this CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T2, T3, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T3, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, T2, T3, T4, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T2, T3, T4, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T3, T4, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T4, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory, InnerRouterInputContentQualityAnalysisFeatureConfigurationFactory> WithContentLevel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputRouterContentQualityAnalysisConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.ContentQualityAnalysisFeatureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContentLevel(combinedResult.T5, subFactoryAction).T2);
}
