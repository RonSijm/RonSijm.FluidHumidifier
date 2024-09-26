// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStarConnections;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.CodeStarConnections.Connection> factoryAction = null) : ResourceFactory<Humidifier.CodeStarConnections.Connection>(resourceName)
{

    protected override Humidifier.CodeStarConnections.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.CodeStarConnections.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.CodeStarConnections.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
}
