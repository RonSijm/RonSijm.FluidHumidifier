// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentConfigMinimumHealthyHostsFactory(Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHosts> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHosts>
{

    protected override Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHosts Create()
    {
        var minimumHealthyHostsResult = CreateMinimumHealthyHosts();
        factoryAction?.Invoke(minimumHealthyHostsResult);

        return minimumHealthyHostsResult;
    }

    private Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHosts CreateMinimumHealthyHosts()
    {
        var minimumHealthyHostsResult = new Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHosts();

        return minimumHealthyHostsResult;
    }

} // End Of Class

public static class InnerDeploymentConfigMinimumHealthyHostsFactoryExtensions
{
}
