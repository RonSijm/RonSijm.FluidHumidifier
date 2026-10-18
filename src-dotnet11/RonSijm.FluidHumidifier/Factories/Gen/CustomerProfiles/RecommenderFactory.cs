// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class RecommenderFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.Recommender> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.Recommender>(resourceName)
{

    internal InnerRecommenderRecommenderConfigFactory RecommenderConfigFactory { get; set; }

    protected override Humidifier.CustomerProfiles.Recommender Create()
    {
        var recommenderResult = CreateRecommender();
        factoryAction?.Invoke(recommenderResult);

        return recommenderResult;
    }

    private Humidifier.CustomerProfiles.Recommender CreateRecommender()
    {
        var recommenderResult = new Humidifier.CustomerProfiles.Recommender
        {
            GivenName = InputResourceName,
        };

        return recommenderResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.Recommender result)
    {
        base.CreateChildren(result);

        result.RecommenderConfig ??= RecommenderConfigFactory?.Build();
    }

} // End Of Class

public static class RecommenderFactoryExtensions
{
    public static CombinedResult<RecommenderFactory, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig(this RecommenderFactory parentFactory, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null)
    {
        parentFactory.RecommenderConfigFactory = new InnerRecommenderRecommenderConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RecommenderConfigFactory);
    }

    public static CombinedResult<RecommenderFactory, T1, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1>(this CombinedResult<RecommenderFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFactory, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1>(this CombinedResult<T1, RecommenderFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RecommenderFactory, T1, T2, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2>(this CombinedResult<RecommenderFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFactory, T2, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2>(this CombinedResult<T1, RecommenderFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderFactory, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2>(this CombinedResult<T1, T2, RecommenderFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RecommenderFactory, T1, T2, T3, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3>(this CombinedResult<RecommenderFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFactory, T2, T3, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3>(this CombinedResult<T1, RecommenderFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderFactory, T3, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3>(this CombinedResult<T1, T2, RecommenderFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RecommenderFactory, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, RecommenderFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RecommenderFactory, T1, T2, T3, T4, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3, T4>(this CombinedResult<RecommenderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RecommenderFactory, T2, T3, T4, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, RecommenderFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RecommenderFactory, T3, T4, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, RecommenderFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RecommenderFactory, T4, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RecommenderFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RecommenderFactory, InnerRecommenderRecommenderConfigFactory> WithRecommenderConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RecommenderFactory> combinedResult, Action<Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRecommenderConfig(combinedResult.T5, subFactoryAction).T2);
}
