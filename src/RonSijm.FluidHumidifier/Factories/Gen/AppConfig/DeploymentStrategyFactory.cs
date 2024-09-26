// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class DeploymentStrategyFactory(string resourceName = null, Action<Humidifier.AppConfig.DeploymentStrategy> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.DeploymentStrategy>(resourceName)
{

    internal List<InnerDeploymentStrategyTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.AppConfig.DeploymentStrategy Create()
    {
        var deploymentStrategyResult = CreateDeploymentStrategy();
        factoryAction?.Invoke(deploymentStrategyResult);

        return deploymentStrategyResult;
    }

    private Humidifier.AppConfig.DeploymentStrategy CreateDeploymentStrategy()
    {
        var deploymentStrategyResult = new Humidifier.AppConfig.DeploymentStrategy
        {
            GivenName = InputResourceName,
        };

        return deploymentStrategyResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.DeploymentStrategy result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DeploymentStrategyFactoryExtensions
{
    public static CombinedResult<DeploymentStrategyFactory, InnerDeploymentStrategyTagsFactory> WithTags(this DeploymentStrategyFactory parentFactory, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerDeploymentStrategyTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DeploymentStrategyFactory, T1, InnerDeploymentStrategyTagsFactory> WithTags<T1>(this CombinedResult<DeploymentStrategyFactory, T1> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentStrategyFactory, InnerDeploymentStrategyTagsFactory> WithTags<T1>(this CombinedResult<T1, DeploymentStrategyFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeploymentStrategyFactory, T1, T2, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2>(this CombinedResult<DeploymentStrategyFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentStrategyFactory, T2, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, DeploymentStrategyFactory, T2> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentStrategyFactory, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DeploymentStrategyFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeploymentStrategyFactory, T1, T2, T3, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<DeploymentStrategyFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentStrategyFactory, T2, T3, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DeploymentStrategyFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentStrategyFactory, T3, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentStrategyFactory, T3> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentStrategyFactory, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentStrategyFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeploymentStrategyFactory, T1, T2, T3, T4, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DeploymentStrategyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentStrategyFactory, T2, T3, T4, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentStrategyFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentStrategyFactory, T3, T4, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentStrategyFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentStrategyFactory, T4, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentStrategyFactory, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeploymentStrategyFactory, InnerDeploymentStrategyTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentStrategyFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
