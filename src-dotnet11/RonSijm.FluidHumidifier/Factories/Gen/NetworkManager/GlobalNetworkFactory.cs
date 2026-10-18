// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class GlobalNetworkFactory(string resourceName = null, Action<Humidifier.NetworkManager.GlobalNetwork> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.GlobalNetwork>(resourceName)
{

    protected override Humidifier.NetworkManager.GlobalNetwork Create()
    {
        var globalNetworkResult = CreateGlobalNetwork();
        factoryAction?.Invoke(globalNetworkResult);

        return globalNetworkResult;
    }

    private Humidifier.NetworkManager.GlobalNetwork CreateGlobalNetwork()
    {
        var globalNetworkResult = new Humidifier.NetworkManager.GlobalNetwork
        {
            GivenName = InputResourceName,
        };

        return globalNetworkResult;
    }

} // End Of Class

public static class GlobalNetworkFactoryExtensions
{
}
