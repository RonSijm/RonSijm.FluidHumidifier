// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStarConnections;

public class SyncConfigurationFactory(string resourceName = null, Action<Humidifier.CodeStarConnections.SyncConfiguration> factoryAction = null) : ResourceFactory<Humidifier.CodeStarConnections.SyncConfiguration>(resourceName)
{

    protected override Humidifier.CodeStarConnections.SyncConfiguration Create()
    {
        var syncConfigurationResult = CreateSyncConfiguration();
        factoryAction?.Invoke(syncConfigurationResult);

        return syncConfigurationResult;
    }

    private Humidifier.CodeStarConnections.SyncConfiguration CreateSyncConfiguration()
    {
        var syncConfigurationResult = new Humidifier.CodeStarConnections.SyncConfiguration
        {
            GivenName = InputResourceName,
        };

        return syncConfigurationResult;
    }

} // End Of Class

public static class SyncConfigurationFactoryExtensions
{
}
