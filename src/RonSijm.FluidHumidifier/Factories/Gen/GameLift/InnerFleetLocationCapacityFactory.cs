// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetLocationCapacityFactory(Action<Humidifier.GameLift.FleetTypes.LocationCapacity> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.LocationCapacity>
{

    protected override Humidifier.GameLift.FleetTypes.LocationCapacity Create()
    {
        var locationCapacityResult = CreateLocationCapacity();
        factoryAction?.Invoke(locationCapacityResult);

        return locationCapacityResult;
    }

    private Humidifier.GameLift.FleetTypes.LocationCapacity CreateLocationCapacity()
    {
        var locationCapacityResult = new Humidifier.GameLift.FleetTypes.LocationCapacity();

        return locationCapacityResult;
    }

} // End Of Class

public static class InnerFleetLocationCapacityFactoryExtensions
{
}
