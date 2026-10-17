// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceDeploymentEarlySuccessCriteriaFactory(Action<Humidifier.ECS.ServiceTypes.DeploymentEarlySuccessCriteria> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.DeploymentEarlySuccessCriteria>
{

    protected override Humidifier.ECS.ServiceTypes.DeploymentEarlySuccessCriteria Create()
    {
        var deploymentEarlySuccessCriteriaResult = CreateDeploymentEarlySuccessCriteria();
        factoryAction?.Invoke(deploymentEarlySuccessCriteriaResult);

        return deploymentEarlySuccessCriteriaResult;
    }

    private Humidifier.ECS.ServiceTypes.DeploymentEarlySuccessCriteria CreateDeploymentEarlySuccessCriteria()
    {
        var deploymentEarlySuccessCriteriaResult = new Humidifier.ECS.ServiceTypes.DeploymentEarlySuccessCriteria();

        return deploymentEarlySuccessCriteriaResult;
    }

} // End Of Class

public static class InnerServiceDeploymentEarlySuccessCriteriaFactoryExtensions
{
}
