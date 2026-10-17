// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class StreamFactory(string resourceName = null, Action<Humidifier.DynamoDB.Stream> factoryAction = null) : ResourceFactory<Humidifier.DynamoDB.Stream>(resourceName)
{

    protected override Humidifier.DynamoDB.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.DynamoDB.Stream CreateStream()
    {
        var streamResult = new Humidifier.DynamoDB.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }

} // End Of Class

public static class StreamFactoryExtensions
{
}
