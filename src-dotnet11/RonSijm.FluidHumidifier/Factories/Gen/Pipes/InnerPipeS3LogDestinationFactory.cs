// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeS3LogDestinationFactory(Action<Humidifier.Pipes.PipeTypes.S3LogDestination> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.S3LogDestination>
{

    protected override Humidifier.Pipes.PipeTypes.S3LogDestination Create()
    {
        var s3LogDestinationResult = CreateS3LogDestination();
        factoryAction?.Invoke(s3LogDestinationResult);

        return s3LogDestinationResult;
    }

    private Humidifier.Pipes.PipeTypes.S3LogDestination CreateS3LogDestination()
    {
        var s3LogDestinationResult = new Humidifier.Pipes.PipeTypes.S3LogDestination();

        return s3LogDestinationResult;
    }

} // End Of Class

public static class InnerPipeS3LogDestinationFactoryExtensions
{
}
