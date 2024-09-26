// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDataPointTooltipOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.DataPointTooltipOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DataPointTooltipOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.DataPointTooltipOption Create()
    {
        var dataPointTooltipOptionResult = CreateDataPointTooltipOption();
        factoryAction?.Invoke(dataPointTooltipOptionResult);

        return dataPointTooltipOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DataPointTooltipOption CreateDataPointTooltipOption()
    {
        var dataPointTooltipOptionResult = new Humidifier.QuickSight.DashboardTypes.DataPointTooltipOption();

        return dataPointTooltipOptionResult;
    }

} // End Of Class

public static class InnerDashboardDataPointTooltipOptionFactoryExtensions
{
}
