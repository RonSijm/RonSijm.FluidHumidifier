// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupECSServiceFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService Create()
    {
        var eCSServiceResult = CreateECSService();
        factoryAction?.Invoke(eCSServiceResult);

        return eCSServiceResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService CreateECSService()
    {
        var eCSServiceResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.ECSService();

        return eCSServiceResult;
    }

} // End Of Class

public static class InnerDeploymentGroupECSServiceFactoryExtensions
{
}
