// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentDeploymentConfigurationValidationPolicyFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy>
{

    protected override Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy Create()
    {
        var deploymentConfigurationValidationPolicyResult = CreateDeploymentConfigurationValidationPolicy();
        factoryAction?.Invoke(deploymentConfigurationValidationPolicyResult);

        return deploymentConfigurationValidationPolicyResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy CreateDeploymentConfigurationValidationPolicy()
    {
        var deploymentConfigurationValidationPolicyResult = new Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy();

        return deploymentConfigurationValidationPolicyResult;
    }

} // End Of Class

public static class InnerDeploymentDeploymentConfigurationValidationPolicyFactoryExtensions
{
}
