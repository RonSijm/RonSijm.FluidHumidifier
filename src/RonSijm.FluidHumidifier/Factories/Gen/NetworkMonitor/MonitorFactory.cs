// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkMonitor;

public class MonitorFactory(string resourceName = null, Action<Humidifier.NetworkMonitor.Monitor> factoryAction = null) : ResourceFactory<Humidifier.NetworkMonitor.Monitor>(resourceName)
{

    protected override Humidifier.NetworkMonitor.Monitor Create()
    {
        var monitorResult = CreateMonitor();
        factoryAction?.Invoke(monitorResult);

        return monitorResult;
    }

    private Humidifier.NetworkMonitor.Monitor CreateMonitor()
    {
        var monitorResult = new Humidifier.NetworkMonitor.Monitor
        {
            GivenName = InputResourceName,
        };

        return monitorResult;
    }

} // End Of Class

public static class MonitorFactoryExtensions
{
}
