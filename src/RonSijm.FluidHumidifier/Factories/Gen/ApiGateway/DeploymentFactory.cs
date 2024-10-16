// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.ApiGateway.Deployment> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.Deployment>(resourceName)
{

    internal InnerDeploymentStageDescriptionFactory StageDescriptionFactory { get; set; }

    internal InnerDeploymentDeploymentCanarySettingsFactory DeploymentCanarySettingsFactory { get; set; }

    protected override Humidifier.ApiGateway.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.ApiGateway.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.ApiGateway.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.Deployment result)
    {
        base.CreateChildren(result);

        result.StageDescription ??= StageDescriptionFactory?.Build();
        result.DeploymentCanarySettings ??= DeploymentCanarySettingsFactory?.Build();
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
    public static CombinedResult<DeploymentFactory, InnerDeploymentStageDescriptionFactory> WithStageDescription(this DeploymentFactory parentFactory, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null)
    {
        parentFactory.StageDescriptionFactory = new InnerDeploymentStageDescriptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StageDescriptionFactory);
    }

    public static CombinedResult<DeploymentFactory, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings(this DeploymentFactory parentFactory, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null)
    {
        parentFactory.DeploymentCanarySettingsFactory = new InnerDeploymentDeploymentCanarySettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentCanarySettingsFactory);
    }

    public static CombinedResult<DeploymentFactory, T1, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1>(this CombinedResult<DeploymentFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, WithStageDescription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1>(this CombinedResult<T1, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, WithStageDescription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2>(this CombinedResult<DeploymentFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2>(this CombinedResult<T1, DeploymentFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2>(this CombinedResult<T1, T2, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3>(this CombinedResult<DeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3>(this CombinedResult<T1, DeploymentFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, T4, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3, T4>(this CombinedResult<DeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, T4, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, T4, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, T4, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeploymentFactory, InnerDeploymentStageDescriptionFactory> WithStageDescription<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.StageDescription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStageDescription(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1>(this CombinedResult<DeploymentFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1>(this CombinedResult<T1, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2>(this CombinedResult<DeploymentFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2>(this CombinedResult<T1, DeploymentFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2>(this CombinedResult<T1, T2, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3>(this CombinedResult<DeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3>(this CombinedResult<T1, DeploymentFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, T4, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3, T4>(this CombinedResult<DeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, T4, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, T4, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, T4, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeploymentFactory, InnerDeploymentDeploymentCanarySettingsFactory> WithDeploymentCanarySettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentFactory> combinedResult, Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentCanarySettings(combinedResult.T5, subFactoryAction));
}
