// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeConnections;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.CodeConnections.Connection> factoryAction = null) : ResourceFactory<Humidifier.CodeConnections.Connection>(resourceName)
{

    protected override Humidifier.CodeConnections.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.CodeConnections.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.CodeConnections.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
}
