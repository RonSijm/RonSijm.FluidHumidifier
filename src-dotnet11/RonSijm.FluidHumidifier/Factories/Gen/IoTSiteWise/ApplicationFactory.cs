// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Application> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Application>(resourceName)
{

    protected override Humidifier.IoTSiteWise.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.IoTSiteWise.Application CreateApplication()
    {
        var applicationResult = new Humidifier.IoTSiteWise.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
}
