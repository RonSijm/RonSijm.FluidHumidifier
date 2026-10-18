// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.M2;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.M2.Deployment> factoryAction = null) : ResourceFactory<Humidifier.M2.Deployment>(resourceName)
{

    protected override Humidifier.M2.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.M2.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.M2.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
}
