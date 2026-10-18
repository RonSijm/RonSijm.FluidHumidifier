// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentDeploymentComponentUpdatePolicyFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy>
{

    protected override Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy Create()
    {
        var deploymentComponentUpdatePolicyResult = CreateDeploymentComponentUpdatePolicy();
        factoryAction?.Invoke(deploymentComponentUpdatePolicyResult);

        return deploymentComponentUpdatePolicyResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy CreateDeploymentComponentUpdatePolicy()
    {
        var deploymentComponentUpdatePolicyResult = new Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy();

        return deploymentComponentUpdatePolicyResult;
    }

} // End Of Class

public static class InnerDeploymentDeploymentComponentUpdatePolicyFactoryExtensions
{
}
