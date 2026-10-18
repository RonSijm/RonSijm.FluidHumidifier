// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperCloudWatchConfigurationFactory(Action<Humidifier.APS.ScraperTypes.CloudWatchConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.CloudWatchConfiguration>
{

    protected override Humidifier.APS.ScraperTypes.CloudWatchConfiguration Create()
    {
        var cloudWatchConfigurationResult = CreateCloudWatchConfiguration();
        factoryAction?.Invoke(cloudWatchConfigurationResult);

        return cloudWatchConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.CloudWatchConfiguration CreateCloudWatchConfiguration()
    {
        var cloudWatchConfigurationResult = new Humidifier.APS.ScraperTypes.CloudWatchConfiguration();

        return cloudWatchConfigurationResult;
    }

} // End Of Class

public static class InnerScraperCloudWatchConfigurationFactoryExtensions
{
}
