// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class OdbPeeringConnectionFactory(string resourceName = null, Action<Humidifier.ODB.OdbPeeringConnection> factoryAction = null) : ResourceFactory<Humidifier.ODB.OdbPeeringConnection>(resourceName)
{

    protected override Humidifier.ODB.OdbPeeringConnection Create()
    {
        var odbPeeringConnectionResult = CreateOdbPeeringConnection();
        factoryAction?.Invoke(odbPeeringConnectionResult);

        return odbPeeringConnectionResult;
    }

    private Humidifier.ODB.OdbPeeringConnection CreateOdbPeeringConnection()
    {
        var odbPeeringConnectionResult = new Humidifier.ODB.OdbPeeringConnection
        {
            GivenName = InputResourceName,
        };

        return odbPeeringConnectionResult;
    }

} // End Of Class

public static class OdbPeeringConnectionFactoryExtensions
{
}
