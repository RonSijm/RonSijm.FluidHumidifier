// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class FleetFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.Fleet> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.Fleet>(resourceName)
{

    protected override Humidifier.IoTFleetWise.Fleet Create()
    {
        var fleetResult = CreateFleet();
        factoryAction?.Invoke(fleetResult);

        return fleetResult;
    }

    private Humidifier.IoTFleetWise.Fleet CreateFleet()
    {
        var fleetResult = new Humidifier.IoTFleetWise.Fleet
        {
            GivenName = InputResourceName,
        };

        return fleetResult;
    }

} // End Of Class

public static class FleetFactoryExtensions
{
}
