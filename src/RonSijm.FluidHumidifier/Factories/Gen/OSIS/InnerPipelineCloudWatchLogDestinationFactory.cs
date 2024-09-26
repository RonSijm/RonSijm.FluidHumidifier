// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineCloudWatchLogDestinationFactory(Action<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination>
{

    protected override Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination Create()
    {
        var cloudWatchLogDestinationResult = CreateCloudWatchLogDestination();
        factoryAction?.Invoke(cloudWatchLogDestinationResult);

        return cloudWatchLogDestinationResult;
    }

    private Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination CreateCloudWatchLogDestination()
    {
        var cloudWatchLogDestinationResult = new Humidifier.OSIS.PipelineTypes.CloudWatchLogDestination();

        return cloudWatchLogDestinationResult;
    }

} // End Of Class

public static class InnerPipelineCloudWatchLogDestinationFactoryExtensions
{
}
