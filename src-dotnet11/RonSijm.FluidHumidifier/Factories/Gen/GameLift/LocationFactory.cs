// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class LocationFactory(string resourceName = null, Action<Humidifier.GameLift.Location> factoryAction = null) : ResourceFactory<Humidifier.GameLift.Location>(resourceName)
{

    protected override Humidifier.GameLift.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.GameLift.Location CreateLocation()
    {
        var locationResult = new Humidifier.GameLift.Location
        {
            GivenName = InputResourceName,
        };

        return locationResult;
    }

} // End Of Class

public static class LocationFactoryExtensions
{
}
