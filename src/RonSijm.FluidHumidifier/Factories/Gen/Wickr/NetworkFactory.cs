// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wickr;

public class NetworkFactory(string resourceName = null, Action<Humidifier.Wickr.Network> factoryAction = null) : ResourceFactory<Humidifier.Wickr.Network>(resourceName)
{

    protected override Humidifier.Wickr.Network Create()
    {
        var networkResult = CreateNetwork();
        factoryAction?.Invoke(networkResult);

        return networkResult;
    }

    private Humidifier.Wickr.Network CreateNetwork()
    {
        var networkResult = new Humidifier.Wickr.Network
        {
            GivenName = InputResourceName,
        };

        return networkResult;
    }

} // End Of Class

public static class NetworkFactoryExtensions
{
}
