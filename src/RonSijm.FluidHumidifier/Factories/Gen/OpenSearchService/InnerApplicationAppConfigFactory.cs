// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerApplicationAppConfigFactory(Action<Humidifier.OpenSearchService.ApplicationTypes.AppConfig> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.ApplicationTypes.AppConfig>
{

    protected override Humidifier.OpenSearchService.ApplicationTypes.AppConfig Create()
    {
        var appConfigResult = CreateAppConfig();
        factoryAction?.Invoke(appConfigResult);

        return appConfigResult;
    }

    private Humidifier.OpenSearchService.ApplicationTypes.AppConfig CreateAppConfig()
    {
        var appConfigResult = new Humidifier.OpenSearchService.ApplicationTypes.AppConfig();

        return appConfigResult;
    }

} // End Of Class

public static class InnerApplicationAppConfigFactoryExtensions
{
}
