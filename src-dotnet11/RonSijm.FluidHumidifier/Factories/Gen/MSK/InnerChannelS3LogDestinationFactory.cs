// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelS3LogDestinationFactory(Action<Humidifier.MSK.ChannelTypes.S3LogDestination> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.S3LogDestination>
{

    protected override Humidifier.MSK.ChannelTypes.S3LogDestination Create()
    {
        var s3LogDestinationResult = CreateS3LogDestination();
        factoryAction?.Invoke(s3LogDestinationResult);

        return s3LogDestinationResult;
    }

    private Humidifier.MSK.ChannelTypes.S3LogDestination CreateS3LogDestination()
    {
        var s3LogDestinationResult = new Humidifier.MSK.ChannelTypes.S3LogDestination();

        return s3LogDestinationResult;
    }

} // End Of Class

public static class InnerChannelS3LogDestinationFactoryExtensions
{
}
