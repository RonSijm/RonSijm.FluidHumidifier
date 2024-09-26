// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDataPointDrillUpDownOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.DataPointDrillUpDownOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DataPointDrillUpDownOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.DataPointDrillUpDownOption Create()
    {
        var dataPointDrillUpDownOptionResult = CreateDataPointDrillUpDownOption();
        factoryAction?.Invoke(dataPointDrillUpDownOptionResult);

        return dataPointDrillUpDownOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DataPointDrillUpDownOption CreateDataPointDrillUpDownOption()
    {
        var dataPointDrillUpDownOptionResult = new Humidifier.QuickSight.DashboardTypes.DataPointDrillUpDownOption();

        return dataPointDrillUpDownOptionResult;
    }

} // End Of Class

public static class InnerDashboardDataPointDrillUpDownOptionFactoryExtensions
{
}
