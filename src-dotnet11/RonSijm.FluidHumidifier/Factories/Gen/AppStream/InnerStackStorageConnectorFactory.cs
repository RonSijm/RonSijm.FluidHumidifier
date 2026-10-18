// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackStorageConnectorFactory(Action<Humidifier.AppStream.StackTypes.StorageConnector> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.StorageConnector>
{

    protected override Humidifier.AppStream.StackTypes.StorageConnector Create()
    {
        var storageConnectorResult = CreateStorageConnector();
        factoryAction?.Invoke(storageConnectorResult);

        return storageConnectorResult;
    }

    private Humidifier.AppStream.StackTypes.StorageConnector CreateStorageConnector()
    {
        var storageConnectorResult = new Humidifier.AppStream.StackTypes.StorageConnector();

        return storageConnectorResult;
    }

} // End Of Class

public static class InnerStackStorageConnectorFactoryExtensions
{
}
