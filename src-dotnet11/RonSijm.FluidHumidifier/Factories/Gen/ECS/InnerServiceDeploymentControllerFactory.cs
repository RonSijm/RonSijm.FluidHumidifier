// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceDeploymentControllerFactory(Action<Humidifier.ECS.ServiceTypes.DeploymentController> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.DeploymentController>
{

    protected override Humidifier.ECS.ServiceTypes.DeploymentController Create()
    {
        var deploymentControllerResult = CreateDeploymentController();
        factoryAction?.Invoke(deploymentControllerResult);

        return deploymentControllerResult;
    }

    private Humidifier.ECS.ServiceTypes.DeploymentController CreateDeploymentController()
    {
        var deploymentControllerResult = new Humidifier.ECS.ServiceTypes.DeploymentController();

        return deploymentControllerResult;
    }

} // End Of Class

public static class InnerServiceDeploymentControllerFactoryExtensions
{
}
