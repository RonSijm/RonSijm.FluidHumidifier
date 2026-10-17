// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperCloudWatchLogDestinationFactory(Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.CloudWatchLogDestination>
{

    protected override Humidifier.APS.ScraperTypes.CloudWatchLogDestination Create()
    {
        var cloudWatchLogDestinationResult = CreateCloudWatchLogDestination();
        factoryAction?.Invoke(cloudWatchLogDestinationResult);

        return cloudWatchLogDestinationResult;
    }

    private Humidifier.APS.ScraperTypes.CloudWatchLogDestination CreateCloudWatchLogDestination()
    {
        var cloudWatchLogDestinationResult = new Humidifier.APS.ScraperTypes.CloudWatchLogDestination();

        return cloudWatchLogDestinationResult;
    }

} // End Of Class

public static class InnerScraperCloudWatchLogDestinationFactoryExtensions
{
}
