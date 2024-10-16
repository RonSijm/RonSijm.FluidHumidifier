// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class MonitorFactory(string resourceName = null, Action<Humidifier.Deadline.Monitor> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Monitor>(resourceName)
{

    protected override Humidifier.Deadline.Monitor Create()
    {
        var monitorResult = CreateMonitor();
        factoryAction?.Invoke(monitorResult);

        return monitorResult;
    }

    private Humidifier.Deadline.Monitor CreateMonitor()
    {
        var monitorResult = new Humidifier.Deadline.Monitor
        {
            GivenName = InputResourceName,
        };

        return monitorResult;
    }

} // End Of Class

public static class MonitorFactoryExtensions
{
}
