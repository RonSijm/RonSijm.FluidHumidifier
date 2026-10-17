// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionHostVolumePropertiesFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties Create()
    {
        var hostVolumePropertiesResult = CreateHostVolumeProperties();
        factoryAction?.Invoke(hostVolumePropertiesResult);

        return hostVolumePropertiesResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties CreateHostVolumeProperties()
    {
        var hostVolumePropertiesResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties();

        return hostVolumePropertiesResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionHostVolumePropertiesFactoryExtensions
{
}
