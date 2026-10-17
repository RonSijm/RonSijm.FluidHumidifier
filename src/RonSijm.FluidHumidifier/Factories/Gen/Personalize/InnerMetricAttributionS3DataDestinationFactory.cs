// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerMetricAttributionS3DataDestinationFactory(Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination>
{

    protected override Humidifier.Personalize.MetricAttributionTypes.S3DataDestination Create()
    {
        var s3DataDestinationResult = CreateS3DataDestination();
        factoryAction?.Invoke(s3DataDestinationResult);

        return s3DataDestinationResult;
    }

    private Humidifier.Personalize.MetricAttributionTypes.S3DataDestination CreateS3DataDestination()
    {
        var s3DataDestinationResult = new Humidifier.Personalize.MetricAttributionTypes.S3DataDestination();

        return s3DataDestinationResult;
    }

} // End Of Class

public static class InnerMetricAttributionS3DataDestinationFactoryExtensions
{
}
