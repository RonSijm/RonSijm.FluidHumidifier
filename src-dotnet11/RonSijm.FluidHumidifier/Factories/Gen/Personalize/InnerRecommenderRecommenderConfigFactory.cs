// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerRecommenderRecommenderConfigFactory(Action<Humidifier.Personalize.RecommenderTypes.RecommenderConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.RecommenderTypes.RecommenderConfig>
{

    internal InnerRecommenderTrainingDataConfigFactory TrainingDataConfigFactory { get; set; }

    protected override Humidifier.Personalize.RecommenderTypes.RecommenderConfig Create()
    {
        var recommenderConfigResult = CreateRecommenderConfig();
        factoryAction?.Invoke(recommenderConfigResult);

        return recommenderConfigResult;
    }

    private Humidifier.Personalize.RecommenderTypes.RecommenderConfig CreateRecommenderConfig()
    {
        var recommenderConfigResult = new Humidifier.Personalize.RecommenderTypes.RecommenderConfig();

        return recommenderConfigResult;
    }
    public override void CreateChildren(Humidifier.Personalize.RecommenderTypes.RecommenderConfig result)
    {
        base.CreateChildren(result);

        result.TrainingDataConfig ??= TrainingDataConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRecommenderRecommenderConfigFactoryExtensions
{
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig(this InnerRecommenderRecommenderConfigFactory parentFactory, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null)
    {
        parentFactory.TrainingDataConfigFactory = new InnerRecommenderTrainingDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TrainingDataConfigFactory);
    }

    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2>(this CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3, T4, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3, T4>(this CombinedResult<InnerRecommenderRecommenderConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3, T4, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecommenderRecommenderConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3, T4, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecommenderRecommenderConfigFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory, T4, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecommenderRecommenderConfigFactory, T4> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRecommenderRecommenderConfigFactory, InnerRecommenderTrainingDataConfigFactory> WithTrainingDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecommenderRecommenderConfigFactory> combinedResult, Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTrainingDataConfig(combinedResult.T5, subFactoryAction).T2);
}
