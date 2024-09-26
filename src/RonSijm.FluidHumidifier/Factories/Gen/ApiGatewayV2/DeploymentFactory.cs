// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Deployment> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Deployment>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.ApiGatewayV2.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.ApiGatewayV2.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
}
