// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerEndpointContainerLogRotationConfigurationFactory(Action<Humidifier.EMRContainers.EndpointTypes.ContainerLogRotationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.EndpointTypes.ContainerLogRotationConfiguration>
{

    protected override Humidifier.EMRContainers.EndpointTypes.ContainerLogRotationConfiguration Create()
    {
        var containerLogRotationConfigurationResult = CreateContainerLogRotationConfiguration();
        factoryAction?.Invoke(containerLogRotationConfigurationResult);

        return containerLogRotationConfigurationResult;
    }

    private Humidifier.EMRContainers.EndpointTypes.ContainerLogRotationConfiguration CreateContainerLogRotationConfiguration()
    {
        var containerLogRotationConfigurationResult = new Humidifier.EMRContainers.EndpointTypes.ContainerLogRotationConfiguration();

        return containerLogRotationConfigurationResult;
    }

} // End Of Class

public static class InnerEndpointContainerLogRotationConfigurationFactoryExtensions
{
}
