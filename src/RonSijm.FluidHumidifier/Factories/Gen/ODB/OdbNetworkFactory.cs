// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class OdbNetworkFactory(string resourceName = null, Action<Humidifier.ODB.OdbNetwork> factoryAction = null) : ResourceFactory<Humidifier.ODB.OdbNetwork>(resourceName)
{

    protected override Humidifier.ODB.OdbNetwork Create()
    {
        var odbNetworkResult = CreateOdbNetwork();
        factoryAction?.Invoke(odbNetworkResult);

        return odbNetworkResult;
    }

    private Humidifier.ODB.OdbNetwork CreateOdbNetwork()
    {
        var odbNetworkResult = new Humidifier.ODB.OdbNetwork
        {
            GivenName = InputResourceName,
        };

        return odbNetworkResult;
    }

} // End Of Class

public static class OdbNetworkFactoryExtensions
{
}
