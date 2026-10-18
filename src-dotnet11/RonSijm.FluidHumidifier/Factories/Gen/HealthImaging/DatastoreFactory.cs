// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthImaging;

public class DatastoreFactory(string resourceName = null, Action<Humidifier.HealthImaging.Datastore> factoryAction = null) : ResourceFactory<Humidifier.HealthImaging.Datastore>(resourceName)
{

    protected override Humidifier.HealthImaging.Datastore Create()
    {
        var datastoreResult = CreateDatastore();
        factoryAction?.Invoke(datastoreResult);

        return datastoreResult;
    }

    private Humidifier.HealthImaging.Datastore CreateDatastore()
    {
        var datastoreResult = new Humidifier.HealthImaging.Datastore
        {
            GivenName = InputResourceName,
        };

        return datastoreResult;
    }

} // End Of Class

public static class DatastoreFactoryExtensions
{
}
