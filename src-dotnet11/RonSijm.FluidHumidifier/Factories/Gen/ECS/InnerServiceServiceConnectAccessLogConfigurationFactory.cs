// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceServiceConnectAccessLogConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.ServiceConnectAccessLogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ServiceConnectAccessLogConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.ServiceConnectAccessLogConfiguration Create()
    {
        var serviceConnectAccessLogConfigurationResult = CreateServiceConnectAccessLogConfiguration();
        factoryAction?.Invoke(serviceConnectAccessLogConfigurationResult);

        return serviceConnectAccessLogConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.ServiceConnectAccessLogConfiguration CreateServiceConnectAccessLogConfiguration()
    {
        var serviceConnectAccessLogConfigurationResult = new Humidifier.ECS.ServiceTypes.ServiceConnectAccessLogConfiguration();

        return serviceConnectAccessLogConfigurationResult;
    }

} // End Of Class

public static class InnerServiceServiceConnectAccessLogConfigurationFactoryExtensions
{
}
