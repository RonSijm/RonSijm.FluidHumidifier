// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.RDS.Deployment> factoryAction = null) : ResourceFactory<Humidifier.RDS.Deployment>(resourceName)
{

    protected override Humidifier.RDS.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.RDS.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.RDS.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
}
