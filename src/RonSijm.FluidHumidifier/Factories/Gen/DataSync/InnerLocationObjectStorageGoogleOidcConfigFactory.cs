// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationObjectStorageGoogleOidcConfigFactory(Action<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig>
{

    protected override Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig Create()
    {
        var googleOidcConfigResult = CreateGoogleOidcConfig();
        factoryAction?.Invoke(googleOidcConfigResult);

        return googleOidcConfigResult;
    }

    private Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig CreateGoogleOidcConfig()
    {
        var googleOidcConfigResult = new Humidifier.DataSync.LocationObjectStorageTypes.GoogleOidcConfig();

        return googleOidcConfigResult;
    }

} // End Of Class

public static class InnerLocationObjectStorageGoogleOidcConfigFactoryExtensions
{
}
