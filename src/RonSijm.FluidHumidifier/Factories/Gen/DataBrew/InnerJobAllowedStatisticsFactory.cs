// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobAllowedStatisticsFactory(Action<Humidifier.DataBrew.JobTypes.AllowedStatistics> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.AllowedStatistics>
{

    protected override Humidifier.DataBrew.JobTypes.AllowedStatistics Create()
    {
        var allowedStatisticsResult = CreateAllowedStatistics();
        factoryAction?.Invoke(allowedStatisticsResult);

        return allowedStatisticsResult;
    }

    private Humidifier.DataBrew.JobTypes.AllowedStatistics CreateAllowedStatistics()
    {
        var allowedStatisticsResult = new Humidifier.DataBrew.JobTypes.AllowedStatistics();

        return allowedStatisticsResult;
    }

} // End Of Class

public static class InnerJobAllowedStatisticsFactoryExtensions
{
}
