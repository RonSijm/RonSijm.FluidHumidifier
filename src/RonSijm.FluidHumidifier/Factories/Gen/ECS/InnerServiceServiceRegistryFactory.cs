// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceServiceRegistryFactory(Action<Humidifier.ECS.ServiceTypes.ServiceRegistry> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ServiceRegistry>
{

    protected override Humidifier.ECS.ServiceTypes.ServiceRegistry Create()
    {
        var serviceRegistryResult = CreateServiceRegistry();
        factoryAction?.Invoke(serviceRegistryResult);

        return serviceRegistryResult;
    }

    private Humidifier.ECS.ServiceTypes.ServiceRegistry CreateServiceRegistry()
    {
        var serviceRegistryResult = new Humidifier.ECS.ServiceTypes.ServiceRegistry();

        return serviceRegistryResult;
    }

} // End Of Class

public static class InnerServiceServiceRegistryFactoryExtensions
{
}
