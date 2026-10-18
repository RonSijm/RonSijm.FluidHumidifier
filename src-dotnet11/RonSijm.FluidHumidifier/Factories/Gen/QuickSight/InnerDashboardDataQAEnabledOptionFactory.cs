// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDataQAEnabledOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.DataQAEnabledOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DataQAEnabledOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.DataQAEnabledOption Create()
    {
        var dataQAEnabledOptionResult = CreateDataQAEnabledOption();
        factoryAction?.Invoke(dataQAEnabledOptionResult);

        return dataQAEnabledOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DataQAEnabledOption CreateDataQAEnabledOption()
    {
        var dataQAEnabledOptionResult = new Humidifier.QuickSight.DashboardTypes.DataQAEnabledOption();

        return dataQAEnabledOptionResult;
    }

} // End Of Class

public static class InnerDashboardDataQAEnabledOptionFactoryExtensions
{
}
