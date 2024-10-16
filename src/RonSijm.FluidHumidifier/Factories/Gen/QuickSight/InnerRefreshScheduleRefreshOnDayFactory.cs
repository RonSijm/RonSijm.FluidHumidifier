// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerRefreshScheduleRefreshOnDayFactory(Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay>
{

    protected override Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay Create()
    {
        var refreshOnDayResult = CreateRefreshOnDay();
        factoryAction?.Invoke(refreshOnDayResult);

        return refreshOnDayResult;
    }

    private Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay CreateRefreshOnDay()
    {
        var refreshOnDayResult = new Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay();

        return refreshOnDayResult;
    }

} // End Of Class

public static class InnerRefreshScheduleRefreshOnDayFactoryExtensions
{
}
