// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class ContainerInstanceFactory(string resourceName = null, Action<Humidifier.ECS.ContainerInstance> factoryAction = null) : ResourceFactory<Humidifier.ECS.ContainerInstance>(resourceName)
{

    protected override Humidifier.ECS.ContainerInstance Create()
    {
        var containerInstanceResult = CreateContainerInstance();
        factoryAction?.Invoke(containerInstanceResult);

        return containerInstanceResult;
    }

    private Humidifier.ECS.ContainerInstance CreateContainerInstance()
    {
        var containerInstanceResult = new Humidifier.ECS.ContainerInstance
        {
            GivenName = InputResourceName,
        };

        return containerInstanceResult;
    }

} // End Of Class

public static class ContainerInstanceFactoryExtensions
{
}
