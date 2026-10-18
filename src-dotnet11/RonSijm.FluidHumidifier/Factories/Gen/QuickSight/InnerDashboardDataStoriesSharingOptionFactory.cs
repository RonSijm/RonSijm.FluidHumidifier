// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDataStoriesSharingOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.DataStoriesSharingOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DataStoriesSharingOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.DataStoriesSharingOption Create()
    {
        var dataStoriesSharingOptionResult = CreateDataStoriesSharingOption();
        factoryAction?.Invoke(dataStoriesSharingOptionResult);

        return dataStoriesSharingOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DataStoriesSharingOption CreateDataStoriesSharingOption()
    {
        var dataStoriesSharingOptionResult = new Humidifier.QuickSight.DashboardTypes.DataStoriesSharingOption();

        return dataStoriesSharingOptionResult;
    }

} // End Of Class

public static class InnerDashboardDataStoriesSharingOptionFactoryExtensions
{
}
