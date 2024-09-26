// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class SyncJobFactory(string resourceName = null, Action<Humidifier.IoTTwinMaker.SyncJob> factoryAction = null) : ResourceFactory<Humidifier.IoTTwinMaker.SyncJob>(resourceName)
{

    protected override Humidifier.IoTTwinMaker.SyncJob Create()
    {
        var syncJobResult = CreateSyncJob();
        factoryAction?.Invoke(syncJobResult);

        return syncJobResult;
    }

    private Humidifier.IoTTwinMaker.SyncJob CreateSyncJob()
    {
        var syncJobResult = new Humidifier.IoTTwinMaker.SyncJob
        {
            GivenName = InputResourceName,
        };

        return syncJobResult;
    }

} // End Of Class

public static class SyncJobFactoryExtensions
{
}
