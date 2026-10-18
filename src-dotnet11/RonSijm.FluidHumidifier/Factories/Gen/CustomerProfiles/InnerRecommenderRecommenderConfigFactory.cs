// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerRecommenderRecommenderConfigFactory(Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig>
{

    internal InnerRecommenderEventsConfigFactory EventsConfigFactory { get; set; }

    protected override Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig Create()
    {
        var recommenderConfigResult = CreateRecommenderConfig();
        factoryAction?.Invoke(recommenderConfigResult);

        return recommenderConfigResult;
    }

    private Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig CreateRecommenderConfig()
    {
        var recommenderConfigResult = new Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig();

        return recommenderConfigResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig result)
    {
        base.CreateChildren(result);

        result.EventsConfig ??= EventsConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRecommenderRecommenderConfigFactoryExtensions
{
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, InnerRecommenderEventsConfigFactory> WithEventsConfig(this InnerRecommenderRecommenderConfigFactory parentFactory, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null)
    {
        parentFactory.EventsConfigFactory = new InnerRecommenderEventsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventsConfigFactory);
    }

    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2>(this CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3, T4, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3, T4>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3, T4, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3, T4, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory, T4, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRecommenderRecommenderConfigFactory, InnerRecommenderEventsConfigFactory> WithEventsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventsConfig(combinedResult.T5, subFactoryAction).T2);
}
