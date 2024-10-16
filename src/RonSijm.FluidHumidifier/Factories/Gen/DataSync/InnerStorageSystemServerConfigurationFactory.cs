// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerStorageSystemServerConfigurationFactory(Action<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.StorageSystemTypes.ServerConfiguration>
{

    protected override Humidifier.DataSync.StorageSystemTypes.ServerConfiguration Create()
    {
        var serverConfigurationResult = CreateServerConfiguration();
        factoryAction?.Invoke(serverConfigurationResult);

        return serverConfigurationResult;
    }

    private Humidifier.DataSync.StorageSystemTypes.ServerConfiguration CreateServerConfiguration()
    {
        var serverConfigurationResult = new Humidifier.DataSync.StorageSystemTypes.ServerConfiguration();

        return serverConfigurationResult;
    }

} // End Of Class

public static class InnerStorageSystemServerConfigurationFactoryExtensions
{
}
