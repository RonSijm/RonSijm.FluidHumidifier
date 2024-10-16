// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class GeofenceCollectionFactory(string resourceName = null, Action<Humidifier.Location.GeofenceCollection> factoryAction = null) : ResourceFactory<Humidifier.Location.GeofenceCollection>(resourceName)
{

    protected override Humidifier.Location.GeofenceCollection Create()
    {
        var geofenceCollectionResult = CreateGeofenceCollection();
        factoryAction?.Invoke(geofenceCollectionResult);

        return geofenceCollectionResult;
    }

    private Humidifier.Location.GeofenceCollection CreateGeofenceCollection()
    {
        var geofenceCollectionResult = new Humidifier.Location.GeofenceCollection
        {
            GivenName = InputResourceName,
        };

        return geofenceCollectionResult;
    }

} // End Of Class

public static class GeofenceCollectionFactoryExtensions
{
}
