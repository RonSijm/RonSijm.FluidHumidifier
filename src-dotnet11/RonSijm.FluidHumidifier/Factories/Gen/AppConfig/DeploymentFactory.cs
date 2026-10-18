// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.AppConfig.Deployment> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.Deployment>(resourceName)
{

    internal List<InnerDeploymentDynamicExtensionParametersFactory> DynamicExtensionParametersFactories { get; set; } = [];

    protected override Humidifier.AppConfig.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.AppConfig.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.AppConfig.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.Deployment result)
    {
        base.CreateChildren(result);

        result.DynamicExtensionParameters = DynamicExtensionParametersFactories.Any() ? DynamicExtensionParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
    public static CombinedResult<DeploymentFactory, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters(this DeploymentFactory parentFactory, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null)
    {
        var factory = new InnerDeploymentDynamicExtensionParametersFactory(subFactoryAction);
        parentFactory.DynamicExtensionParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DeploymentFactory, T1, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1>(this CombinedResult<DeploymentFactory, T1> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeploymentFactory, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1>(this CombinedResult<T1, DeploymentFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DeploymentFactory, T1, T2, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2>(this CombinedResult<DeploymentFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeploymentFactory, T2, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2>(this CombinedResult<T1, DeploymentFactory, T2> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DeploymentFactory, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2>(this CombinedResult<T1, T2, DeploymentFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DeploymentFactory, T1, T2, T3, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3>(this CombinedResult<DeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeploymentFactory, T2, T3, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3>(this CombinedResult<T1, DeploymentFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DeploymentFactory, T3, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentFactory, T3> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DeploymentFactory, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DeploymentFactory, T1, T2, T3, T4, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3, T4>(this CombinedResult<DeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DeploymentFactory, T2, T3, T4, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DeploymentFactory, T3, T4, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DeploymentFactory, T4, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentFactory, T4> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DeploymentFactory, InnerDeploymentDynamicExtensionParametersFactory> WithDynamicExtensionParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentFactory> combinedResult, Action<Humidifier.AppConfig.DeploymentTypes.DynamicExtensionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDynamicExtensionParameters(combinedResult.T5, subFactoryAction).T2);
}
