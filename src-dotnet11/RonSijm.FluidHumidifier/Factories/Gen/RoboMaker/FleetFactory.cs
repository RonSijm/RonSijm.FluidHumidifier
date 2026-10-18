// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class FleetFactory(string resourceName = null, Action<Humidifier.RoboMaker.Fleet> factoryAction = null) : ResourceFactory<Humidifier.RoboMaker.Fleet>(resourceName)
{

    protected override Humidifier.RoboMaker.Fleet Create()
    {
        var fleetResult = CreateFleet();
        factoryAction?.Invoke(fleetResult);

        return fleetResult;
    }

    private Humidifier.RoboMaker.Fleet CreateFleet()
    {
        var fleetResult = new Humidifier.RoboMaker.Fleet
        {
            GivenName = InputResourceName,
        };

        return fleetResult;
    }

} // End Of Class

public static class FleetFactoryExtensions
{
}
