// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionHostVolumePropertiesFactory(Action<Humidifier.ECS.TaskDefinitionTypes.HostVolumeProperties> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.HostVolumeProperties>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.HostVolumeProperties Create()
    {
        var hostVolumePropertiesResult = CreateHostVolumeProperties();
        factoryAction?.Invoke(hostVolumePropertiesResult);

        return hostVolumePropertiesResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.HostVolumeProperties CreateHostVolumeProperties()
    {
        var hostVolumePropertiesResult = new Humidifier.ECS.TaskDefinitionTypes.HostVolumeProperties();

        return hostVolumePropertiesResult;
    }

} // End Of Class

public static class InnerTaskDefinitionHostVolumePropertiesFactoryExtensions
{
}
