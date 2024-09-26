// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceServiceManagedEBSVolumeConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration Create()
    {
        var serviceManagedEBSVolumeConfigurationResult = CreateServiceManagedEBSVolumeConfiguration();
        factoryAction?.Invoke(serviceManagedEBSVolumeConfigurationResult);

        return serviceManagedEBSVolumeConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration CreateServiceManagedEBSVolumeConfiguration()
    {
        var serviceManagedEBSVolumeConfigurationResult = new Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration();

        return serviceManagedEBSVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerServiceServiceManagedEBSVolumeConfigurationFactoryExtensions
{
}
