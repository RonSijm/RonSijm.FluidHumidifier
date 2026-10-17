// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class SatelliteFactory(string resourceName = null, Action<Humidifier.GroundStation.Satellite> factoryAction = null) : ResourceFactory<Humidifier.GroundStation.Satellite>(resourceName)
{

    protected override Humidifier.GroundStation.Satellite Create()
    {
        var satelliteResult = CreateSatellite();
        factoryAction?.Invoke(satelliteResult);

        return satelliteResult;
    }

    private Humidifier.GroundStation.Satellite CreateSatellite()
    {
        var satelliteResult = new Humidifier.GroundStation.Satellite
        {
            GivenName = InputResourceName,
        };

        return satelliteResult;
    }

} // End Of Class

public static class SatelliteFactoryExtensions
{
}
