// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupDeploymentStyleFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentStyle> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentStyle>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentStyle Create()
    {
        var deploymentStyleResult = CreateDeploymentStyle();
        factoryAction?.Invoke(deploymentStyleResult);

        return deploymentStyleResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentStyle CreateDeploymentStyle()
    {
        var deploymentStyleResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentStyle();

        return deploymentStyleResult;
    }

} // End Of Class

public static class InnerDeploymentGroupDeploymentStyleFactoryExtensions
{
}
