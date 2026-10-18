// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class StreamFactory(string resourceName = null, Action<Humidifier.Cassandra.Stream> factoryAction = null) : ResourceFactory<Humidifier.Cassandra.Stream>(resourceName)
{

    protected override Humidifier.Cassandra.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.Cassandra.Stream CreateStream()
    {
        var streamResult = new Humidifier.Cassandra.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }

} // End Of Class

public static class StreamFactoryExtensions
{
}
