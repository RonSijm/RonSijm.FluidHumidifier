// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class VehicleFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.Vehicle> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.Vehicle>(resourceName)
{

    protected override Humidifier.IoTFleetWise.Vehicle Create()
    {
        var vehicleResult = CreateVehicle();
        factoryAction?.Invoke(vehicleResult);

        return vehicleResult;
    }

    private Humidifier.IoTFleetWise.Vehicle CreateVehicle()
    {
        var vehicleResult = new Humidifier.IoTFleetWise.Vehicle
        {
            GivenName = InputResourceName,
        };

        return vehicleResult;
    }

} // End Of Class

public static class VehicleFactoryExtensions
{
}
