// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxWindowsFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxWindows> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxWindows>(resourceName)
{

    protected override Humidifier.DataSync.LocationFSxWindows Create()
    {
        var locationFSxWindowsResult = CreateLocationFSxWindows();
        factoryAction?.Invoke(locationFSxWindowsResult);

        return locationFSxWindowsResult;
    }

    private Humidifier.DataSync.LocationFSxWindows CreateLocationFSxWindows()
    {
        var locationFSxWindowsResult = new Humidifier.DataSync.LocationFSxWindows
        {
            GivenName = InputResourceName,
        };

        return locationFSxWindowsResult;
    }

} // End Of Class

public static class LocationFSxWindowsFactoryExtensions
{
}
