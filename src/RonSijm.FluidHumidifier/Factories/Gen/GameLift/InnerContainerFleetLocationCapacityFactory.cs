// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetLocationCapacityFactory(Action<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.LocationCapacity>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.LocationCapacity Create()
    {
        var locationCapacityResult = CreateLocationCapacity();
        factoryAction?.Invoke(locationCapacityResult);

        return locationCapacityResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.LocationCapacity CreateLocationCapacity()
    {
        var locationCapacityResult = new Humidifier.GameLift.ContainerFleetTypes.LocationCapacity();

        return locationCapacityResult;
    }

} // End Of Class

public static class InnerContainerFleetLocationCapacityFactoryExtensions
{
}
