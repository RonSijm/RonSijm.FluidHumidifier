// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerEnvironmentMonitorFactory(Action<Humidifier.AppConfig.EnvironmentTypes.Monitor> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.EnvironmentTypes.Monitor>
{

    protected override Humidifier.AppConfig.EnvironmentTypes.Monitor Create()
    {
        var monitorResult = CreateMonitor();
        factoryAction?.Invoke(monitorResult);

        return monitorResult;
    }

    private Humidifier.AppConfig.EnvironmentTypes.Monitor CreateMonitor()
    {
        var monitorResult = new Humidifier.AppConfig.EnvironmentTypes.Monitor();

        return monitorResult;
    }

} // End Of Class

public static class InnerEnvironmentMonitorFactoryExtensions
{
}
