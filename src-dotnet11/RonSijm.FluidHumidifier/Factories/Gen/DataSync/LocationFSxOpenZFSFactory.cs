// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class LocationFSxOpenZFSFactory(string resourceName = null, Action<Humidifier.DataSync.LocationFSxOpenZFS> factoryAction = null) : ResourceFactory<Humidifier.DataSync.LocationFSxOpenZFS>(resourceName)
{

    protected override Humidifier.DataSync.LocationFSxOpenZFS Create()
    {
        var locationFSxOpenZFSResult = CreateLocationFSxOpenZFS();
        factoryAction?.Invoke(locationFSxOpenZFSResult);

        return locationFSxOpenZFSResult;
    }

    private Humidifier.DataSync.LocationFSxOpenZFS CreateLocationFSxOpenZFS()
    {
        var locationFSxOpenZFSResult = new Humidifier.DataSync.LocationFSxOpenZFS
        {
            GivenName = InputResourceName,
        };

        return locationFSxOpenZFSResult;
    }

} // End Of Class

public static class LocationFSxOpenZFSFactoryExtensions
{
}
