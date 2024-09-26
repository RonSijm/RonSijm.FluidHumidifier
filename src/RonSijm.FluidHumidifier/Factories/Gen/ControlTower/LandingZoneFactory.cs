// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlTower;

public class LandingZoneFactory(string resourceName = null, Action<Humidifier.ControlTower.LandingZone> factoryAction = null) : ResourceFactory<Humidifier.ControlTower.LandingZone>(resourceName)
{

    protected override Humidifier.ControlTower.LandingZone Create()
    {
        var landingZoneResult = CreateLandingZone();
        factoryAction?.Invoke(landingZoneResult);

        return landingZoneResult;
    }

    private Humidifier.ControlTower.LandingZone CreateLandingZone()
    {
        var landingZoneResult = new Humidifier.ControlTower.LandingZone
        {
            GivenName = InputResourceName,
        };

        return landingZoneResult;
    }

} // End Of Class

public static class LandingZoneFactoryExtensions
{
}
