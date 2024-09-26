// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LaunchWizard;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.LaunchWizard.Deployment> factoryAction = null) : ResourceFactory<Humidifier.LaunchWizard.Deployment>(resourceName)
{

    internal List<InnerDeploymentTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.LaunchWizard.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.LaunchWizard.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.LaunchWizard.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }
    public override void CreateChildren(Humidifier.LaunchWizard.Deployment result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
    public static CombinedResult<DeploymentFactory, InnerDeploymentTagsFactory> WithTags(this DeploymentFactory parentFactory, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerDeploymentTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DeploymentFactory, T1, InnerDeploymentTagsFactory> WithTags<T1>(this CombinedResult<DeploymentFactory, T1> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, InnerDeploymentTagsFactory> WithTags<T1>(this CombinedResult<T1, DeploymentFactory> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, InnerDeploymentTagsFactory> WithTags<T1, T2>(this CombinedResult<DeploymentFactory, T1, T2> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, InnerDeploymentTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, DeploymentFactory, T2> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, InnerDeploymentTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DeploymentFactory> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, InnerDeploymentTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<DeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, InnerDeploymentTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DeploymentFactory, T2, T3> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, InnerDeploymentTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentFactory, T3> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, InnerDeploymentTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentFactory> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, T4, InnerDeploymentTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, T4, InnerDeploymentTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, T4, InnerDeploymentTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentFactory, T3, T4> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, T4, InnerDeploymentTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentFactory, T4> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeploymentFactory, InnerDeploymentTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentFactory> combinedResult, Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
