// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerStorageSystemServerCredentialsFactory(Action<Humidifier.DataSync.StorageSystemTypes.ServerCredentials> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.StorageSystemTypes.ServerCredentials>
{

    protected override Humidifier.DataSync.StorageSystemTypes.ServerCredentials Create()
    {
        var serverCredentialsResult = CreateServerCredentials();
        factoryAction?.Invoke(serverCredentialsResult);

        return serverCredentialsResult;
    }

    private Humidifier.DataSync.StorageSystemTypes.ServerCredentials CreateServerCredentials()
    {
        var serverCredentialsResult = new Humidifier.DataSync.StorageSystemTypes.ServerCredentials();

        return serverCredentialsResult;
    }

} // End Of Class

public static class InnerStorageSystemServerCredentialsFactoryExtensions
{
}
