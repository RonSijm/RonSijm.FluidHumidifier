// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class CoreNetworkFactory(string resourceName = null, Action<Humidifier.NetworkManager.CoreNetwork> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.CoreNetwork>(resourceName)
{

    protected override Humidifier.NetworkManager.CoreNetwork Create()
    {
        var coreNetworkResult = CreateCoreNetwork();
        factoryAction?.Invoke(coreNetworkResult);

        return coreNetworkResult;
    }

    private Humidifier.NetworkManager.CoreNetwork CreateCoreNetwork()
    {
        var coreNetworkResult = new Humidifier.NetworkManager.CoreNetwork
        {
            GivenName = InputResourceName,
        };

        return coreNetworkResult;
    }

} // End Of Class

public static class CoreNetworkFactoryExtensions
{
}
