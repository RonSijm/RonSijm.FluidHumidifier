// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobStatisticsConfigurationFactory(Action<Humidifier.DataBrew.JobTypes.StatisticsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.StatisticsConfiguration>
{

    protected override Humidifier.DataBrew.JobTypes.StatisticsConfiguration Create()
    {
        var statisticsConfigurationResult = CreateStatisticsConfiguration();
        factoryAction?.Invoke(statisticsConfigurationResult);

        return statisticsConfigurationResult;
    }

    private Humidifier.DataBrew.JobTypes.StatisticsConfiguration CreateStatisticsConfiguration()
    {
        var statisticsConfigurationResult = new Humidifier.DataBrew.JobTypes.StatisticsConfiguration();

        return statisticsConfigurationResult;
    }

} // End Of Class

public static class InnerJobStatisticsConfigurationFactoryExtensions
{
}
