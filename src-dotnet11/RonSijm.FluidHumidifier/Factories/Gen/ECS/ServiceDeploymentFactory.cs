// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class ServiceDeploymentFactory(string resourceName = null, Action<Humidifier.ECS.ServiceDeployment> factoryAction = null) : ResourceFactory<Humidifier.ECS.ServiceDeployment>(resourceName)
{

    protected override Humidifier.ECS.ServiceDeployment Create()
    {
        var serviceDeploymentResult = CreateServiceDeployment();
        factoryAction?.Invoke(serviceDeploymentResult);

        return serviceDeploymentResult;
    }

    private Humidifier.ECS.ServiceDeployment CreateServiceDeployment()
    {
        var serviceDeploymentResult = new Humidifier.ECS.ServiceDeployment
        {
            GivenName = InputResourceName,
        };

        return serviceDeploymentResult;
    }

} // End Of Class

public static class ServiceDeploymentFactoryExtensions
{
}
