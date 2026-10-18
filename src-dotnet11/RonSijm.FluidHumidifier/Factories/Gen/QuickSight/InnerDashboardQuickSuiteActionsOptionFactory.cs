// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardQuickSuiteActionsOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.QuickSuiteActionsOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.QuickSuiteActionsOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.QuickSuiteActionsOption Create()
    {
        var quickSuiteActionsOptionResult = CreateQuickSuiteActionsOption();
        factoryAction?.Invoke(quickSuiteActionsOptionResult);

        return quickSuiteActionsOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.QuickSuiteActionsOption CreateQuickSuiteActionsOption()
    {
        var quickSuiteActionsOptionResult = new Humidifier.QuickSight.DashboardTypes.QuickSuiteActionsOption();

        return quickSuiteActionsOptionResult;
    }

} // End Of Class

public static class InnerDashboardQuickSuiteActionsOptionFactoryExtensions
{
}
