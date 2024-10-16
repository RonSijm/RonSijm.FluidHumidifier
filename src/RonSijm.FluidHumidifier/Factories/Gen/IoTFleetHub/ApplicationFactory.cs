// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetHub;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.IoTFleetHub.Application> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetHub.Application>(resourceName)
{

    protected override Humidifier.IoTFleetHub.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.IoTFleetHub.Application CreateApplication()
    {
        var applicationResult = new Humidifier.IoTFleetHub.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
}
