// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxLustreFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxLustre> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxLustre>(resourceName)
{

    protected override Humidifier.DataSync.LocationFSxLustre Create()
    {
        var locationFSxLustreResult = CreateLocationFSxLustre();
        factoryAction?.Invoke(locationFSxLustreResult);

        return locationFSxLustreResult;
    }

    private Humidifier.DataSync.LocationFSxLustre CreateLocationFSxLustre()
    {
        var locationFSxLustreResult = new Humidifier.DataSync.LocationFSxLustre
        {
            GivenName = InputResourceName,
        };

        return locationFSxLustreResult;
    }

} // End Of Class

public static class LocationFSxLustreFactoryExtensions
{
}
