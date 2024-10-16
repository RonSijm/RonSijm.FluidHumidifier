// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupDeploymentReadyOptionFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentReadyOption> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentReadyOption>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentReadyOption Create()
    {
        var deploymentReadyOptionResult = CreateDeploymentReadyOption();
        factoryAction?.Invoke(deploymentReadyOptionResult);

        return deploymentReadyOptionResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentReadyOption CreateDeploymentReadyOption()
    {
        var deploymentReadyOptionResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.DeploymentReadyOption();

        return deploymentReadyOptionResult;
    }

} // End Of Class

public static class InnerDeploymentGroupDeploymentReadyOptionFactoryExtensions
{
}
