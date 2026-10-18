// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class DiscoveryFactory(string resourceName = null, Action<Humidifier.ApplicationSignals.Discovery> factoryAction = null) : ResourceFactory<Humidifier.ApplicationSignals.Discovery>(resourceName)
{

    protected override Humidifier.ApplicationSignals.Discovery Create()
    {
        var discoveryResult = CreateDiscovery();
        factoryAction?.Invoke(discoveryResult);

        return discoveryResult;
    }

    private Humidifier.ApplicationSignals.Discovery CreateDiscovery()
    {
        var discoveryResult = new Humidifier.ApplicationSignals.Discovery
        {
            GivenName = InputResourceName,
        };

        return discoveryResult;
    }

} // End Of Class

public static class DiscoveryFactoryExtensions
{
}
