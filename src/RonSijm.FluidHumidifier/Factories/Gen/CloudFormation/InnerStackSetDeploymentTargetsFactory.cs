// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerStackSetDeploymentTargetsFactory(Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets>
{

    protected override Humidifier.CloudFormation.StackSetTypes.DeploymentTargets Create()
    {
        var deploymentTargetsResult = CreateDeploymentTargets();
        factoryAction?.Invoke(deploymentTargetsResult);

        return deploymentTargetsResult;
    }

    private Humidifier.CloudFormation.StackSetTypes.DeploymentTargets CreateDeploymentTargets()
    {
        var deploymentTargetsResult = new Humidifier.CloudFormation.StackSetTypes.DeploymentTargets();

        return deploymentTargetsResult;
    }

} // End Of Class

public static class InnerStackSetDeploymentTargetsFactoryExtensions
{
}
