// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.DirectConnect.Connection> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.Connection>(resourceName)
{

    protected override Humidifier.DirectConnect.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.DirectConnect.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.DirectConnect.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
}
