// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDataPointMenuLabelOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.DataPointMenuLabelOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DataPointMenuLabelOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.DataPointMenuLabelOption Create()
    {
        var dataPointMenuLabelOptionResult = CreateDataPointMenuLabelOption();
        factoryAction?.Invoke(dataPointMenuLabelOptionResult);

        return dataPointMenuLabelOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DataPointMenuLabelOption CreateDataPointMenuLabelOption()
    {
        var dataPointMenuLabelOptionResult = new Humidifier.QuickSight.DashboardTypes.DataPointMenuLabelOption();

        return dataPointMenuLabelOptionResult;
    }

} // End Of Class

public static class InnerDashboardDataPointMenuLabelOptionFactoryExtensions
{
}
