// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkMonitor;

public class ProbeFactory(string resourceName = null, Action<Humidifier.NetworkMonitor.Probe> factoryAction = null) : ResourceFactory<Humidifier.NetworkMonitor.Probe>(resourceName)
{

    protected override Humidifier.NetworkMonitor.Probe Create()
    {
        var probeResult = CreateProbe();
        factoryAction?.Invoke(probeResult);

        return probeResult;
    }

    private Humidifier.NetworkMonitor.Probe CreateProbe()
    {
        var probeResult = new Humidifier.NetworkMonitor.Probe
        {
            GivenName = InputResourceName,
        };

        return probeResult;
    }

} // End Of Class

public static class ProbeFactoryExtensions
{
}
