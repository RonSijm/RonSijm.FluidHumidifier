// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InternetMonitor;

public class InternetEventFactory(string resourceName = null, Action<Humidifier.InternetMonitor.InternetEvent> factoryAction = null) : ResourceFactory<Humidifier.InternetMonitor.InternetEvent>(resourceName)
{

    protected override Humidifier.InternetMonitor.InternetEvent Create()
    {
        var internetEventResult = CreateInternetEvent();
        factoryAction?.Invoke(internetEventResult);

        return internetEventResult;
    }

    private Humidifier.InternetMonitor.InternetEvent CreateInternetEvent()
    {
        var internetEventResult = new Humidifier.InternetMonitor.InternetEvent
        {
            GivenName = InputResourceName,
        };

        return internetEventResult;
    }

} // End Of Class

public static class InternetEventFactoryExtensions
{
}
