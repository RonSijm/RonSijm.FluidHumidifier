// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardExecutiveSummaryOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.ExecutiveSummaryOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.ExecutiveSummaryOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.ExecutiveSummaryOption Create()
    {
        var executiveSummaryOptionResult = CreateExecutiveSummaryOption();
        factoryAction?.Invoke(executiveSummaryOptionResult);

        return executiveSummaryOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.ExecutiveSummaryOption CreateExecutiveSummaryOption()
    {
        var executiveSummaryOptionResult = new Humidifier.QuickSight.DashboardTypes.ExecutiveSummaryOption();

        return executiveSummaryOptionResult;
    }

} // End Of Class

public static class InnerDashboardExecutiveSummaryOptionFactoryExtensions
{
}
