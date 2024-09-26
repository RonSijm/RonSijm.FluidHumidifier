// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetContainerGroupsPerInstanceFactory(Action<Humidifier.GameLift.FleetTypes.ContainerGroupsPerInstance> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.ContainerGroupsPerInstance>
{

    protected override Humidifier.GameLift.FleetTypes.ContainerGroupsPerInstance Create()
    {
        var containerGroupsPerInstanceResult = CreateContainerGroupsPerInstance();
        factoryAction?.Invoke(containerGroupsPerInstanceResult);

        return containerGroupsPerInstanceResult;
    }

    private Humidifier.GameLift.FleetTypes.ContainerGroupsPerInstance CreateContainerGroupsPerInstance()
    {
        var containerGroupsPerInstanceResult = new Humidifier.GameLift.FleetTypes.ContainerGroupsPerInstance();

        return containerGroupsPerInstanceResult;
    }

} // End Of Class

public static class InnerFleetContainerGroupsPerInstanceFactoryExtensions
{
}
