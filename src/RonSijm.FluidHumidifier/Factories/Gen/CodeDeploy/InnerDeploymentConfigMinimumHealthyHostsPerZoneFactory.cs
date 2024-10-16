// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory(Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone>
{

    protected override Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone Create()
    {
        var minimumHealthyHostsPerZoneResult = CreateMinimumHealthyHostsPerZone();
        factoryAction?.Invoke(minimumHealthyHostsPerZoneResult);

        return minimumHealthyHostsPerZoneResult;
    }

    private Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone CreateMinimumHealthyHostsPerZone()
    {
        var minimumHealthyHostsPerZoneResult = new Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone();

        return minimumHealthyHostsPerZoneResult;
    }

} // End Of Class

public static class InnerDeploymentConfigMinimumHealthyHostsPerZoneFactoryExtensions
{
}
