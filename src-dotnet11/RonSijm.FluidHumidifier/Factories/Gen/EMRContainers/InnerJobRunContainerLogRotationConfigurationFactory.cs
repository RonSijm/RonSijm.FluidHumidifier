// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunContainerLogRotationConfigurationFactory(Action<Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration>
{

    protected override Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration Create()
    {
        var containerLogRotationConfigurationResult = CreateContainerLogRotationConfiguration();
        factoryAction?.Invoke(containerLogRotationConfigurationResult);

        return containerLogRotationConfigurationResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration CreateContainerLogRotationConfiguration()
    {
        var containerLogRotationConfigurationResult = new Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration();

        return containerLogRotationConfigurationResult;
    }

} // End Of Class

public static class InnerJobRunContainerLogRotationConfigurationFactoryExtensions
{
}
