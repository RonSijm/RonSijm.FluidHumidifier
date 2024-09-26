// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionDockerVolumeConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.DockerVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.DockerVolumeConfiguration>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.DockerVolumeConfiguration Create()
    {
        var dockerVolumeConfigurationResult = CreateDockerVolumeConfiguration();
        factoryAction?.Invoke(dockerVolumeConfigurationResult);

        return dockerVolumeConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.DockerVolumeConfiguration CreateDockerVolumeConfiguration()
    {
        var dockerVolumeConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.DockerVolumeConfiguration();

        return dockerVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerTaskDefinitionDockerVolumeConfigurationFactoryExtensions
{
}
