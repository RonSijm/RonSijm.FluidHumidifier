// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskSetServiceRegistryFactory(Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskSetTypes.ServiceRegistry>
{

    protected override Humidifier.ECS.TaskSetTypes.ServiceRegistry Create()
    {
        var serviceRegistryResult = CreateServiceRegistry();
        factoryAction?.Invoke(serviceRegistryResult);

        return serviceRegistryResult;
    }

    private Humidifier.ECS.TaskSetTypes.ServiceRegistry CreateServiceRegistry()
    {
        var serviceRegistryResult = new Humidifier.ECS.TaskSetTypes.ServiceRegistry();

        return serviceRegistryResult;
    }

} // End Of Class

public static class InnerTaskSetServiceRegistryFactoryExtensions
{
}
