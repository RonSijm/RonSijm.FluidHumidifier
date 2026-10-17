// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxONTAPFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxONTAP> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxONTAP>(resourceName)
{

    protected override Humidifier.DataSync.LocationFSxONTAP Create()
    {
        var locationFSxONTAPResult = CreateLocationFSxONTAP();
        factoryAction?.Invoke(locationFSxONTAPResult);

        return locationFSxONTAPResult;
    }

    private Humidifier.DataSync.LocationFSxONTAP CreateLocationFSxONTAP()
    {
        var locationFSxONTAPResult = new Humidifier.DataSync.LocationFSxONTAP
        {
            GivenName = InputResourceName,
        };

        return locationFSxONTAPResult;
    }

} // End Of Class

public static class LocationFSxONTAPFactoryExtensions
{
}
