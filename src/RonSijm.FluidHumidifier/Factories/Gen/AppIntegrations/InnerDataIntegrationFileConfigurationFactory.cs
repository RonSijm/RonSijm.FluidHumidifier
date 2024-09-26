// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerDataIntegrationFileConfigurationFactory(Action<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration>
{

    protected override Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration Create()
    {
        var fileConfigurationResult = CreateFileConfiguration();
        factoryAction?.Invoke(fileConfigurationResult);

        return fileConfigurationResult;
    }

    private Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration CreateFileConfiguration()
    {
        var fileConfigurationResult = new Humidifier.AppIntegrations.DataIntegrationTypes.FileConfiguration();

        return fileConfigurationResult;
    }

} // End Of Class

public static class InnerDataIntegrationFileConfigurationFactoryExtensions
{
}
