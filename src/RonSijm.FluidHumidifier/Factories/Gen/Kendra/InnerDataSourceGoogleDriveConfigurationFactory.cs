// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceGoogleDriveConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.GoogleDriveConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.GoogleDriveConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.GoogleDriveConfiguration Create()
    {
        var googleDriveConfigurationResult = CreateGoogleDriveConfiguration();
        factoryAction?.Invoke(googleDriveConfigurationResult);

        return googleDriveConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.GoogleDriveConfiguration CreateGoogleDriveConfiguration()
    {
        var googleDriveConfigurationResult = new Humidifier.Kendra.DataSourceTypes.GoogleDriveConfiguration();

        return googleDriveConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceGoogleDriveConfigurationFactoryExtensions
{
}
