// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardAdHocFilteringOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.AdHocFilteringOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.AdHocFilteringOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.AdHocFilteringOption Create()
    {
        var adHocFilteringOptionResult = CreateAdHocFilteringOption();
        factoryAction?.Invoke(adHocFilteringOptionResult);

        return adHocFilteringOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.AdHocFilteringOption CreateAdHocFilteringOption()
    {
        var adHocFilteringOptionResult = new Humidifier.QuickSight.DashboardTypes.AdHocFilteringOption();

        return adHocFilteringOptionResult;
    }

} // End Of Class

public static class InnerDashboardAdHocFilteringOptionFactoryExtensions
{
}
