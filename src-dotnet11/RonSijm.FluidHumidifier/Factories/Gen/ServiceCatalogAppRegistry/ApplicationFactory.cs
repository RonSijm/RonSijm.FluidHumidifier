// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalogAppRegistry;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.ServiceCatalogAppRegistry.Application> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalogAppRegistry.Application>(resourceName)
{

    protected override Humidifier.ServiceCatalogAppRegistry.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.ServiceCatalogAppRegistry.Application CreateApplication()
    {
        var applicationResult = new Humidifier.ServiceCatalogAppRegistry.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
}
