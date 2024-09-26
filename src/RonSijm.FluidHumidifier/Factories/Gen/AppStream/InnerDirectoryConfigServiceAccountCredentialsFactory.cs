// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerDirectoryConfigServiceAccountCredentialsFactory(Action<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials>
{

    protected override Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials Create()
    {
        var serviceAccountCredentialsResult = CreateServiceAccountCredentials();
        factoryAction?.Invoke(serviceAccountCredentialsResult);

        return serviceAccountCredentialsResult;
    }

    private Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials CreateServiceAccountCredentials()
    {
        var serviceAccountCredentialsResult = new Humidifier.AppStream.DirectoryConfigTypes.ServiceAccountCredentials();

        return serviceAccountCredentialsResult;
    }

} // End Of Class

public static class InnerDirectoryConfigServiceAccountCredentialsFactoryExtensions
{
}
